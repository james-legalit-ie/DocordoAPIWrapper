namespace DocordoAPI.Model.Bean
{
    using Newtonsoft.Json;

    public class DocordoCheckInNodeBean
    {
        [JsonProperty(PropertyName = "ebikko_session_id")]
        public string EbikkoSessionId { get; set; }

        [JsonProperty(PropertyName = "node_id")]
        public string NodeId { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "content_id")]
        public string ContentId { get; set; }

        [JsonProperty(PropertyName = "field_name")]
        public string FieldName { get; set; }

        [JsonProperty(PropertyName = "is_new_version")]
        public bool IsNewVersion { get; set; }

        [JsonProperty(PropertyName = "leave_it_check_out")]
        public bool LeaveItCheckOut { get; set; }

        public static DocordoCheckInNodeBean New(string sessionId, string nodeId, string contentId, string fieldName, bool isNewVersion = false, bool LeaveItCheckedOut = false)
        {
            DocordoCheckInNodeBean docordoCheckInNodeBean = new DocordoCheckInNodeBean()
            {
                EbikkoSessionId = sessionId,
                NodeId = nodeId,
                ContentId = contentId,
                FieldName = fieldName,
                IsNewVersion = isNewVersion,
                LeaveItCheckOut = LeaveItCheckedOut,
                Method = "NODE_CHECK_IN"
            };

            return docordoCheckInNodeBean;
        }
    }
}
