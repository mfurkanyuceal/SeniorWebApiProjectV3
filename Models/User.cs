using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace SeniorWebAPIProjectV3.Models
{
    public class User
    {
        [JsonProperty("id")] [Key] public string Id { get; set; }

        [JsonProperty("firstName")] public string FirstName { get; set; }

        [JsonProperty("lastName")] public string LastName { get; set; }

        [JsonProperty("gender")] public string Gender { get; set; }

        [JsonProperty("isAdmin")] public bool IsAdmin { get; set; }

        [JsonProperty("profilePhotoURL")] public string ProfilePhotoUrl { get; set; }

        [JsonProperty("userFancies")] public List<string> UserFancies { get; set; }

        [JsonProperty("userAbilities")] public List<string>  UserAbilities { get; set; }

        [JsonProperty("address")] public Address Address { get; set; }

        [JsonProperty("userName")] public string UserName { get; set; }

        [JsonProperty("email")] public string Email { get; set; }
    }

    public class Address
    {
        [Key][JsonProperty("addressId")] public int AddressId { get; set; }
        
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("city")]
        public string City { get; set; }
        
        [JsonProperty("district")]
        public string District { get; set; }
        
    }
}