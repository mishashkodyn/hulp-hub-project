namespace Application.DTOs.User
{
    public class UserProfileDto
    {
        public Guid? Id { get; set; }
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? ProfileImage { get; set; }
        public int UserCategory { get; set; }
        public IList<string> Roles { get; set; } = new List<string>();
    }
}
