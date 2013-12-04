namespace DocordoAPI.Model.Bean.Create
{
    public class DocordoCreateAdHocDocumentAndUploadBean
    {
        public DocordoCreateRecordBean CreateAdHocDocumentBean { get; set; }
        public DocordoUploadContentBean UploadContentBean { get; set; }

        public static DocordoCreateAdHocDocumentAndUploadBean New(DocordoCreateRecordBean docordoCreateAdHocDocumentBean, DocordoUploadContentBean docordoUploadContentBean)
        {
            DocordoCreateAdHocDocumentAndUploadBean createAdHocDocumentAndUploadBean = new DocordoCreateAdHocDocumentAndUploadBean()
            {
                CreateAdHocDocumentBean = docordoCreateAdHocDocumentBean,
                UploadContentBean = docordoUploadContentBean
            };

            return createAdHocDocumentAndUploadBean;

        }
    }
}
