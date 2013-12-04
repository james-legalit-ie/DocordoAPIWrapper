// -----------------------------------------------------------------------
// <copyright file="DocordoPrincipalDetailsBean.cs" company="">
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
    public class DocordoPrincipalDetails
    {
        [JsonProperty(PropertyName = "fullname")]
        public string Fullname { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "can_change_principal_security_level")]
        public bool CanChangePrincipalSecurityLevel { get; set; }

        [JsonProperty(PropertyName = "currentdataset")]
        public string CurrentDataSet { get; set; }

        [JsonProperty(PropertyName = "members")]
        public List<DocordoMembers> Members { get; set; }
    }
}
