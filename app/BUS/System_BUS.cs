using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    public class System_BUS
    {
        private static System_BUS instance;

        public static System_BUS Instance
        {
            get { if (instance == null) System_BUS.instance = new System_BUS(); return System_BUS.instance; }
            private set { instance = value; }
        }

        private System_BUS() { }


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
            try
            {
                MD5 md5 = MD5.Create();
                string password_md5 = GetMd5Hash(md5, password);
                return System_DAO.Instance.Login_System(username, password_md5);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public System_DTO Get_Account(string username)
        {
            try
            {
                return System_DAO.Instance.Get_Account(username);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Check_pass_old(string username, string pass_old)
        {
            try
            {
                System_DTO account = System_DAO.Instance.Get_Account(username);
                MD5 md5 = MD5.Create();
                string password_md5 = GetMd5Hash(md5, pass_old);
                return password_md5 == account.Password;
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<System_DTO> Get_List_Staff_Service()
        {
            try
            {
                return System_DAO.Instance.Get_List_Staff_Service();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Change_password(string username, string password_new)
        {
            try
            {
                MD5 md5 = MD5.Create();
                string pass_md5 = GetMd5Hash(md5, password_new);
                return System_DAO.Instance.Change_password(username, pass_md5);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool CheckExistsAccount()
        {
            try
            {
                return System_DAO.Instance.CheckExistsAccount();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Change_role(string username, int role)
        {
            try
            {
                return System_DAO.Instance.Change_role(username, role);
            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                throw new Exception("Error!");
            }
        }
    }
}
