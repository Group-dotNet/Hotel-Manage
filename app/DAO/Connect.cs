using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    public class Connect
    {

        private string str_connect = "Data Source=KIENDINH\\SQLEXPRESS;Initial Catalog=app;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter =null )
        {
            DataTable data = new DataTable();
            using(SqlConnection connect = new SqlConnection(str_connect)){

                connect.Open();

                SqlCommand cmd = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0; 
                    foreach(string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                connect.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connect = new SqlConnection(str_connect))
            {

                connect.Open();

                SqlCommand cmd = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                data = cmd.ExecuteNonQuery();

                connect.Close();
            }

            return data;

        }


        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connect = new SqlConnection(str_connect))
            {

                connect.Open();

                SqlCommand cmd = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                data = cmd.ExecuteScalar();

                connect.Close();
            }

            return data;

        }

    }
}
