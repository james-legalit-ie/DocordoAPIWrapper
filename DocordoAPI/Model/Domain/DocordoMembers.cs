// -----------------------------------------------------------------------
// <copyright file="DocordoMembersBean.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------


namespace DocordoAPI.Model.Domain
{
    using Newtonsoft.Json;
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DocordoMembers
    {
        [JsonProperty(PropertyName = "groupname")]
        public string GroupName { get; set; }
    }
}
