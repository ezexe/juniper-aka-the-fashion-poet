namespace Juniper.Core.Models
{
    public class InternalINVSettings : ObservableObject, IHaveInternalSettings
    {
        private bool isPaid = false;
        public bool IsPaid
        {
            get => isPaid;
            set => SetProperty(ref isPaid, value);
        }

    }
}
