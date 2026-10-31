using HardwarePOS.Models.Entities;

namespace HardwarePOS.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<Staff?> GetByUsernameAsync(string Username);
    }
}