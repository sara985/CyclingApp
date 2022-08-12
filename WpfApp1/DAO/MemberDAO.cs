using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WpfApp1.POCO;
using System.Configuration;

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
            throw new NotImplementedException();
        }

        public List<Member> List()
        {
            try
            {
                List<Member> list = new List<Member>();
                Console.WriteLine(ConfigurationManager.AppSettings["connectionString"]);
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
                Console.WriteLine("exception");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void Update(Member t)
        {
            throw new NotImplementedException();
        }
    }
}
