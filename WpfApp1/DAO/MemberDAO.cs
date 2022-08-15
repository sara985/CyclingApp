using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WpfApp1.POCO;
using System.Configuration;
using System.Data;

namespace WpfApp1.DAO
{
    class MemberDAO : Interfaces.InterfaceDAO<Member>
    {
        public void Insert(Member t)
        {
            
        }

        public void Delete(Member t)
        {
            throw new NotImplementedException();
        }
        public Member GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                Member m = new Member();
                SqlCommand cmd = new SqlCommand("Select * from dbo.member where id=@id", connection);
                cmd.Parameters.AddWithValue("id",id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        m.Id = reader.GetInt32("id");
                        m.Firstname = reader.GetString("firstname");
                        m.Lastname = reader.GetString("lastname");
                        m.Email = reader.GetString("mail");
                        m.Phone = reader.GetString("phone");
                        m.Password = reader.GetString("password");
                        m.Position = reader.GetInt32("position");
                        decimal bal = reader.GetDecimal(7);
                        m.Balance = bal;
                    }
                }
                return m;
            }
            
        }
        public List<Category> GetCategoriesByMemberId(int id)
        {
            try
            {
                List<Category> list = new List<Category>();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
                {
                    SqlCommand cmd = new SqlCommand("Select * from dbo.enrollment en join dbo.category cat on cat.id = en.categoryid where en.memberid = @Id ", connection);
                    cmd.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category c = new Category(reader.GetInt32(1), reader.GetString(9));
                            list.Add(c);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Member> List()
        {
            try
            {
                List<Member> list = new List<Member>();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
                {
                    SqlCommand cmd = new SqlCommand("Select * from dbo.member", connection);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member m = new Member();
                            m.Id = reader.GetInt32(0);
                            m.Firstname = reader.GetString(1);
                            m.Lastname = reader.GetString(2);
                            m.Email = reader.GetString(3);
                            m.Phone = reader.GetString(4);
                            m.Password = reader.GetString(5);
                            m.Position = reader.GetInt32(6);
                            m.Balance = 0;
                            list.Add(m);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void Update(Member t)
        {
            throw new NotImplementedException();
        }

        public Member GetByLogin(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                SqlCommand cmd = new SqlCommand("Select * from dbo.member where mail=@email and password = @password", connection);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Member m = new Member();
                        m.Id = reader.GetInt32("id");
                        m.Firstname = reader.GetString("firstname");
                        m.Lastname = reader.GetString("lastname");
                        m.Email = reader.GetString("mail");
                        m.Phone = reader.GetString("phone");
                        m.Password = reader.GetString("password");
                        m.Position = reader.GetInt32("position");
                        decimal bal = reader.GetDecimal(7);
                        m.Balance = bal;
                        return m;
                    }
                }
            }
            return null;
        }

        public List<Bike> getBikesByMemberId(int id)
        {
            List<Bike> bikes = new List<Bike>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {                
                SqlCommand cmd = new SqlCommand("Select * from dbo.bike where ownerid = @id", connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bike b = new Bike();
                        b.Id = reader.GetInt32("id");
                        b.Length = reader.GetInt32("length");
                        b.Weight = reader.GetInt32("weight");
                        b.Type = reader.GetString("type");
                        bikes.Add(b);
                    }
                }
            }
            return bikes;
        }


    }
}
