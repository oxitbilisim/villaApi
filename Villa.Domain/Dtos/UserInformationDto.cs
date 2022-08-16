using System;

namespace Villa.Domain.Dtos
{
    public class UserInformationDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public  string Status { get; set; }
        public string Role { get; set; }
        public byte[] Image { get; set; }
    }
}