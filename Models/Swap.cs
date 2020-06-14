using System;
using System.ComponentModel.DataAnnotations;

namespace SeniorWebAPIProjectV3.Models
{
    public class Swap
    {
        [Key] public string swapID { get; set; }
        public string senderUserID { get; set; }
        public string senderUserPhotoUrl { get; set; }
        public string senderUserName { get; set; }
        public string receiverUserID { get; set; }
        public string receiverUserPhotoUrl { get; set; }
        public string receiverUserName { get; set; }
        public bool isAccepted { get; set; }
        public bool isContinue { get; set; }
        public bool isDone { get; set; }
        public int swapRate { get; set; }
        public Address swapAddress { get; set; }
    }
}