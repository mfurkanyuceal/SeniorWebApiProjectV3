using System.ComponentModel.DataAnnotations.Schema;

namespace SeniorWebAPIProjectV3.Models
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Swap
    {
        [JsonProperty("swapID")] public string SwapId { get; set; }

        [JsonProperty("swapAddress")] public Address SwapAddress { get; set; }

        [JsonProperty("senderUserID")]
        [ForeignKey("SenderUser")]
        public string SenderUserId { get; set; }

        public User SenderUser { get; set; }
        [JsonProperty("senderRate")] public double SenderRate { get; set; }
        [JsonProperty("senderField")] public string SenderField { get; set; }

        [JsonProperty("receiverUserID")]
        [ForeignKey("ReceiverUser")]
        public string ReceiverUserId { get; set; }

        public User ReceiverUser { get; set; }
        [JsonProperty("receiverRate")] public double ReceiverRate { get; set; }
        [JsonProperty("receiverField")] public string ReceiverField { get; set; }


        [JsonProperty("isAccepted")] public bool IsAccepted { get; set; }

        [JsonProperty("isContinue")] public bool IsContinue { get; set; }

        [JsonProperty("isDone")] public bool IsDone { get; set; }
        [JsonProperty("isReject")] public bool IsReject { get; set; }
        [JsonProperty("isCancel")] public bool IsCancel { get; set; }

        [JsonProperty("swapRate")] public double SwapRate { get; set; }

        [JsonProperty("sendTime")] public DateTimeOffset? SendTime { get; set; }

        [JsonProperty("acceptTime")] public DateTimeOffset? AcceptTime { get; set; }

        [JsonProperty("swapTime")] public DateTimeOffset? SwapTime { get; set; }
    }

    public partial class Swap
    {
        public static Swap FromJson(string json) =>
            JsonConvert.DeserializeObject<Swap>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Swap self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            },
        };
    }
}