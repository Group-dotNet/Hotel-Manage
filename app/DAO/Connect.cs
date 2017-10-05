﻿using System;
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

        private static Connect instance;

        public static Connect Instance
        {
            get { if (instance == null) Connect.instance = new Connect(); return Connect.instance; }
            private set { instance = value; }
        }

        private Connect() { }

        //string connect taken from Dialog "Server Explorer"
        private string str_connect = "Data Source=DESKTOP-A9E2N6S\\SQLEXPRESS;Initial Catalog=hotel;Integrated Security=True";


        //@description:
        //    exce used to listed the list record right
        //@parameter: 
        //    string query        --using proc in database or script sql
        //    object parameter    --using when proc or sql container any parameter
        //@return:
        //    DataTable           -- get list record in database


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

        //@description:
        //    exec used to insert, update, delete in database
        //@parameter: 
        //    string query        --using proc in database or script sql
        //    object parameter    --using when proc or sql container any parameter
        //@return:
        //    int                 -- get number record add, update or delete
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


        //@description:
        //    exce used to count record right
        //@parameter: 
        //    string query        --using proc in database or script sql
        //    object parameter    --using when proc or sql container any parameter
        //@return:
        //    object              -- get first line when exce query

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
