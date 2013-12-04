namespace DocordoAPI.Model.Domain
{
    using Newtonsoft.Json;

    public class DocordoGroup
    {
        [JsonProperty(PropertyName = "group_name")]
        public string GroupName { get; set; }
    }
}
