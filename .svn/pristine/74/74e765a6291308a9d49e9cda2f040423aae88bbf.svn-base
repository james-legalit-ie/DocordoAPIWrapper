namespace DocordoAPI.Model.Domain
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public abstract class DocordoBaseNode<T>
    {
        [JsonProperty(PropertyName = "ebikko_session_id")]
        public string EbikkoSessionId { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "node_type_id")]
        public string NodeTypeId { get; set; }

        [JsonProperty(PropertyName = "node_id")]
        public string NodeId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "record_number_pattern")]
        public string RecordNumberPattern { get; set; }

        [JsonProperty(PropertyName = "date_closed")]
        public string DateClosed { get; set; }

        [JsonProperty(PropertyName = "enclosure_number")]
        public string EnclosureNumber { get; set; }

        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        [JsonProperty(PropertyName = "bypass_referenced_acls")]
        public bool BypassReferencedAcls { get; set; }

        [JsonProperty(PropertyName = "security_based_on_container")]
        public bool SecurityBasedOnContainer { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "barcode")]
        public string Barcode { get; set; }

        [JsonProperty(PropertyName = "classification")]
        public string Classification { get; set; }

        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }

        [JsonProperty(PropertyName = "current_assignee")]
        public string CurrentAssignee { get; set; }

        [JsonProperty(PropertyName = "disposition_status")]
        public string DispositionStatus { get; set; }

        [JsonProperty(PropertyName = "external_barcode")]
        public string ExternalBarcode { get; set; }

        [JsonProperty(PropertyName = "external_id")]
        public string ExternalId { get; set; }

        [JsonProperty(PropertyName = "finalized")]
        public bool Finalized { get; set; }

        [JsonProperty(PropertyName = "home")]
        public string Home { get; set; }

        [JsonProperty(PropertyName = "integrity_check")]
        public string IntegrityCheck { get; set; }

        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        [JsonProperty(PropertyName = "record_number")]
        public string RecordNumber { get; set; }

        [JsonProperty(PropertyName = "retention_schedule_id")]
        public string RetentionScheduleId { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "date_registered")]
        public string DateRegistered { get; set; }

        [JsonProperty(PropertyName = "date_finalized")]
        public string DateFinalized { get; set; }

        [JsonProperty(PropertyName = "date_created")]
        public string DateCreated { get; set; }

        [JsonProperty(PropertyName = "date_archived")]
        public string DateArchived { get; set; }

        [JsonProperty(PropertyName = "date_made_inactive")]
        public string DateMadeInactive { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "batch_id")]
        public string BatchId { get; set; }

        [JsonProperty(PropertyName = "acl_id")]
        public string AclId { get; set; }

        [JsonProperty(PropertyName = "acl_list")]
        public List<object> AclList { get; set; }

        [JsonProperty(PropertyName = "security_level_id")]
        public string SecurityLevelId { get; set; }

        [JsonProperty(PropertyName = "data")]
        public T Data { get; set; }

        public DocordoBaseNode<T> SetDefaultFields(string method, string nodeTypeId, string ebikkoSessionId, string nodeId, string containerId, string title, string externalId, T data)
        {
            this.Method = method;
            this.NodeTypeId = nodeTypeId;
            this.EbikkoSessionId = ebikkoSessionId;
            this.NodeId = nodeId;
            this.Container = containerId;
            this.Title = title;
            this.ExternalId = externalId;
            this.Data = data;

            return this;
        }
    }
}
