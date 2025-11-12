namespace Juniper.Core.Util
{
    using Word = Microsoft.Office.Interop.Word;
    public class WordInteropUtil
    {
        public static WordInteropUtil Current { get; private set; }

        public WordInteropUtil()
        {
            Current = this;
        }
        public async Task CreateBOL(List<BillOfLadingsDocumentFileModel> bolDocInfoList)
        {
            await Task.Run( () =>
            {
                foreach (var bolDocInfo in bolDocInfoList)
                {
                    Word.Application? word = null;
                    Word.Document? document = null;
                    try
                    {
                        word = new Word.Application();       //create a instance for the Excel object  
                        word.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone;
                        word.Visible = true;

                        document = word.Documents.Open(bolDocInfo.Path, ReadOnly: false);
                        document.Activate();

                        foreach (var da in GetDocumentFileAttributes())
                        {
                            var find = da.Key;
                            var value = Convert.ToString(typeof(BillOfLadingsDocumentFileModel).GetProperty(da.Value)?.GetValue(bolDocInfo));

                            //options
                            object matchCase = false;
                            object matchWholeWord = true;
                            object matchWildCards = false;
                            object matchSoundsLike = false;
                            object matchAllWordForms = false;
                            object forward = true;
                            object format = false;
                            object matchKashida = false;
                            object matchDiacritics = false;
                            object matchAlefHamza = false;
                            object matchControl = false;
                            object read_only = false;
                            object visible = true;
                            object replace = 2;
                            object wrap = 1;
                            object findText = find;
                            object replaceWithText = value?.ToLower() ?? " ";
                            //execute find and replace
                            document.Content.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
                        }

                        object missObj = Missing.Value;
                        var startLine = 12;
                        foreach (var po in bolDocInfo.PurchaseOrders)
                        {
                            document.Tables[1].Cell(startLine, 1).Select();
                            //document.Range[document.Tables[1].Cell(startLine, 1).Range.Start;
                            //document.Tables[1].Rows[startLine].Select();
                            document.ActiveWindow.Selection.InsertRowsBelow(1);
                            document.Tables[1].Cell(startLine + 1, 4).Range.Text = "Y";
                            document.Tables[1].Cell(startLine + 1, 5).Range.Text = "N";
                            //document.Tables[1].Rows.Add(startLine);
                            //document.Tables[1].Cell(startLine, 1).Row.in

                            //var packlvltotal = 0;
                            //var weighttotal = 0.0;
                            //foreach (var asn in po.ASNCollection)
                            //{
                            //    if (!asn.IsChecked)
                            //        continue;

                            //    packlvltotal = asn.OrderLevel.Sum(p => p.PackLevelList.Count);
                            //    weighttotal = asn.OrderLevel.Sum(o => o.QuantityAndWeight.Weight);
                            //}

                            document.Tables[1].Cell(startLine, 1).Range.Text = po.PurchaseOrder.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber;
                            document.Tables[1].Cell(startLine, 2).Range.Text = $"{Convert.ToInt32(po.CarrierInformationQtyTtl)}";
                            document.Tables[1].Cell(startLine, 3).Range.Text = $"{po.CarrierInformationWeightTtl}";
                            document.Tables[1].Cell(startLine, 6).Range.Text = $"{po.AdditionalStyleInfo}";
                            startLine++;
                        }
                    }
                    catch (Exception e)
                    {
                        MainViewModel.Current.LoggerUtil.AddException(e, $"CreateBOL {bolDocInfo.Path}");
                    }
                    finally
                    {
                        //document?.UserControl = true;
                        //word?.Quit();
                    }
                }
            });
        }

        private IEnumerable<KeyValuePair<string,string>> GetDocumentFileAttributes()
        {
            var props = typeof(BillOfLadingsDocumentFileModel).GetProperties();
            foreach (var p in props)
            {
                var att = Attribute.GetCustomAttribute(p, typeof(BOLDocumentFileAttribute));
                if (att is BOLDocumentFileAttribute sa)
                {
                    yield return new KeyValuePair<string, string>(sa.Name,p.Name);
                }
            }
        }
    }
}
