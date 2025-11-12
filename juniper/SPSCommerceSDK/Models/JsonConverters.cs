namespace SPSCommerceSDK.Models;

public class CustomDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? date = reader.GetString();
        if (date == null) { return default; }

        return DateTimeOffset.Parse(date);
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
    {
        //Don't implement this unless you're going to use the custom converter for serialization too
        throw new NotImplementedException();
    }
}
