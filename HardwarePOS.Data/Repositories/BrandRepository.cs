using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Models.Entities;


namespace HardwarePOS.Data.Repositories
{
    public class BrandRepository
    {
        private readonly DbConnectionFactory _factory;

        public BrandRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }


        public async Task<int> AddBrandAsync(Brand brand)
        {
            using var connection = _factory.CreateConnection();

            string sql = @"INSERT INTO Brands
                            (
                                BrandName,
                                IsActive
                            )
                            VALUES
                            (
                                @BrandName,
                                @IsActive
                            );

                            SELECT CAST(SCOPE_IDENTITY() as int);
                            ";

            return await connection.ExecuteScalarAsync<int>(sql, brand);
        }
    }
}
