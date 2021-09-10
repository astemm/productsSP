using System;
using System.Data.SqlClient;
using ProductsSP.Models;

namespace ProductsSP.Repositories
{
    public class ProductMapper
    {
        public static Product MapProduct(SqlDataReader reader)
        {
            return new Product()
            {
                ProductId = (int)reader["ProductId"],
                Name = reader["Name"].ToString(),
                Description = reader["DescriptionOf"].ToString(),
                Photo = (byte[])reader["Photo"],
                Price=(Decimal)reader["Price"],
                Category=(Category)Enum.Parse(typeof(Category),reader["Category"].ToString(),true),
                Characteristics=reader["Characteristics"].ToString()
            };
        }
    }
}