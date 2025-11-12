namespace SPSCommerceSDK.Models;


public class FilterTransactiosnResponses
{
    public Result[] results { get; set; }
    public Paging paging { get; set; }
}

public class Paging
{
    public int limit { get; set; }
    public Next next { get; set; }
}

public class Next
{
    public string cursor { get; set; }
    public string url { get; set; }
}

public class Result
{
    public string path { get; set; }
    public string type { get; set; }
    public string url { get; set; }
}

