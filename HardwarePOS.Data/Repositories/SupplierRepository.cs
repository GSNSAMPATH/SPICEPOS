using HardwarePOS.Data.Database;
using HardwarePOS.Models.Entities;
using Dapper;


namespace HardwarePOS.Data.Repositories
{
    public class SupplierRepository
    {
        private readonly DbConnectionFactory _factory;

        public SupplierRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }


        public async Task<List<Supplier>>GetAllAsync()
        {
            using var connection = _factory.CreateConnection();

            string sql =
            """
            SELECT
                SupplierId,
                SupplierName,
                Phone AS SupplierPhone,
                Email AS SupplierEmail,
                Address AS SupplierAddress
            FROM Suppliers
            ORDER BY SupplierName
            """;

            var suppliers =
                await connection.QueryAsync<Supplier>(
                    sql);

            return suppliers.ToList();
        }
    

        public async Task<int> AddSupplierAsync(Supplier supplier)
        {
            using var connection = _factory.CreateConnection();

            string sql = @"INSERT INTO Suppliers
                            (
                                SupplierName,
                                Phone,
                                Email,  
                                Address
                            )
                            VALUES
                            (
                                @SupplierName,
                                @SupplierPhone,
                                @SupplierEmail,
                                @SupplierAddress
                            );
                            SELECT CAST(SCOPE_IDENTITY() as int);";

            return await connection.ExecuteScalarAsync<int>(sql, supplier);
        }
    }
}

