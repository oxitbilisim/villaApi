namespace Jemus.Domain.Dtos
{
    public class UserDto
    {
        public string title { get; set; }
        public string size { get; set; } = "sm";
        public byte[] img { get; set; }
    }
}