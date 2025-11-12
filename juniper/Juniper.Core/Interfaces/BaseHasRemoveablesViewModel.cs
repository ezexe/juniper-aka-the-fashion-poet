namespace Juniper.Core.Interfaces
{
    public abstract class BaseHasRemoveablesViewModel : BaseViewModel
    {
        [JsonIgnore]
        public ObservableCollection<ValidationErrorModel> ValidationErrors { get; } = new();

        private bool canAddRemoveables = true;
        [JsonIgnore]
        public bool CanAddRemoveables
        {
            get => canAddRemoveables;
            set => SetProperty(ref canAddRemoveables, value);
        }

        private bool forceEnabled = true;
        [JsonIgnore]
        public bool ForceEnabled
        {
            get => forceEnabled;
            set
            {
                SetProperty(ref forceEnabled, value);
                //RecursiveGetProps<BaseHasRemoveablesViewModel>(this);
            }
        }

        public BaseHasRemoveablesViewModel() : base()
        {

        }

        public void RemoveableRequested(Type type, object dataContext)
        {
            RecursiveRemoveableRequested(this, type, dataContext);
            GC.Collect();
        }

        private void RecursiveRemoveableRequested(object o, Type type, object dataContext)
        {
            var props = o.GetType().GetProperties();
            foreach (var p in props)
            {
                if (p.GetGetMethod() != null
                    &&
                    p.PropertyType == typeof(ObservableCollection<>).MakeGenericType(new[] { type }))
                {
                    if (p.GetValue(o) is IList a)
                    {
                        var att = Attribute.GetCustomAttribute(p, typeof(MinimumCountAttribute));
                        if (att is MinimumCountAttribute sa &&
                            sa.Min > 0 && sa.Min >= a.Count)
                            return;

                        a.Remove(dataContext);
                        return;
                    }

                    //return;
                }
                else if (!p.GetIndexParameters().Any() &&
                    p.PropertyType != typeof(List<Tuple<string, string>>) &&
                    p.PropertyType != typeof(ObservableCollection<POOrderLineModel>))
                {
                    if (p.GetValue(o) is IList a)
                    {
                        foreach (var lo in a)
                        {
                            RecursiveRemoveableRequested(lo, type, dataContext);
                        }
                    }
                    else if (p.Name != "TradingPartner"
                        && p.Name != "asnvm"
                        && p.Name != "povm"
                        && p.PropertyType.Namespace?.StartsWith("Juniper") == true
                        && p.GetValue(o) is object oo)
                    {
                        RecursiveRemoveableRequested(oo, type, dataContext);
                    }
                }
            }
        }


        public void AddValidationError(object of)
        {
            if (ABaseHasRequiredObject.GetValidationErrorsString(of) is ValidationErrorModel error)
                ValidationErrors.Add(error);
        }
        public void RecursiveGetProps<T>(object o)
        {
            PropertyInfo[] pi = o.GetType().GetProperties();
            foreach (var p in pi)
            {
                if (p.GetIndexParameters().Any() ||
                    p.PropertyType.Namespace?.StartsWith("SPSCommerceSDK") == true)
                    continue;

                if (p.GetValue(o, null) is T a)
                {
                    if (typeof(T) == typeof(BaseHasRemoveablesViewModel) &&
                        a is BaseHasRemoveablesViewModel b)
                        b.ForceEnabled = ForceEnabled;
                    else if (typeof(T) == typeof(ABaseHasRequiredObject) &&
                        a is ABaseHasRequiredObject ab)
                    {
                        AddValidationError(ab);
                        RecursiveGetProps<T>(ab);
                    }


                }
                else if (p.PropertyType != typeof(List<Tuple<string, string>>) &&
                    p.PropertyType != typeof(ObservableCollection<POOrderLineModel>) &&
                    p.PropertyType != typeof(ObservableCollection<InvoiceViewModel>) &&
                    p.GetValue(o, null) is IList aa)
                {
                    foreach (var lo in aa)
                    {
                        RecursiveGetProps<T>(lo);
                    }
                }
            }
        }
    }
}
