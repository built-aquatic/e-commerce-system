// ProductRepository.cs
using System.Collections.Generic;
using System.Data.SqlClient;

public class ProductRepository
{
    public List<Product> GetProducts()
    {
        List<Product> products = new List<Product>();

        using (SqlConnection connection = Database.GetConnection())
        {
            connection.Open();
            string query = "SELECT * FROM Products";
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Price = (decimal)reader["Price"]
                    });
                }
            }
        }

        return products;
    }
}
