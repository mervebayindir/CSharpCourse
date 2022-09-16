using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; initial catalog=ETrade; integrated security=true");

        public DataTable GetAll()
        {
            if (_connection.State==ConnectionState.Closed)
            {
                _connection.Open();
            }

            SqlCommand command = new SqlCommand("Select * from Products",_connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        public List<Product> GetAll2()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id=Convert.ToInt32(reader["Id"]),
                    Name=reader["Name"].ToString(),
                    StockAmount=Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice=Convert.ToDecimal(reader["UnitPrice"]),
                };
                products.Add(product);
            }
          
            reader.Close();
            _connection.Close();
            return products;
        }
       public void Add(Product product)
        {
            if (_connection.State==ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)",_connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount",product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public bool Update(Product product)
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id",product.Id);
            int kontrol=command.ExecuteNonQuery();
 
            _connection.Close();
            return (kontrol > 0) ? true : false;
        }

        public void Delete(int id)
        {
            SqlCommand command = new SqlCommand("Delete from Products where Id=@id",_connection);
            command.Parameters.AddWithValue("@id", id);
            _connection.Open();
            command.ExecuteNonQuery();
            command.Clone();
        }
    }
}
