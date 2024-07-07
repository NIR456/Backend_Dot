namespace API_Login.Models
{
    public class LoginUser_mdl
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Department { get; set; }
        public string CreatedBy {  get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastModifiedBy { get; set; }
        public int? RoleId { get; set; }
        public long? RoleKey { get; set; }
        public AdminRole_mdl AdminRole { get; set; }
    }
}
