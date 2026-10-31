namespace HardwarePOS.Models.Entities
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Teliphone { get; set; } = string.Empty;

        //public bool IsActive { get; set; }
    }
}