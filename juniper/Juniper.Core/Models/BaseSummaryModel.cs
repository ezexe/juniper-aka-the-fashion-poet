namespace Juniper.Core.Models
{
    public class BaseSummaryModel : ObservableObject
    {
        private double totalAmount;
        public double TotalAmount
        {
            get => totalAmount;
            set => SetProperty(ref totalAmount, value);
        }

        private double totalSalesAmount;
        public double TotalSalesAmount
        {
            get => totalSalesAmount;
            set => SetProperty(ref totalSalesAmount, value);
        }

        private double totalTermsDiscountAmount = 0.0;
        public double TotalTermsDiscountAmount
        {
            get => totalTermsDiscountAmount;
            set => SetProperty(ref totalTermsDiscountAmount, value);
        }

        private double invoiceAmtDueByTermsDate = 0.0;
        public double InvoiceAmtDueByTermsDate
        {
            get => invoiceAmtDueByTermsDate;
            set => SetProperty(ref invoiceAmtDueByTermsDate, value);
        }


        private long totalLineItemNumber;
        public long TotalLineItemNumber
        {
            get => totalLineItemNumber;
            set => SetProperty(ref totalLineItemNumber, value);
        }

    }
}