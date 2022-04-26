using Jemus.Domain.Entities;
using Jemus.Entities.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jemus.Domain.Auth
{
    public class AuthenticationResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PbikId { get; set; }
        public List<string> Roles { get; set; }
        public List<Permission> Permissions { get; set; }
        public string JWToken { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
    }
}
