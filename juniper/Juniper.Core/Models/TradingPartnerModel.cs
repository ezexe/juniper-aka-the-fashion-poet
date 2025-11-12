using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juniper.Core.Models
{
    public class TradingPartnerModel : 
		IEnumerable<PurchaseOrderViewModel>,
		IEnumerable<ASNViewModel>,
		IEnumerable<InvoiceViewModel>
	{
		public const string TPDN_Sacks = "Saks Stores";
		public const string TPDN_Sackscom = "Saks.com";
		public const string TPDN_BlommiesOutlet = "Bloomingdales Outlet";
		public const string TPDN_Blommies = "Bloomingdales";
		public const string TPDN_Nordstrom = "Nordstrom";
		public const string TPDN_NordstromCAN = "Nordstrom Canada";
		public const string TPDN_Nordstromcom = "Nordstrom.com";

		public const string TPID_Sacks = "591ALLJUNIPER08";
		public const string TPID_Nord = "545ALLJUNIPER08";
		public const string TPID_NordCAN = "ELYALLJUNIPER08";
		public const string TPID_Bloom = "560ALLJUNIPER08";
		public const string TPID_BloomOut = "AUOALLJUNIPER08";

		public const string Default_SaksInvoiceTradingPartnerId = "591810JUNIPER08";
		public const string Default_SaksASNTradingPartnerId = "591855JUNIPER08";
		public const string Default_SaksASNTradingPartnerId2 = "591856JUNIPER08";
		public const string Default_SaksMaxPackDC = "9999";

		public static readonly string[] NordstromRackcom = new string[] { "0873", "0881", "873", "881", "879", "0879", "562", "0562" };
		#region fields
		private ObservableCollection<PurchaseOrderViewModel> purchaseOrders = new ObservableCollection<PurchaseOrderViewModel>();
		private ObservableCollection<ASNViewModel> asns = new ObservableCollection<ASNViewModel>();
		private ObservableCollection<InvoiceViewModel> invoices = new ObservableCollection<InvoiceViewModel>();
		#endregion fields

		#region properties
		public ObservableCollection<PurchaseOrderViewModel> PurchaseOrders { get { return this.purchaseOrders; } }
		public ObservableCollection<ASNViewModel> ASNShipments { get { return this.asns; } }
		public ObservableCollection<InvoiceViewModel> InvoiceViewModels { get { return this.invoices; } }
		public string Name { get; set; }
		public string TradingPartnerId { get; set; }
        public string DefaultCarrier { get; set; }
        public TradingPartnersTable DBTable { get; set; }
        public List<BaseAddressModel> Addresses { get; set; }
		#endregion properties

		#region constructors
		public TradingPartnerModel(string name, string tradingPartnerId)
        {
            this.Name = name;
            TradingPartnerId = tradingPartnerId;
            //authorDictionary.Add(this.Name, this);
        }
		#endregion constructors

		#region methods
		public BaseAddressModel? GetAddressModelFor(string llocation, bool dc)
		{
			BaseAddressModel? bam = null;
			if (dc)
				bam = Addresses.SingleOrDefault(a => a.SelectedAddressTypeCode == "ST" && a.AddressLocationNumber == llocation);
			else
			{
				try
				{
					bam = Addresses.SingleOrDefault(a => a.AddressLocationNumber == llocation);
				}
				catch
				{
					bam = Addresses.SingleOrDefault(a => a.SelectedAddressTypeCode == "BY" && a.AddressLocationNumber == llocation);
				}
			}

			if (dc && bam?.DC != null && (TradingPartnerId == TPID_Bloom || TradingPartnerId == TPID_BloomOut))
			{
				return GetDCAddressModelFor(bam.DC);
			}
			else
			{
				if (bam != null && bam.DC == null)
					bam.DC = bam.DCAddressLocationNumber;
			}


			return bam;
		}

		public BaseAddressModel? GetDCAddressModelFor(string dc)
		{
			return Addresses.SingleOrDefault(a => a.SelectedAddressTypeCode == "ST" && 
			a.AddressLocationNumber == dc &&
			a.DC == dc &&
			a.DCAddressLocationNumber == dc);
		}

		internal string? GetAddressModelByName(string location)
		{
			return Addresses.FirstOrDefault(a => a.SAddressTypeCode == "ST" && a.DC == location)?.AddressLocationNumber;
		}
		public void Sort()
		{
			InvoiceViewModels.OrderByIncrementals();
			ASNShipments.OrderByIncrementals();
			PurchaseOrders.OrderByIncrementals();
		}

		public void AddItem<T>(T item)
		{
			if (item is InvoiceViewModel ivm)
				AddInvoice(ivm);
			else if (item is ASNViewModel asn)
				AddASN(asn);
			else if (item is PurchaseOrderViewModel po)
				AddPurchaseOrder(po);
		}

		public void RemoveItem<T>(T item)
		{
			if (item is InvoiceViewModel ivm)
				RemoveInvoice(ivm);
			else if (item is ASNViewModel asn)
				RemoveASN(asn);
			else if (item is PurchaseOrderViewModel po)
				RemovePurchaseOrder(po);
		}

		//internal TradingPartnerModel? GetPartnerByName(string name)
		//{
		//          authorDictionary.TryGetValue(name, out TradingPartnerModel? author);
		//          return author;
		//}

		public void AddPurchaseOrder(PurchaseOrderViewModel povm)
		{
			if (!this.PurchaseOrders.Contains(povm))
				this.PurchaseOrders.Add(povm);
		}
		public void AddASN(ASNViewModel a)
		{
			if (!this.ASNShipments.Contains(a))
				this.ASNShipments.Add(a);
		}
		public void AddInvoice(InvoiceViewModel i)
		{
			if (!this.InvoiceViewModels.Contains(i))
				this.InvoiceViewModels.Add(i);
		}
		public void RemoveASN(ASNViewModel a)
		{
			if (this.ASNShipments.Contains(a))
				this.ASNShipments.Remove(a);
		}
		public void RemoveInvoice(InvoiceViewModel i)
		{
			if (this.InvoiceViewModels.Contains(i))
				this.InvoiceViewModels.Remove(i);
		}
		public void RemovePurchaseOrder(PurchaseOrderViewModel po)
		{
			if (this.PurchaseOrders.Contains(po))
				this.PurchaseOrders.Remove(po);
		}

		#endregion methods

		#region IEnumerable<T>
		public IEnumerator<PurchaseOrderViewModel> GetEnumerator()
		{
			return this.PurchaseOrders.GetEnumerator();
		}

        IEnumerator<ASNViewModel> IEnumerable<ASNViewModel>.GetEnumerator()
		{
			return this.ASNShipments.GetEnumerator();
		}

        IEnumerator<InvoiceViewModel> IEnumerable<InvoiceViewModel>.GetEnumerator()
		{
			return this.InvoiceViewModels.GetEnumerator();
		}
		#endregion IEnumerable<BookSku>

		#region IEnumerable
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.PurchaseOrders.GetEnumerator();
		}


        #endregion IEnumerable
    }
}
