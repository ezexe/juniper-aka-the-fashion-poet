namespace Juniper.Core.Models;

public class AddressModel : ObservableObject
{
    private string name = string.Empty;
    public string Name
    {
        get => name;
        set => SetProperty(ref name, value);
    }

    private string address = string.Empty;
    public string Address
    {
        get => address;
        set => SetProperty(ref address, value);
    }

    private string address2 = string.Empty;
    public string Address2
    {
        get => address2;
        set => SetProperty(ref address2, value);
    }

    private string city = string.Empty;
    public string City
    {
        get => city;
        set => SetProperty(ref city, value);
    }

    private string state = string.Empty;
    public string State
    {
        get => state;
        set => SetProperty(ref state, value);
    }

    private string zip = string.Empty;
    public string Zip
    {
        get => zip;
        set => SetProperty(ref zip, value);
    }

    private string country = "US";
    public string Country
    {
        get => country;
        set => SetProperty(ref country, value);
    }

    private string phoneNumber = string.Empty;
    public string PhoneNumber
    {
        get => phoneNumber;
        set => SetProperty(ref phoneNumber, value);
    }

}
