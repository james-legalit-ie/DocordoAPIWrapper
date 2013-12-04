namespace DocordoAPI.Model.Domain.NodeType
{
    public class DocordoMatter<T> : DocordoBaseNode<T>
    {
        public static DocordoMatter<T> New(string ebikkoSessionId, string nodeId, string containerId, string title, string externalId, T data)
        {
            DocordoMatter<T> docordoMatter = new DocordoMatter<T>();
            docordoMatter.SetDefaultFields("NODE_SAVE", "d180f070bc924c179006776895537489", ebikkoSessionId, nodeId, containerId, title, externalId, data);
            return docordoMatter;
        }
    }
}
