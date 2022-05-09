using System.Collections.Generic;

namespace Villa.Domain.Dtos
{
    public class RoleUsersDto
    {
        public string title { get; set; }

        public int totalUsers { get; set; }
        public List<UserDto> users { get; set; }
    }
}