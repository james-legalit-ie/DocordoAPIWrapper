namespace DocordoAPI.Model.Bean
{
    public class DocordoUploadContentBean
    {
        public string FileName { get; set; }
        public byte[] FileByteArray { get; set; }

        public static DocordoUploadContentBean New(string fileName, byte[] fileByteArray)
        {
            DocordoUploadContentBean docordoUploadContentBean = new DocordoUploadContentBean()
            {
                FileName = fileName,
                FileByteArray = fileByteArray
            };
            return docordoUploadContentBean;
        }
    }
}
