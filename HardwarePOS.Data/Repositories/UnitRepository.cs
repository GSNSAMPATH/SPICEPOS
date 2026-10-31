using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Models.Entities;

namespace HardwarePOS.Data.Repositories
{
    public class UnitRepository
    {
        private readonly DbConnectionFactory _factory;

        public UnitRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }


        public async Task<int> AddUnitAsync(Unit unit)
        {
            using var connection = _factory.CreateConnection();

            string sql = @"INSERT INTO Units
                            (
                                UnitName,
                                ShortName

                            )
                            VALUES
                            (
                                @UnitName,
                                @ShortName
                            );

                            SELECT CAST(SCOPE_IDENTITY() as int);
                            ";

            return await connection.ExecuteScalarAsync<int>(sql, unit);
        }

        public async Task<List<Unit>> GetAllAsync()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"SELECT
                            UnitId,
                            UnitName,
                            UnitCode 
                        FROM 
                            Unit";

            var result = await connection.QueryAsync<Unit>(sql);
            return result.ToList();
        }
    }
}

