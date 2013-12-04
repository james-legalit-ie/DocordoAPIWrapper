namespace DocordoAPI.Test.Data.Domain.NodeTypeData
{
    using System;
    using Newtonsoft.Json;

    public class DocordoMatterData
    {
        [JsonProperty(PropertyName = "cada17e7ace149c9a476d300a41e131d")]
        public string MatterDescription { get; set; }

        [JsonProperty(PropertyName = "cdda28982c004e209ec371038e2da527")]
        public string MatterStatus { get; set; }

        //@start - Danske
        [JsonProperty(PropertyName = "f6280707ffea499bbba923c9bfa10af7")]
        public string CurrentStage { get; set; }

        [JsonProperty(PropertyName = "daa352ce966d4b4fa58bdca7a9055886")]
        public string NameOfBorrower { get; set; }

        [JsonProperty(PropertyName = "ef87ce7d5e004e71b2d8aa8808518c20")]
        public string BankRefNo { get; set; }

        [JsonProperty(PropertyName = "jbeebd7bc54c458ba59412ad4eefdce6")]
        public string PropDesc { get; set; }

        [JsonProperty(PropertyName = "d517c902d9004af5bb14ee276547a918")]
        public string FeeEarnerA { get; set; }

        [JsonProperty(PropertyName = "e93e0068c214413bb78392bd6ef7cb7b")]
        public string BankContactName { get; set; }

        [JsonProperty(PropertyName = "hd5e1712ac274513b244794802a780bb")]
        public DateTime? DateStage1 { get; set; }

        [JsonProperty(PropertyName = "db2a6be080f24467a43dd95f85ba6eee")]
        public DateTime? DateStage2 { get; set; }

        [JsonProperty(PropertyName = "a93ab71e0bc841908783bfea9ff0d9ea")]
        public DateTime? DateStage3 { get; set; }

        [JsonProperty(PropertyName = "a9e4fa325fb2411992097b81e6367e5f")]
        public DateTime? DateStage4 { get; set; }

        [JsonProperty(PropertyName = "g071a1eb3d4f4286b5c1150b68635db9")]
        public DateTime? DateStage5 { get; set; }

        [JsonProperty(PropertyName = "g3c1412c087f4c728d78e7d39c4482b9")]
        public DateTime? DateStage6 { get; set; }

        [JsonProperty(PropertyName = "fa7b84df79594d6087ef5955f37bbee2")]
        public DateTime? DateStage7 { get; set; }

        [JsonProperty(PropertyName = "a8308d26844a40d2a311a5d34783a62e")]
        public DateTime? DateStage8 { get; set; }

        [JsonProperty(PropertyName = "ebc7c50dda944148bbb8eb69caf4e259")]
        public string CanARecBeApp { get; set; }

        [JsonProperty(PropertyName = "c11596f693c04f1cbb61db1bfd101597")]
        public string RecApp { get; set; }

        [JsonProperty(PropertyName = "g25b1d793e804f588e53feb690faaf35")]
        public string RecAppNotPoss { get; set; }

        [JsonProperty(PropertyName = "j3d624df43d94f5b9f6178adcadebbe2")]
        public string NotProceeding { get; set; }
        //@end

        public static DocordoMatterData New(string matterDescription)
        {
            DocordoMatterData docordoMatterData = new DocordoMatterData()
            {
                MatterDescription = matterDescription,
                MatterStatus = "Active"
            };

            return docordoMatterData;
        }
    }
}
