using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juniper.Core.Models
{
    public class PurchaseOrderCompletionStatus : ObservableObject
    {
        private POOrderLineModel polm;
        public POOrderLineModel Polm
        {
            get => polm;
            set => SetProperty(ref polm, value);
        }

        public ObservableCollection<PurchaseOrderCompletionStatusLocations> LocationsStatus { get; } = new ObservableCollection<PurchaseOrderCompletionStatusLocations>();
        public double LocationsQty => LocationsStatus.Sum(l => l.Location.Qty ?? 0);
        public int ASNsQty => LocationsStatus.GroupBy(l => l.ASNNumber).Count();
        public string ASNsQtyString => ASNsQty == 1 ? $"asn {LocationsStatus[0].ASNNumber}" : $"asn's {ASNsQty}";
    }

    public class PurchaseOrderCompletionStatusLocations : ObservableObject
    {
        public LocationQuantity Location { get; set; }

        public string ASNNumber { get; set; }

    }
}
