namespace API_Login.Models
{
    public class AdminRole_mdl
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LoginUser_mdl> LoginUsers { get; set; }

    }
}
