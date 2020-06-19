using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SeniorWebAPIProjectV3.Models
{
    public class Swap
    {
        [JsonProperty("swapID")] [Key] public string SwapId { get; set; }
        [JsonProperty("senderUserID")] public string SenderUserId { get; set; }
        [JsonProperty("senderUserPhotoUrl")] public string SenderUserPhotoUrl { get; set; }
        [JsonProperty("senderUserName")] public string SenderUserName { get; set; }
        [JsonProperty("senderField")] public string SenderField { get; set; }
        [JsonProperty("receiverUserID")] public string ReceiverUserId { get; set; }
        [JsonProperty("receiverUserPhotoUrl")] public string ReceiverUserPhotoUrl { get; set; }
        [JsonProperty("receiverField")] public string ReceiverField { get; set; }

        [JsonProperty("receiverUserName")] public string ReceiverUserName { get; set; }
        [JsonProperty("isAccepted")] public bool IsAccepted { get; set; }
        [JsonProperty("isContinue")] public bool IsContinue { get; set; }
        [JsonProperty("isDone")] public bool IsDone { get; set; }
        [JsonProperty("swapRate")] public int SwapRate { get; set; }
        [JsonProperty("swapAddress")] public Address SwapAddress { get; set; }
        [JsonProperty("sendTime")] public DateTime SendTime { get; set; }
        [JsonProperty("acceptTime")] public DateTime AcceptTime { get; set; }
        [JsonProperty("swapTime")] public DateTime SwapTime { get; set; }
    }
}