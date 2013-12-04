namespace DocordoAPI.Model.Domain
{
    using Newtonsoft.Json;

    public class DocordoCheckInNodeResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "data")]
        public DocordoData Data { get; set; }

    }
}
