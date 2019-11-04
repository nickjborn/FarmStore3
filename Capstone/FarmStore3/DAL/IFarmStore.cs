using Dapper;
using FarmStore3.DAL.Models;
using FarmStore3.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FarmStore3.DAL
{
    public interface IFarmStore
    {
        IEnumerable<FarmDALModel> SelectAllProduct();

        bool AddProduct(FarmDALModel dalModel);

        bool UpdateProduct(int ProduceId, Products updatedProduct);
    }

    public class FarmStore : IFarmStore
    {
        private readonly Database _config;

        public FarmStore(FarmStore3Configuration config)
        {
            _config = config.Database;
        }


        public IEnumerable<FarmDALModel> SelectAllProduct()
        {
            var sql = @"SELECT * FROM Produce";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Query<FarmDALModel>(sql);

                return result;
            }
        }
        public bool AddProduct(FarmDALModel dalModel)
        {
            //ADD PRODUCT
            var sql = $@"Insert INTO Produce (ProduceName) Values (@{nameof(dalModel.ProduceName)})";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, dalModel);

                return true;
            }

        }

        public bool UpdateProduct(int ProduceId, Products updatedProduct)
        {
            updatedProduct.ProduceID = ProduceId;

            var sql = @"update Produce Set ProduceID = @ProduceID, 
                                            ProduceName = @ProduceName,
                                            StockQuantity = @StockQuantity,
                                            CartQuantity = @CartQuantity,
                                            UnitPrice = @UnitPrice,
                                            InSeason = @InSeason";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, updatedProduct);
                return true;
            }
        }


    }
}
