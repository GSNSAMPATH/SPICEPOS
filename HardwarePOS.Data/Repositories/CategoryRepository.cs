using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Models.Entities;

namespace HardwarePOS.Data.Repositories
{
    public class CategoryRepository
    {
        private readonly DbConnectionFactory _factory;

        public CategoryRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<int> AddCategoryAsync(ProductCategory category)
        {
            using var connection = _factory.CreateConnection();

            string sql = @"INSERT INTO ProductCategory
                            (
                                CategoryName
                            )
                            VALUES
                            (
                                @CategoryName
                            );

                            SELECT CAST(SCOPE_IDENTITY() as int);
                            ";

            return await connection.ExecuteScalarAsync<int>(sql,category);
        }
    }
}