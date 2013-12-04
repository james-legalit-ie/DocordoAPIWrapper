namespace DocordoAPI.Model.Domain
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DocordoAttributesResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "data")]
        public DocordoData Data { get; set; }

        [JsonProperty(PropertyName = "results")]
        public List<DocordoAttribute> Results { get; set; }
    }
}
