using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    public class System_DAO
    {
        private static System_DAO instance;

        public static System_DAO Instance
        {
            get { if (System_DAO.instance == null) System_DAO.instance = new System_DAO(); return System_DAO.instance; }
            private set { System_DAO.instance = value; }
        }

        private System_DAO(){}

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public bool Login_System(string username, string password)
        {
            MD5 md5 = MD5.Create();
            string password_md5 = GetMd5Hash(md5, password);
            string query = "select * from Account where username='" + username + "' and password='" + password_md5 + "'";

            DataTable result = Connect.Instance.ExecuteQuery(query);

            return result.Rows.Count == 1;
        }

    }
}
