namespace DocordoAPI.Model.Bean
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DocordoDeleteNodeBean
    {
        [JsonProperty(PropertyName="ebikko_session_id")]
        public string EbikkoSessionId {get;set;}

        [JsonProperty(PropertyName = "node_id")]
        public List<string> NodeId {get;set;}

        [JsonProperty(PropertyName = "method")]
        public string Method {get;set;}

        public static DocordoDeleteNodeBean New(string sessionId, params string[] nodeId)
        {
            DocordoDeleteNodeBean docordoDeleteNodeBean = new DocordoDeleteNodeBean()
            {
                EbikkoSessionId = sessionId,
                NodeId = new List<string>(nodeId),
                Method = "DELETE_WARNING"
            };

            return docordoDeleteNodeBean;
        }
    }
}
