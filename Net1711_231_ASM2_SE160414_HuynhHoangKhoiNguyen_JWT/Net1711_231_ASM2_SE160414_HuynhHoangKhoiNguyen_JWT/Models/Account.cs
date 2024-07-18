namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Models
{
    public class Account
    {
        public Guid AccountId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


        public Account(Guid accountId, string fullName, string email, string password, string role)
        {
            AccountId = accountId;
            FullName = fullName;
            Email = email;
            Password = password;
            Role = role;
        }

        public Account()
        {
        }
    }



}
