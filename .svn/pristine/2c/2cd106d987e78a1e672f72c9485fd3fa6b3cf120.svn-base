// -----------------------------------------------------------------------
// <copyright file="DocordoLoginBean.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DocordoAPI.Model.Domain
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DocordoLoginResponse
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }
        
        [JsonProperty(PropertyName = "data")]
        public DocordoData Data { get; set; }

        [JsonProperty(PropertyName = "ebikko_session_id")]
        public string EbikkoSessionId { get; set; }

        [JsonProperty(PropertyName = "principal_id")]
        public string PrincipalId { get; set; }

        [JsonProperty(PropertyName = "defLang")]
        public string DefLang { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "principal_details")]
        public List<DocordoPrincipalDetails> PrincipalDetails { get; set; }

        [JsonProperty(PropertyName = "principal_profile")]
        public List<DocordoPrincipalProfile> PrincipalProfile { get; set; }

        public string CookieJSESSIONID { get; set; }
    }
}
