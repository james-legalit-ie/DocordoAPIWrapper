
namespace DocordoAPI.Model.Utility
{
    using System;
    using System.Collections.Specialized;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Text;

    public class HttpUtility
    {
        public static byte[] UploadFile(string cookieJSESSIONID, string address, string fileName, byte[] file, NameValueCollection values)
        {
            WebRequest request = WebRequest.Create(address);
            request.Headers.Add("Cookie: " + cookieJSESSIONID);
            request.Method = "POST";

            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x", NumberFormatInfo.InvariantInfo);
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            boundary = "--" + boundary;

            using (Stream requestStream = request.GetRequestStream())
            {
                // Write the values
                foreach (string name in values.Keys)
                {
                    var valueBuffer = Encoding.ASCII.GetBytes(boundary + Environment.NewLine);
                    requestStream.Write(valueBuffer, 0, valueBuffer.Length);
                    valueBuffer = Encoding.ASCII.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\"{1}{1}", name, Environment.NewLine));
                    requestStream.Write(valueBuffer, 0, valueBuffer.Length);
                    valueBuffer = Encoding.UTF8.GetBytes(values[name] + Environment.NewLine);
                    requestStream.Write(valueBuffer, 0, valueBuffer.Length);
                }

                // Write the file               
                byte[] fileBufffer = Encoding.ASCII.GetBytes(boundary + Environment.NewLine);
                requestStream.Write(fileBufffer, 0, fileBufffer.Length);
                fileBufffer = Encoding.UTF8.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"{2}", "file", fileName, Environment.NewLine));
                requestStream.Write(fileBufffer, 0, fileBufffer.Length);
                fileBufffer = Encoding.ASCII.GetBytes(string.Format("Content-Type: {0}{1}{1}", "application/octet-stream", Environment.NewLine));
                requestStream.Write(fileBufffer, 0, fileBufffer.Length);
                requestStream.Write(file, 0, file.Length);
                fileBufffer = Encoding.ASCII.GetBytes(Environment.NewLine);
                requestStream.Write(fileBufffer, 0, fileBufffer.Length);


                var boundaryBuffer = Encoding.ASCII.GetBytes(boundary + "--");
                requestStream.Write(boundaryBuffer, 0, boundaryBuffer.Length);
            }

            using (var response = request.GetResponse())
            using (var responseStream = response.GetResponseStream())
            using (var stream = new MemoryStream())
            {
                responseStream.CopyTo(stream);
                return stream.ToArray();
            }
        }
    }
}
