using HardwarePOS.Models.Entities;

namespace HardwarePOS.Shared.Helpers
{
    public static class UserSession
    {
        public static Staff? CurrentUser { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static int StaffId => CurrentUser?.StaffId ?? 0;

        public static string UserName => CurrentUser?.Username ?? string.Empty;

        public static string FullName => CurrentUser?.FullName ?? string.Empty;

        public static string Telephone => CurrentUser?.Teliphone ?? string.Empty;

        public static void Login(Staff staff)
        {
            CurrentUser = staff;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}