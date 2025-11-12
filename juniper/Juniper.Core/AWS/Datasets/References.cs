namespace Juniper.Core.AWS.Datasets;
public class References
{
    public SCACReferenceRoot SCACRef { get; set; }
    public SpeedReferenceRoot SpeedRef { get; set; }
}

public class SpeedReferenceRoot
{
    public SpeedReference[] SpeedReferences { get; set; }
}
public class SpeedReference
{
    public string Code { get; set; }
    public string ShipSpeed { get; set; }
}


public class SCACReferenceRoot
{
    public Scacreference[] SCACReferences { get; set; }
}

public class Scacreference
{
    public string CarrierName { get; set; }
    public string SCAC { get; set; }
}
