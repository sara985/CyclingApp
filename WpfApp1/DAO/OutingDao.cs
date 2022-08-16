using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WpfApp1.POCO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModels;

namespace WpfApp1.DAO
{
    class OutingDao : Interfaces.InterfaceDAO<Outing>
    {
        public void Delete(Outing t)
        {
            throw new NotImplementedException();
        }

        public Outing GetById(int id)
        {
            Outing o = new Outing();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                SqlCommand cmd = new SqlCommand("select * from outing where id = @id", connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    o.Id = reader.GetInt32("id");
                    o.Outingdate = reader.GetDateTime("outingdate");
                    o.Startingpoint = reader.GetString("startingpoint");
                    o.Cost = reader.GetDecimal("cost");
                    o.Category = reader.GetInt32("category");
                }
            }
            return o;
        }

        
        public void Insert(Outing t)
        {
           
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                SqlCommand cmd = new SqlCommand("insert into outing values(@sp,@do,@c,@cat);", connection);
                cmd.Parameters.AddWithValue("sp", t.Startingpoint);
                cmd.Parameters.AddWithValue("do", t.Outingdate);
                cmd.Parameters.AddWithValue("c", t.Cost);
                cmd.Parameters.AddWithValue("cat", t.Category);
                connection.Open();
                cmd.ExecuteNonQuery();
                
            }
        }

        public List<Outing> List()
        {
            try
            {
                List<Outing> list = new List<Outing>();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
                {
                    SqlCommand cmd = new SqlCommand("Select * from dbo.outing", connection);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Outing o = new Outing();
                            o.Id = reader.GetInt32(0);
                            o.Outingdate = reader.GetDateTime(2);
                            //o.Outingdate = reader.GetDateTime(2);
                            o.Startingpoint = reader.GetString(1);
                            o.Cost = reader.GetDecimal(3);
                            o.Category = reader.GetInt32(4);
                            list.Add(o);
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


        public void Update(Outing t)
        {
            throw new NotImplementedException();
        }

        //public static implicit operator OutingDao(MemberOutingViewModel v)
        //{
        //    throw new NotImplementedException();
        //}

        public int getRequestPassengerPlacesByOutingId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                SqlCommand cmd = new SqlCommand("select count(*) as number from outingregistration where outingid=@outingid and ispassenger = 1", connection);
                cmd.Parameters.AddWithValue("outingid", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return reader.GetInt32("number");
                }
            }
        }
        public int getRequestBikesPlacesByOutingId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                SqlCommand cmd = new SqlCommand("select count(*) as number from outingregistration where outingid=@outingid and hasBike = 1", connection);
                cmd.Parameters.AddWithValue("outingid", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return reader.GetInt32("number");
                }
            }
        }

        public bool BookOnlyOutingForMember(int memberId,int outingid)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                SqlCommand cmd = new SqlCommand("Insert into outingregistration values(@memberid,@outingid,null,0);", connection);
                cmd.Parameters.AddWithValue("outingid", outingid);
                cmd.Parameters.AddWithValue("memberid", memberId);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                return res > 0;
            }
        }
    }
}
