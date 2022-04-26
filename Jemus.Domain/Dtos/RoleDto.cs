using System.Collections.Generic;

namespace Jemus.Domain.Dtos
{
    public class RoleDto
    {
        public string title { get; set; }

        public int totalUsers { get; set; }
        public List<UserDto> users { get; set; }
    }
}