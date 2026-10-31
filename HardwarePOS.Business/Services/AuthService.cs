using BCrypt.Net;
using HardwarePOS.Data.Interfaces;
using HardwarePOS.Models.Entities;

namespace HardwarePOS.Business.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Staff?> LoginAsync(
            string username,
            string password)
        {
            // Get user from database
            var user =
                await _userRepository.GetByUsernameAsync(username);

            // User not found
            if (user == null)
                return null;

            // Verify password
            bool validPassword =
                BCrypt.Net.BCrypt.Verify(
                    password,
                    user.PasswordHash);

            // Invalid password
            if (!validPassword)
                return null;

            // Login success
            return user;
        }
    }
}