using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Models.DTOs;
using HardwarePOS.Models.Entities;
using System.Data;

namespace HardwarePOS.Data.Repositories
{
    public class ProductRepository
    {
        private readonly DbConnectionFactory _factory;

        public ProductRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"SELECT
                            p.ProductCode,
                            p.ProductName,
                            u.ShortName    
                        FROM 
                            Products p
                        INNER JOIN 
                            Units u ON p.UnitId = u.UnitId
                        WHERE
                            IsActive = 1
                        ORDER BY ProductId";

            var result = await connection.QueryAsync<Product>(sql);
            return result.ToList();
        }

        public async Task<List<Product>> GetCategoriesByProductAsync(int categoryId)
        {
            using var connection = _factory.CreateConnection();

            const string sql = @"
        SELECT
            ProductId,
            ProductName
        FROM Product
        WHERE CategoryId = @CategoryId
        ORDER BY ProductName;";

            var result = await connection.QueryAsync<Product>(
                sql,
                new { CategoryId = categoryId });

            return result.ToList();
        }

        public async Task<List<ProductListDto>>GetProductsAsync()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"SELECT
                            P.ProductId,
                            P.ProductName,
                            ISNULL(PC.CategoryName, '') AS CategoryName,
                            U.UnitName,
                            ISNULL(I.Balance, 0) AS CurrentStock,
                            ISNULL(I.AveragePrice, 0) AS AveragePrice
                        FROM Product P

                        LEFT JOIN ProductCategory PC
                            ON P.CategoryId = PC.CategoryId

                        LEFT JOIN Unit U
                            ON P.UnitId = U.UnitId

                        LEFT JOIN Inventory I
                            ON P.ProductId = I.ProductId

                        ORDER BY P.ProductName;";

            var result = await connection.QueryAsync<ProductListDto>(sql);

            return result.ToList();
        }
        public async Task<int> AddProductAsync(Product product)
        {
            using var connection = _factory.CreateConnection();

            var parameters = new
            {
                product.ProductName,
                product.CategoryId,
                product.UnitId,
                product.CreatedBy
            };

            return await connection.ExecuteScalarAsync<int>("sp_Product_Save", parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            using var connection = _factory.CreateConnection();

            string sql = @" SELECT
                            CategoryId,
                            CategoryName
                        FROM ProductCategory
                        ORDER BY CategoryName";

            var result = await connection.QueryAsync<CategoryDto>(sql);

            return result.ToList();
        }
        //public async Task<List<BrandDto>>GetBrandsAsync()
        //{
        //    using var connection = _factory.CreateConnection();

        //    string sql = @"SELECT
        //                        BrandId,
        //                        BrandName
        //                    FROM Brands
        //                    WHERE IsActive = 1
        //                    ORDER BY BrandName";

        //    var result = await connection.QueryAsync<BrandDto>(sql);

        //    return result.ToList();
        //}
        public async Task<List<UnitDto>>GetUnitsAsync()
        {
            using var connection = _factory.CreateConnection();

            string sql = @"SELECT
                                UnitId,
                                UnitName
                            FROM Unit
                            ORDER BY UnitName";

            var result = await connection.QueryAsync<UnitDto>(sql);

            return result.ToList();
        }

        //public async Task<List<SupplierDto>> GetSupplierAsync()
        //{
        //    using var connection = _factory.CreateConnection();

        //    string sql = @"SELECT
        //                        SupplierId,
        //                        SupplierName
        //                    FROM Suppliers
        //                    ORDER BY SupplierName";

        //    var result = await connection.QueryAsync<SupplierDto>(sql);

        //    return result.ToList();
        //}
    }

}