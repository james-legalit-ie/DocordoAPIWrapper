// -----------------------------------------------------------------------
// <copyright file="DocordoContentResponseBean.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DocordoAPI.Model.Domain
{
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DocordoContentResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "data")]
        public DocordoData Data { get; set; }
    }
}
