namespace DocordoAPI.Model.Domain.NodeType
{
    public class DocordoAdHocDocument<T> : DocordoBaseNode<T>
    {
        public static DocordoAdHocDocument<T> New(string ebikkoSessionId, string nodeId, string containerId, string title, string externalId, T data)
        {
            DocordoAdHocDocument<T> docordoAdHocDocument = new DocordoAdHocDocument<T>();
            docordoAdHocDocument.SetDefaultFields("NODE_SAVE", "b19c8c9173e146a6aeb673f20f002f56", ebikkoSessionId, nodeId, containerId, title, externalId, data);
            return docordoAdHocDocument;
        }
    }
}
