using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Interfaces;
using WpfApp1.POCO;

namespace WpfApp1.DAO
{
    class CategoryDAO : InterfaceDAO<Category>
    {
        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> List()
        {
            List<Category> list = new List<Category>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                SqlCommand cmd = new SqlCommand("Select * from dbo.category", connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category c = new Category(reader.GetInt32(0), reader.GetString(1));
                        list.Add(c);
                    }
                }
            }
            return list;
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
