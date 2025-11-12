namespace Juniper.Core.Util
{
    public static class ExtensionMethods
    {
        public static ParallelOptions GetNewParallelOptions()
        {
            ParallelOptions parallelOptions = new()
            {
                MaxDegreeOfParallelism = Environment.ProcessorCount,
                CancellationToken = CancellationToken.None,
            };

            return parallelOptions;
        }
        public static bool IsOneOf(this string item, params string[] options)
        {
            var isOne = false;
            foreach (var o in options)
            {
                if (o.Contains(item, StringComparison.InvariantCultureIgnoreCase))
                {
                    isOne = true;
                    break;
                }
            }

            return isOne;
        }
        public static bool HasAnyOf(this string item, params string[] options)
        {
            var isOne = false;
            foreach (var o in options)
            {
                if (item.Contains(o, StringComparison.InvariantCultureIgnoreCase))
                {
                    isOne = true;
                    break;
                }
            }

            return isOne;
        }

        public static string ToSpsDateString(this DateTimeOffset item)
        {
            return item.ToString("yyyy-MM-dd");
        }
        public static string ToFullDirectory(this string path)
        {
            if (!Directory.Exists(path))
                path = Path.Combine(MainViewModel.Current.FilesService.GetLocalStorageFolder(), path);
            return path;
        }


        public static string Serialize(this object item, JsonSerializerDefaults jsd = JsonSerializerDefaults.General, bool writeIndented = false)
        {
            return JsonSerializer.Serialize(item, new JsonSerializerOptions(jsd)
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                WriteIndented = writeIndented
            });
        }
        public static T? Deserialize<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }

        public static string AddInFrontTill(this string item, string add, int tillLength)
        {
            while (item.Length < tillLength)
                item = add + item;

            return item;
        }
        public static string RemoveInFrontTill(this string item,  int tillLength)
        {
            while (item.Length > tillLength)
                item = item.Remove(0,1);

            return item;
        }

        public static List<string> GetAllSublineItems(this ObservableCollection<POOrderLineModel> pol)
        {
            List<string> sli = new();
            foreach (var slitem in pol)
            {
                if (!sli.Contains(slitem.Item1))
                    sli.Add(slitem.Item1);
            }
            return sli;
        }

        public static IEnumerable<GroupInfoList> GroupPOCompletionStatusLis(this IEnumerable<PurchaseOrderCompletionStatus> polist)
        {
            return from i in polist
                   group i by i.Polm.LineItem.OrderLine?.VendorPartNumber into g
                   orderby g.Key
                   from g2 in
                   from i in g
                   group i by i.Polm.LineItem.OrderLine?.ProductColorDescription
                   select new GroupInfoList(g2, g.Key, g2.Key);
        }
        public static IEnumerable<GroupInfoList> GroupPOOrderStyleLines(this IEnumerable<POOrderLineModel> list)
        {
            return from i in list
                   group i by i.LineItem.OrderLine?.VendorPartNumber into g
                   orderby g.Key
                   from g2 in
                   from i in g
                   group i by i.LineItem.OrderLine?.ProductColorDescription
                   select new GroupInfoList(g2, g.Key, g2.Key);
        }
        public static IEnumerable<GroupInfoList> GroupLines(this IEnumerable<IHaveIncrementals> list)
        {
            return from i in list
                   group i by i.PoId into g
                   orderby g.Key

                   from g2 in from i in g
                              group i by i.ASNId
                   orderby g2.Key

                   from g3 in from i in g
                              group i by i.Date.DateTime.ToString("MM/dd/yyyy")
                   orderby g3.Key
                   select new GroupInfoList(g2, g.Key, g2.Key, g3.Key);
        }

        public static void AddAll<T>(this ObservableCollection<T> collection, IEnumerable<T> fromCollection)
        {
            collection.Clear();
            foreach (var item in fromCollection)
            {
                if (!collection.Contains(item))
                    collection.Add(item);
            }
        }
        public static TCollection AppendRemoved<TCollection, TItem>(this TCollection collection, TItem item) where TCollection : ICollection<TItem>
        {
            if (!collection.Contains(item))
                collection.Add(item);

            return collection;
        }
        public static void AddBackRemoved(this IEnumerable<IHaveIncrementals> collection)
        {
            foreach (var item in collection)
            {
                item.TradingPartner.AddItem(item);
            }
        }
        public static void RemovedRange(this IEnumerable<IHaveIncrementals> collection, IEnumerable<IHaveIncrementals> allcollection)
        {
            for (int i = allcollection.Count() - 1; i >= 0; i--)
            {
                var item = allcollection.ElementAt(i);
                // If is not in the filtered argument list, remove it from the ListView's source.
                if (!collection.Contains(item))
                {
                    item.TradingPartner.RemoveItem(item);
                }
            }
        }
        public static void AddUnique(this ObservableCollection<DateTimeOffset> dates, DateTimeOffset? newDate)
        {
            if (newDate is not null)
            {
                DateTimeOffset adt = newDate ?? throw new ArgumentNullException("AddUnique.DateTimeOffset");
                if (!dates.Any(i => i.Date.Date == adt.Date))
                {
                    for (int i = 0; i < dates.Count; i++)
                    {
                        if (dates[i].Date.Date >= adt.Date)
                        {
                            dates.Insert(i, new DateTimeOffset(adt.Date));
                            return;
                        }
                    }

                    dates.Add(new DateTimeOffset(adt.Date));
                }
            }
        }
        public static void RemoveUnique(this ObservableCollection<DateTimeOffset> dates, IEnumerable<IHaveIncrementals> collection, DateTimeOffset newDate)
        {
            if (!collection.Any(i => i.Date.Date == newDate.Date) &&
                dates.FirstOrDefault(i => i.Date == newDate.Date) is DateTimeOffset dto &&
                dates.Contains(dto))
                dates.Remove(dto);
        }

        public static IEnumerable<T> GetByDate<T>(this IEnumerable<T> collection, DateTimeOffset date) where T : IHaveIncrementals
        {
            return from s in collection
                   where s.Date.Date == date.Date
                   select s;
        }
    
        public static void SortAll(this ObservableCollection<TradingPartnerModel> array)
        {
            if (array.Count == 0)
                return;

            foreach (var item in array)
                item.Sort();
        }
        public static TradingPartnerModel GetByDisplaynameAndID(this ObservableCollection<TradingPartnerModel> array,string dn,string? id)
        {
            foreach (var item in array)
            {
                if(item.Name == dn)// && item.TradingPartnerId == id)
                    return item;
            }
            var tp = new TradingPartnerModel(dn,id??"<unknown>");
            array.Add(tp);
            return tp;
        }
        public static void OrderByIncrementals<T>(this ObservableCollection<T> array) where T : IHaveIncrementals
        {
            if (array.Count() == 0)
                return;

            var query = array.OrderBy(i => i.Id).ToArray();

            //array[0] is PurchaseOrderViewModel ? array.OrderBy(i => i.Id).ToArray() :
            //array[0] is ASNViewModel ? array.OrderBy(i => i.PoId).ThenBy(ii => ii.Id).ToArray() :
            //array[0] is InvoiceViewModel ? array.OrderBy(i => i.PoId).ThenBy(ii => ii.ASNId).ThenBy(iii => iii.Id).ToArray().ToArray() :
            //array.OrderBy(i => i.Id).ToArray();

            //(from iv in array.OrderBy(i => i.PoId).ThenBy(ii=>ii.ASNId).ThenBy(iii=>iii.Id)
            //             orderby iv.Id
            //             select iv).ToList();

            array.Clear();
            foreach (var item in query)
                array.Add(item);
        }
       
        public static List<IHaveIncrementals> SearchForByIncrementals(this IEnumerable<IHaveIncrementals> local, string query, DocumentType type)
        {
            var suggestions = new List<IHaveIncrementals>();

            var querySplit = query.Split(" ");
            var matchingItems = local.Where(
                item =>
                {
                    bool flag = item.CheckId(type).HasAnyOf(querySplit);
                    return flag;
                });

            foreach (var item in matchingItems)
            {
                suggestions.Add(item);
            }


            return suggestions.OrderByDescending(i => i.CheckId(type).StartsWith(query, StringComparison.CurrentCultureIgnoreCase)).ThenBy(i => i.Id).ToList();
        }

        public static int? GetToupleByItem(this List<Tuple<string, string>> list, string item1)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Item1 == item1)
                    return i;
            }

            return null;
        }
        public static bool IsNullEmptyOrWhiteSpace(this string item)
        {
            return string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item);
        }
        public static List<Tuple<string, string>> GetFieldsBy(this FieldsBase fields, string name)
        {
            var returned = new List<Tuple<string, string>>();

            foreach (var field in fields.fields)
            {
                if (field.name == name)
                {
                    foreach (var enumField in field.enums)
                    {
                        returned.Add(new Tuple<string, string>(enumField.value, enumField.description));
                    }
                }
            }

            return returned;
        }
    }
}