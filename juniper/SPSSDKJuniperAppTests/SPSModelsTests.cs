using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPSCommerceSDK.Models;
using SPSCommerceSDK.Models.Invoices;
using SPSCommerceSDK.Models.Orders;
using SPSCommerceSDK.Models.Shipments;
using System.IO;
using System.Text.Json;

namespace SPSSDKJuniperAppTests
{
    [TestClass]
    public class SPSModelsTests
    {

        JsonSerializerOptions options = new JsonSerializerOptions();

        public SPSModelsTests()
        {
            options.Converters.Add(new CustomDateTimeOffsetConverter());
        }

        [TestMethod]
        public void TestReadOrdersMethod()
        {
            string json = File.ReadAllText(@"E:\Projects\juniper\App\Juniper\SPSCommerceSDK\Schema Files\Orders (undefined) json\Orders(850)\PO112853-1-v7.7-CrossDock.json");
            Order? jsonDeserialized = JsonSerializer.Deserialize<Order>(json);

            Assert.IsNotNull(jsonDeserialized);
        }

        [TestMethod]
        public void TestReadShipmentsMethod()
        {

            string json = File.ReadAllText(@"E:\Projects\juniper\App\Juniper\SPSCommerceSDK\Schema Files\Shipments (undefined) json\Shipments(856)\SH112853-1-v7.7-CrossDock.json");
            Shipment? jsonDeserialized = JsonSerializer.Deserialize<Shipment>(json, options);

            Assert.IsNotNull(jsonDeserialized);
        }

        [TestMethod]
        public void TestReadInvoicesFromSavedMethod()
        {

            string json = File.ReadAllText(@"C:\Users\eli\AppData\Local\Packages\ea9935f9-2df2-48c1-a08f-39235c2e9136_5eh0spzankk98\LocalState\SavedInvoices\0007879116\0007879116-1\0007879116-1-1.json");
            Invoice? jsonDeserialized = JsonSerializer.Deserialize<Invoice>(json, options);

            Assert.IsNotNull(jsonDeserialized);
        }
    }
}