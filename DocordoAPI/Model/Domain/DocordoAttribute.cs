namespace DocordoAPI.Model.Domain
{
    using Newtonsoft.Json;

    public class DocordoAttribute
    {
        [JsonProperty(PropertyName = "decimal")]
        public int Decimal { get; set; }

        [JsonProperty(PropertyName = "is_multi_value")]
        public bool IsMultiValue { get; set; }

        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "property_id")]
        public string PropertyId { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }
    }
}
