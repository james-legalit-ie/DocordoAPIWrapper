// -----------------------------------------------------------------------
// <copyright file="DocordoResultBean.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DocordoAPI.Model.Domain
{
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DocordoSearch
    {
        [JsonProperty(PropertyName = "node_type_id")]
        public string NodeTypeId { get; set; }

        [JsonProperty(PropertyName = "node_type_name")]
        public string NodeTypeName { get; set; }

        [JsonProperty(PropertyName = "node_id")]
        public string NodeId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "record_number")]
        public string RecordNumber { get; set; }

        [JsonProperty(PropertyName = "uncompressed_record_number")]
        public string UncompressedRecordNumber { get; set; }

        [JsonProperty(PropertyName = "date_registered")]
        public string DateRegistered { get; set; }

        [JsonProperty(PropertyName = "classification")]
        public string Classification { get; set; }

        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "_is_leaf")]
        public bool IsLeaf { get; set; }

        [JsonProperty(PropertyName = "_parent")]
        public DocordoSearch Parent { get; set; }

        [JsonProperty(PropertyName = "container_type")]
        public string ContainerType { get; set; }

        [JsonProperty(PropertyName = "is_electronic")]
        public bool IsElectronic { get; set; }

        [JsonProperty(PropertyName = "is_checkout")]
        public bool IsCheckout { get; set; }

        [JsonProperty(PropertyName = "can_attach_content")]
        public bool CanAttachContent { get; set; }

        [JsonProperty(PropertyName = "can_verify_content")]
        public bool CanVerifyContent { get; set; }

        [JsonProperty(PropertyName = "is_container")]
        public bool IsContainer { get; set; }

        [JsonProperty(PropertyName = "container_level")]
        public int ContainerLevel { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        [JsonProperty(PropertyName = "is_finalized")]
        public bool IsFinalized { get; set; }

        [JsonProperty(PropertyName = "is_in_hold")]
        public bool IsInHold { get; set; }

        [JsonProperty(PropertyName = "version")]
        public int Version { get; set; }

        [JsonProperty(PropertyName = "checked_out_by")]
        public string CheckedOutBy { get; set; }

        //NODE TYPE SPECIFIC
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }


        //UPLOAD CONTENT SPECIFIC
        [JsonProperty(PropertyName = "file_name")]
        public string FileName { get; set; }

        [JsonProperty(PropertyName = "filename")]
        public string ContentId { get; set; }

        [JsonProperty(PropertyName = "field_name")]
        public string FieldName { get; set; }

        [JsonProperty(PropertyName = "content_type")]
        public string ContentType { get; set; }

        [JsonProperty(PropertyName = "size_in_bytes")]
        public int SizeInBytes { get; set; }
    }
}
