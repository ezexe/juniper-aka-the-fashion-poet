namespace Juniper.Core.AWS.Datasets;
public class TestData
{
    public DatasetItem[] items { get; set; }

    public TestData()
    {    }

    public static async Task<TestData> GetTestData()
    {
        var ft = await File.ReadAllTextAsync(@"C:\Users\elimd\OneDrive - The Fashion Poet LLC\Documents\New Project\Development+Packet+-+RSX+7.7+EDI+X12\TestData.json");
        if (ft?.Deserialize<TestData>() is { } td)
            return td;
        else
        {
            var s3data = await S3BucketService.Current.ReadObjectDataAsync("documents/dataz/", "TestData.json");
            if (s3data?.Deserialize<TestData>() is { } s3d)
                return s3d;
        }

        return new TestData();
    }

}


