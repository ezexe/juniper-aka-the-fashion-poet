namespace Juniper.Core.Models
{
    // GroupInfoList class definition:
    public class GroupInfoList : List<object>
    {
        public GroupInfoList(IEnumerable<object> items) : base(items)
        {
        }
        public GroupInfoList(IEnumerable<object> items, string key1, string key2) : this(items, key1, key2, "")
        {
        }
        public GroupInfoList(IEnumerable<object> items, string key1, string key2, string key3) : this(items)
        {
            Key1 = key1;
            Key2 = key2;
            Key3 = key3;
            Key = key1 + " " + key2 + " " + key3;
        }

        public object Key { get; set; }
        public object Key1 { get; set; }
        public object Key2 { get; set; }
        public object Key3 { get; set; }
    }
}
