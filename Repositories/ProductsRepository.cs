using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using ProductsSP.Models;

namespace ProductsSP.Repositories
{
    public class ProductsRepository: IProductsRepository
    {
        private readonly string connectionString;

        public ProductsRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("ProductsDbConnection");
        }
         
         public List<Product> GetAllProducts() {
         using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAllProducts", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<Product>();
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response.Add(ProductMapper.MapProduct(reader));
                        }
                    }
                    return response;
                }
            }
        }  

         public Product GetProduct(int id) {
         using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetProductById", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    Product response = null;
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response=ProductMapper.MapProduct(reader);
                        }
                    }
                    return response;
                }
            }
    
         }
    }
}