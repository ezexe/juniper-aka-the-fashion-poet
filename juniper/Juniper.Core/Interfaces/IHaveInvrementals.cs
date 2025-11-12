namespace Juniper.Core.Interfaces
{
    public interface IHaveIncrementals
    {
        public DateTimeOffset Date { get; }
        public string PoId { get; }
        public string ASNId { get; }
        public string StringId { get; }

        public int Id { get; set; }
        public int Bol { get; set; }
        public bool IsDupe { get; set; }
        public DateTime FileCreationTime { get; set; }

        public DocumentStatus Status { get; set; }
        public TradingPartnerModel TradingPartner { get; set; }

        public string CheckId(DocumentType dt);
    }
}
