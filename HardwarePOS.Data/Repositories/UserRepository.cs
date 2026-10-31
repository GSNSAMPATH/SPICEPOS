using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Data.Interfaces;
using HardwarePOS.Models.Entities;

namespace HardwarePOS.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbConnectionFactory _factory;

        public UserRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<Staff?> GetByUsernameAsync(string username)
        {
            using var connection = _factory.CreateConnection();

            string sql = @"
                SELECT TOP 1 *
                FROM Staff
                WHERE Username = @Username";

            return await connection.QueryFirstOrDefaultAsync<Staff>(
                sql,
                new { Username = username });
        }
    }
}