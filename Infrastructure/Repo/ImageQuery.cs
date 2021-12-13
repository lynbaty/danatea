using System.Collections.Generic;
using System.Linq;
using Core.Entities.Store;
using Core.Interfaces.Query;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Infrastructure.Repo
{
    public class ImageQuery : IImageQuery
    {
        private readonly IConfiguration _config;

        public ImageQuery(IConfiguration config)
        {
            _config = config;
        }
        private IDbConnection _connection => new SqlConnection(_config.GetConnectionString("DanateaConnection"));
        public IReadOnlyList<ProductImage> GetAll()
        {
            string sql = "SELECT * FROM ProductImages";
            var result = new List<ProductImage>();
            using (var connection = _connection)
            {
                result = connection.Query<ProductImage>(sql).ToList();
            }
            return result;
        }
        public IReadOnlyList<ProductImage> GetbyId(int productId)
        {
            string sql = "GetImagebyProductId";
            var result = new List<ProductImage>();
            using (var connection = _connection)
            {
                result = connection.Query<ProductImage>(sql,new{productId=productId},commandType:CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public bool DeletebyId(int id)
        {
            string sql = "DeleteImagebyId";
            int result = 0;
            using (var connection = _connection)
            {
                result = connection.Execute(sql,new{id=id},commandType:CommandType.StoredProcedure);
            }
            return result > 0;
        }
        public int UploadImage(int productId, string url)
        {
            string sql = "AddImage";
           
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@productId", productId, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@url", url , DbType.String, ParameterDirection.Input);
            parameter.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            
            _connection.Execute(sql,parameter,commandType: CommandType.StoredProcedure);
           
            return parameter.Get<int>("@Id");
        }
        public IReadOnlyList<ProductCateDto> MultiMapping()
        {
            string sql = "SELECT * FROM Products INNER JOIN Categories ON Products.CategoryId = Categories.Id;";
            var result = new List<ProductCateDto>();
            using (var connection = _connection)
            {
                result = connection.Query<Product,Category,ProductCateDto>(sql,(p,c) => {return new ProductCateDto(){ProductId = p.Id,ProductName = p.Name, CategorieName = c.Name};}).ToList();
            }
            return result;
        }

    }
}