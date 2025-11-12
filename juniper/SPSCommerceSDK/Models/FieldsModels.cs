namespace SPSCommerceSDK.Models;


public class FieldsBase
{
    public Field[] fields { get; set; }
    public Meta meta { get; set; }
}

public class Meta
{
    public string version { get; set; }
    public string xsd { get; set; }
}

public class Field
{
    public string description { get; set; }
    public Enum[] enums { get; set; }
    public object[] examples { get; set; }
    public string field_type { get; set; }
    public string name { get; set; }
}

public class Enum
{
    public string description { get; set; }
    public string[] examples { get; set; }
    public string long_description { get; set; }
    public string value { get; set; }
}
