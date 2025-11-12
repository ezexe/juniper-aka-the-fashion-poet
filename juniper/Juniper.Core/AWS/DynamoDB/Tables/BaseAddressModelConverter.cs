namespace Juniper.Core.AWS.DynamoDB.Tables
{
    public class BaseAddressModelConverter : IPropertyConverter
    {
        public DynamoDBEntry ToEntry(object value)
        {
            List<Primitive> data = new();
            List<BaseAddressModel>? adresses = value as List<BaseAddressModel>;
            if (adresses == null)
            {
                throw new ArgumentOutOfRangeException("adresses == null");
            }
            foreach (var address in adresses)
            {
                data.Add(new Primitive
                {
                    Type = DynamoDBEntryType.String,
                    Value = string.Join(',',
                    address.SAddressTypeCode,
                    address.SLocationCodeQualifier,
                    address.AddressLocationNumber,
                    address.DCAddressLocationNumber,
                    address.DC,
                    address.AddressModel?.Name,
                    address.AddressModel?.Address,
                    address.AddressModel?.Address2,
                    address.AddressModel?.City,
                    address.AddressModel?.State,
                    address.AddressModel?.Zip,
                    address.AddressModel?.Country,
                    address.AddressModel?.PhoneNumber)
                });
            }

            DynamoDBEntry entry = new PrimitiveList
            {
               Entries = data
            };
            return entry;
        }

        public object FromEntry(DynamoDBEntry entry)
        {
            List<BaseAddressModel> addresses = new();
            PrimitiveList? primitives = entry as PrimitiveList;
            if (primitives == null || primitives.Entries == null)
            {
                throw new ArgumentOutOfRangeException("primitives == null || primitives.Entries == null");
            }

            foreach (var primitive in primitives.Entries)
            {
                var data = (primitive.Value as string)?.Split(',');
                if (data != null)
                {
                    addresses.Add(new BaseAddressModel
                    {
                        SAddressTypeCode = data[0],
                        SLocationCodeQualifier = data[1],
                        AddressLocationNumber = data[2],
                        DCAddressLocationNumber = data[3],
                        DC = data[4],
                        AddressModel = new AddressModel()
                        {
                            Name = data[5],
                            Address = data[6],
                            Address2 = data[7],
                            City = data[8],
                            State = data[9],
                            Zip = data[10],
                            Country = data[11],
                            PhoneNumber = data[12]
                        }
                    });
                }
            }

            return addresses;
        }
    }
}
