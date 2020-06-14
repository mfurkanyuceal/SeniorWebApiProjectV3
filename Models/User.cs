using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeniorWebAPIProjectV3.Models
{
    public class User
    {
        [Key] public string userID { get; set; }
        public string profilePhotoURL { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public bool isAdmin { get; set; }
        public List<string> userFancies { get; set; }
        public List<string> userAbilities { get; set; }
        public Address address { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
    }

    public class Address
    {
        [Key] public int AddressId { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string description { get; set; }
    }
}