namespace Juniper.Core.Util;

[AttributeUsage(AttributeTargets.Property)]
public class MyDynamoDBAttribute : Attribute
{
    // Private fields.
    private string name;
    // This constructor defines required parameters: name.
    public MyDynamoDBAttribute(string settingId)
    {
        this.name = settingId;
    }

    // Define properties.
    // This is a read-only attribute.
    public virtual string SettingId
    {
        get { return name; }
    }
}
[AttributeUsage(AttributeTargets.Property)]
public class SettingAttribute : Attribute
{
    // Private fields.
    private string name;
    private SettingStorageKeys storageKey;

    // This constructor defines required parameters: name.
    public SettingAttribute(SettingStorageKeys key)
    {
        this.storageKey = key;
        this.name = key.ToString();
    }

    // Define properties.
    // This is a read-only attribute.
    public virtual string Name
    {
        get { return name; }
    }
    public virtual SettingStorageKeys StorageKey
    {
        get { return storageKey; }
    }
}
[AttributeUsage(AttributeTargets.Property)]
public class MinimumCountAttribute : Attribute
{
    // Private fields.
    private int min;

    // This constructor defines required parameters: name.
    public MinimumCountAttribute(int m)
    {
       min = m;
    }

    // Define properties.
    // This is a read-only attribute.
    public virtual int Min
    {
        get { return min; }
    }
}

public class NotNullOrEmptyCollectionAttribute : ValidationAttribute
{
    // Private fields.
    private int min;
    public NotNullOrEmptyCollectionAttribute() 
    {
        min = 0;
    }

    public NotNullOrEmptyCollectionAttribute(int m)
    {
        min = m;
    }

    public override bool IsValid(object? value)
    {
        if (value is ICollection collection)
            return collection.Count > min;

        return value is IEnumerable enumerable && enumerable.GetEnumerator().MoveNext();
    }

    // Define properties.
    // This is a read-only attribute.
    public virtual int Min
    {
        get { return min; }
    }
}
