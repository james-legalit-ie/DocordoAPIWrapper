namespace DocordoAPI.Model.Bean.Create
{
    public class DocordoCreateRecordBean
    {
        public string NodeId { get; set; }
        public string ExternalId { get; set; }
        public string RecordDescription { get; set; }
        public string ContainerRecordNumber { get; set; }

        public static DocordoCreateRecordBean New(string nodeId, string containerRecordNumber, string recordDescription, string externalId)
        {
            return new DocordoCreateRecordBean()
            {
                NodeId = nodeId,
                ExternalId = externalId,
                RecordDescription = recordDescription,
                ContainerRecordNumber = containerRecordNumber
            };
        }
    }
}
