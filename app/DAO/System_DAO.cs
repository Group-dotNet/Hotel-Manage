using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        

        public bool Login_System(string username, string password)
        {
            
            string query = "select * from Account where username='" + username + "' and password='" + password + "'";

            DataTable result = Connect.Instance.ExecuteQuery(query);

            return result.Rows.Count == 1;
        }


        public System_DTO Get_Account(string username)
        {
            string query = "exec USP_GetAccount @username";

            DataTable account_info = Connect.Instance.ExecuteQuery(query, new object[] { username });

            System_DTO account = null;

            foreach (DataRow item in account_info.Rows)
            {
                account = new System_DTO(item);
            }

            return account;

        }


        public bool Change_password(string username, string password_new)
        {
            string query = "exec USP_Change_password @username , @password";

            int record = Connect.Instance.ExecuteNonQuery(query, new object[] { username, password_new });

            return record == 1;
        }
    }
}
