// -----------------------------------------------------------------------
// <copyright file="DocordoLogoutResponseBean.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DocordoAPI.Model.Domain
{
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DocordoLogoutResponse
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "data")]
        public DocordoData Data { get; set; }

        [JsonProperty(PropertyName = "ebikko_session_id")]
        public object EbikkoSessionId { get; set; }

        [JsonProperty(PropertyName = "principal_id")]
        public object PrincipalId { get; set; }
    }
}
