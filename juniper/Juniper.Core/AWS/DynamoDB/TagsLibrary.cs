namespace Juniper.Core.AWS.DynamoDB;

public class TagsLibrary : IAsyncInitialization
{
    public static TagsLibrary Current { get; private set; }  

    public Task Initialization { get; private set; }

    public ObservableCollection<TagsTable> TagsList { get; set; }  = new();
    private List<TagsTable> prevTagsList;

    public List<DocumentTagsTable> DocumentTagsList { get; set; }

    public TagsLibrary()
    {
        Current = this;
        Initialization = Init();
    }
    private async Task Init()
    {
        var tagsList = await DynamoService.Current.GetAllItemsAsync<TagsTable>() ?? new();
        prevTagsList = tagsList;
        TagsList.AddAll(tagsList);

        DocumentTagsList = await DynamoService.Current.GetAllItemsAsync<DocumentTagsTable>() ?? new();
    }
    
    public async Task CreateTag(string tagName, string tagValue)
    {
        await Initialization;

        if (await DynamoService.Current.Store(new TagsTable
        {
            TagName = tagName,
            TagValue = tagValue,
        }) is { } tag)
            TagsList.Add(tag);
    }
    public async void AddTags(params TagsTable[] tagsTables)
    {
        if (tagsTables == null || tagsTables.Length == 0)
            await CreateTag(TagsList.Count(c => c.TagName == "name") + " name", "value");
        else
            foreach (var tagsTable in tagsTables)
                if (!TagsList.Any(t => t.TagName == tagsTable.TagName))
                    await CreateTag(tagsTable.TagName, tagsTable.TagValue);
    }
   
    public async Task CreateDocumentTag(string docId, string tagName)
    {
        await Initialization;

        if (await DynamoService.Current.Store(new DocumentTagsTable
        {
            DocumentID = docId,
            TagName = tagName,
        }) is { } dt)
            DocumentTagsList.Add(dt);
    }
    public async Task SetDocumentTags(IList<object> tags, IList<object> documnts)
    {
        await Initialization;

        foreach (IHaveIncrementals doc in documnts)
            foreach (TagsTable tag in tags)
                if (!DocumentTagsList.Any(t => t.DocumentID == doc.StringId && t.TagName == tag.TagName))
                    await CreateDocumentTag(doc.StringId, tag.TagName);
    }

    public async Task Save()
    {
        await Initialization;

        for (int i = prevTagsList.Count - 1; i >= 0; i--)
            if (prevTagsList[i] is TagsTable tag &&
                !TagsList.Contains(tag) &&
                await DynamoService.Current.Delete(tag))
                prevTagsList.Remove(tag);



        foreach (var tag in TagsList)
            if (!prevTagsList.Contains(tag) &&
                !prevTagsList.Any(t => t.TagName == tag.TagName && t.TagValue == tag.TagValue) &&
                await DynamoService.Current.Store(tag) is { } t)
                prevTagsList.Add(t);

    }
}

