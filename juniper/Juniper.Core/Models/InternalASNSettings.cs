namespace Juniper.Core.Models
{
    public class InternalASNSettings:ObservableObject, IHaveInternalSettings
    {
        private DateTimeOffset? internalActuallShip = null;
        public DateTimeOffset? InternalActuallShip
        {
            get => internalActuallShip;
            set => SetProperty(ref internalActuallShip, value);
        }

        private string masterBOLpath;
        public string MasterBOLPath
        {
            get => masterBOLpath;
            set => SetProperty(ref masterBOLpath, value);
        }

    }
}
