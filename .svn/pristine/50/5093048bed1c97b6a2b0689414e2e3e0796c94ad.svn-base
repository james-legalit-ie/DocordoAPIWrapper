namespace DocordoAPI.Model.Domain.NodeType
{
    public class DocordoFolder<T> : DocordoBaseNode<T>
    {
        public static DocordoFolder<T> New(string ebikkoSessionId, string nodeId, string containerId, string title, string externalId, T data)
        {
            DocordoFolder<T> docordoFolder = new DocordoFolder<T>();
            docordoFolder.SetDefaultFields("NODE_SAVE", "a21d6bcf0a844ac68b27b87f9a6c9625", ebikkoSessionId, nodeId, containerId, title, externalId, data);
            return docordoFolder;
        }
    }
}
