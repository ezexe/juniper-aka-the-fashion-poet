namespace Juniper.Core.Services
{
    public class RestClientService
    {
        public static readonly RestClientService Current = Ioc.Default.GetRequiredService<RestClientService>();

        readonly RestClient _client;

        public static string SPSBaseApiUrl => "https://api.spscommerce.com/";
        public static string SPStransactionsDataApiUrl => SPSBaseApiUrl + "transactions/v5/data/";
        public static string SPStransactionsDataInApiUrl => SPStransactionsDataApiUrl + "in/";
        public static string SPStransactionsDataOutApiUrl => SPStransactionsDataApiUrl + "out/";
        public static string SPStransactionsTestInDataApiUrl => SPStransactionsDataApiUrl + "testin/";
        public static string SPStransactionsTestOutDataApiUrl => SPStransactionsDataApiUrl + "testout/";
        public static string SPStransactionsHistoryApiUrl => SPSBaseApiUrl + "transactions/v5/history/";
        public static string SPStransactionsLablesApiUrl => SPSBaseApiUrl + "label/v1/";

        public RestClientService()
        {
            _client = new RestClient(new RestClientOptions()
            {
                ThrowOnAnyError = false,
                MaxTimeout = 10000,
            });
        }
        private async Task<RestResponse> GetRequest(string url)
        {
            MainViewModel.Current.DisplayInfobarMessage("Get Request...", $"loading {url}", InfoSeverity.Informational);

            var response = await _client.ExecuteAsync(new RestRequest(url, Method.Get)
                .AddHeader("Authorization", "Bearer " + await MainViewModel.Current.SettingsViewModel.GetLoadAccessToken()));

            MainViewModel.Current.DisplayInfobarMessage("Get Request Done", $"loading {url}", InfoSeverity.Success);

            return response;
        }

        public async Task<TransactionsHistory> GetHistoryRequest()
        {
            TransactionsHistory returned = new();
            var initResponse = await GetRequest(SPStransactionsHistoryApiUrl);
            TransactionsApiHistoryResponse irc = new() { Root = initResponse?.Content?.Deserialize<Rootobject>() };
            while (irc?.Root?.paging?.next?.url != null)
            {
                var np = await GetRequest(irc.Root.paging.next.url);
                irc.Root = np?.Content?.Deserialize<Rootobject>();
                if (irc != null && irc.Root != null)
                {
                    returned.ApiResponses.Add(irc);
                    foreach (var res in irc.Root.results)
                    {
                        if (res.path.StartsWith("in/PO"))
                        {
                            var r = await GetRequest(res.path);
                            if (r.Content?.Deserialize<SPSCommerceSDK.Models.Orders.Order>() is { } o)
                                returned.OrderResponses.Add(o);
                        }
                        else if (res.path.StartsWith("in/SH"))
                        {
                            var r = await GetRequest(res.path);
                            if (r.Content?.Deserialize<SPSCommerceSDK.Models.Shipments.Shipment>() is { } s)
                            {
                                returned.ShipmentResponses.Add(s);

                                var tradingPartner = MainViewModel.Current.TradingPartners.SingleOrDefault(p => p.TradingPartnerId == s.Header?.ShipmentHeader?.TradingPartnerId);
                                foreach (OrderLevelElement? item in s.OrderLevel)
                                {
                                    var o = new OrderPackItemModel()
                                    {
                                        PurchaseOrderNumber = item.OrderHeader.PurchaseOrderNumber,
                                        Department = item.OrderHeader.Department,
                                    };
                                    foreach (var qw in item.PackLevel)
                                    {
                                        if(qw.Pack.ShippingSerialId == "00081006543999977586")
                                        {

                                        }
                                        var p = new PackItemModel();
                                        p.SIPackLevelType = p.PackLevelType.GetToupleByItem(qw.Pack.PackLevelType) ?? 0;
                                        p.ShippingSerialID = qw.Pack.ShippingSerialId;
                                        foreach (var q in qw.ItemLevel)
                                        {
                                            var sl = new ShipmentLine()
                                            {
                                                ConsumerPackageCode = q.ShipmentLine.ConsumerPackageCode,
                                                ShipQty = q.ShipmentLine.ShipQty ?? 0,
                                                ShipQtyUOM = q.ShipmentLine.ShipQtyUom
                                            };
                                            p.ItemLevel.ShipmentLines.Add(sl);
                                        }
                                        o.PackLevelList.Add(p);
                                    }
                                    foreach (var qaw in item.QuantityAndWeight)
                                    {
                                        o.QuantityAndWeight = new BaseQuantityAndWeightModel
                                        {
                                            LadingQuantity = qaw.LadingQuantity ?? 1,
                                            Weight = qaw.Weight ?? 3.0,
                                            PackingMedium = qaw.PackingMedium,
                                            PackingMaterial = qaw.PackingMaterial,
                                            WeightQualifier = qaw.WeightQualifier,
                                            WeightUOM = qaw.WeightUom
                                        };
                                        o.QuantityAndWeightCollection.Add(o.QuantityAndWeight);
                                    }
                                    foreach (var a in item.Address)
                                    {
                                        if (a.AddressLocationNumber is string llocation)
                                        {
                                            string dclocnumb = "";
                                            string dc = "";
                                            var addyModel = tradingPartner.GetAddressModelFor(llocation, false); //await ShipmentsViewModel.GetAddressModelAsync(ShipmentHeader.TradingPartnerId, llocation, IsNordstrom);
                                            if (addyModel is not null)
                                            {
                                                dclocnumb = addyModel.DCAddressLocationNumber;
                                                dc = addyModel.DC;
                                            }
                                            o.Address = new BaseAddressModel()
                                            {
                                                AddressLocationNumber = a.AddressLocationNumber,
                                                DC = dc,
                                                DCAddressLocationNumber = dclocnumb
                                            };
                                            o.Address.SIAddressTypeCode = o.Address.AddressTypeCode.GetToupleByItem(a.AddressTypeCode) ?? 41;
                                            o.Address.SILocationCodeQualifier = o.Address.LocationCodeQualifier.GetToupleByItem(a.LocationCodeQualifier) ?? 9;
                                            o.AddressCollection.Add(o.Address);
                                        }
                                    }
                                }
                            }
                        }
                        else if (res.path.StartsWith("in/IN"))
                        {

                            var r = await GetRequest(SPStransactionsDataApiUrl + res.path);
                            if (r.Content?.Deserialize<SPSCommerceSDK.Models.Invoices.Invoice>() is { } i)
                                returned.InvoiceResponses.Add(i);
                        }
                    }
                }
            }

            return returned;
        }

        public async Task<RestResponse> PostRequest(string itemId, byte[] bytes)
        {
            var url =
                 itemId.Insert(0, SettingsViewModel.StateofSandbox ? SPStransactionsTestInDataApiUrl : SPStransactionsDataInApiUrl);

            MainViewModel.Current.DisplayInfobarMessage("Post Request...", $"loading {url}", InfoSeverity.Informational);

            var token = await MainViewModel.Current.SettingsViewModel.GetLoadAccessToken();

            var request = new RestRequest(url, Method.Post)
                .AddHeader("Content-Type", "application/octet-stream")
                .AddHeader("Authorization", "Bearer " + token)
                .AddBody(bytes, "application/octet-stream");

            return await _client.ExecuteAsync(request);
        }

        public async Task<RestResponse> DeleteRequest(string url)
        {
            var token = await MainViewModel.Current.SettingsViewModel.GetLoadAccessToken();

            var request = new RestRequest(url, Method.Delete)
                .AddHeader("Authorization", "Bearer " + token);

            return await _client.ExecuteAsync(request);
        }

        public async Task<FilterTransactiosnResponses?> GetTransactionsByDirPathAsync()
        {
            var response = await GetRequest(SettingsViewModel.StateofSandbox ? SPStransactionsTestOutDataApiUrl : SPStransactionsDataOutApiUrl);
            if (!response.IsSuccessful || response.Content is null)
            {
                throw new Exception("GetTransactionsByDirPathAsync Failed", response.ErrorException);
            }

            return JsonSerializer.Deserialize<FilterTransactiosnResponses>(response.Content);
        }
        
        public async Task<string> GetTransactionAsync(string url)
        {
            var response = await GetRequest(url);
            if (!response.IsSuccessful || response.Content is null)
            {
                throw new Exception("GetTransactionAsync Failed", response.ErrorException);
            }

            return response.Content;
        }

        public async Task<byte[]> GetLabelesRequestAsync(string tpID, string path, ShipingLabelAll labels)
        {
            var token = await MainViewModel.Current.SettingsViewModel.GetLoadAccessToken();
            var url = SPStransactionsLablesApiUrl + $"{tpID}/{path}";
                var json = labels.Serialize();

            var request = new RestRequest(url, Method.Post)
                .AddHeader("Content-Type", "application/json")
                .AddHeader("Authorization", "Bearer " + token)
                .AddStringBody(json, DataFormat.Json);

            var response = await _client.ExecuteAsync(request);

            if (!response.IsSuccessful || response.Content == null)
            {
                throw new Exception(response.Content, response.ErrorException);
            }
            else
            {
                Rootobject1? o = JsonSerializer.Deserialize<Rootobject1>(response.Content);
                if (o != null)
                {
                    int times = 0;
                    Rootobject2? o2;
                    do
                    {
                        if (times++ == 22)
                            throw new Exception("times++ == 22");

                        await Task.Delay(500);

                        var response2 = await GetRequest(o.statusURL);

                        if (response2.Content == null)
                            throw new Exception("response2.Content == null " + response2.ErrorMessage);

                        o2 = JsonSerializer.Deserialize<Rootobject2>(response2.Content);
                    } while (o2?.status == "In Progress");

                    if (o2 is null || o2?.status == "Failed")
                    {
                        string errord = "";
                        if (o2?.validationErrors != null)
                            foreach (var item in o2.validationErrors)
                                errord += item.message + Environment.NewLine;

                        throw new Exception($"Rootobject2 Failed {o2?.failureDescription} {errord}");
                    }

                    if (o2?.status == "Completed")
                    {
                        var response2 = await GetRequest(o2.resultURL);

                        if(response2 == null)
                            throw new Exception("response2 == null");

                        if (response2.RawBytes == null)
                            throw new Exception("response2.RawBytes == null");

                        if (response2.IsSuccessful)
                        {
                            return response2.RawBytes;
                        }
                    }

                    throw new Exception("Failed to get label pdf file");
                }
                else
                {
                    throw new Exception("Rootobject1 is null");
                }
            }
        }

        public async Task<AccessTokenResponse> GetAccessTokenRequestAsync(AccessTokenRequest tokenRequest)
        {
            var json = tokenRequest.Serialize();
            var request = new RestRequest("https://auth.spscommerce.com/oauth/token", Method.Post)
                .AddHeader("Content-Type", "application/json")
                .AddStringBody(json, DataFormat.Json);

            //request.AddParameter("application/json", JsonSerializer.Serialize(tokenRequest), RestSharp.ParameterType.RequestBody);
            RestResponse response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful || response.Content is null)
            {
                throw new Exception("GetAccessTokenRequestAsync Failed", response.ErrorException);
            }
            else
            {
                var responseJson = JsonSerializer.Deserialize<AccessTokenResponse>(response.Content);
                if (responseJson is not null)
                {
                    responseJson.ExpiresAt = DateTime.Now.AddSeconds(responseJson.expires_in);
                    return responseJson;
                }
                else
                {
                    throw new Exception("GetAccessTokenRequestAsync Failed responseJson is null");
                }
            }
        }
    }
}
