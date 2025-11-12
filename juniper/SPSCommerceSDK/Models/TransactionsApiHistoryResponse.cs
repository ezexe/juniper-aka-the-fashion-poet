namespace SPSCommerceSDK.Models.History;

public class TransactionsHistory
{
    public List<TransactionsApiHistoryResponse> ApiResponses { get; set; } = new();
    public List<Orders.Order> OrderResponses { get; set; } = new();
    public List<Shipments.Shipment> ShipmentResponses { get; set; } = new();
    public List<Invoices.Invoice> InvoiceResponses { get; set; } = new();
}
public class TransactionsApiHistoryResponse
{
    public Rootobject? Root { get; set; }
}


public class Rootobject
{
    public Paging paging { get; set; }
    public HistoryResponseResult[] results { get; set; }
}

public class Paging
{
    public int offset { get; set; }
    public int limit { get; set; }
    public int total_count { get; set; }
    public Next next { get; set; }
    public Previous previous { get; set; }
}

public class Next
{
    public string url { get; set; }
}

public class Previous
{
    public string url { get; set; }
}

public class HistoryResponseResult
{
    public string id { get; set; }
    public string path { get; set; }
    public string direction { get; set; }
    public Status_Log[] status_log { get; set; }
}

public class Status_Log
{
    public string status { get; set; }
    public DateTime timestamp { get; set; }
    public string message { get; set; }
}

