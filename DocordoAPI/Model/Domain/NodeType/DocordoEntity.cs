namespace DocordoAPI.Model.Domain.NodeType
{
    public class DocordoEntity<T> : DocordoBaseNode<T>
    {
        public static DocordoEntity<T> New(string ebikkoSessionId, string nodeId, string containerId, string title, string externalId, T data)
        {
            DocordoEntity<T> docordoEntity = new DocordoEntity<T>();
            docordoEntity.SetDefaultFields("NODE_SAVE", "baa8314cf5fc49f88c129e42d50a562e", ebikkoSessionId, nodeId, containerId, title, externalId, data);
            return docordoEntity;
        }
    }
}
