namespace Juniper.Core.AWS.Datasets;
public class DatasetItem
{
    public Elementname ElementName { get; set; }
    public Datacontent DataContent { get; set; }
    public Segmentpluselement SegmentPlusElement { get; set; }
}

public class Elementname
{
    public string S { get; set; }
}

public class Datacontent
{
    public L[] L { get; set; }
}

public class L
{
    public string S { get; set; }
}

public class Segmentpluselement
{
    public L1[] L { get; set; }
}

public class L1
{
    public string S { get; set; }
}
