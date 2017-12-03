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
            
            string query = "exec USP_CheckLogin @username , @password";

            DataTable result = Connect.Instance.ExecuteQuery(query, new object[] { username, password });

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

        public List<System_DTO> Get_List_Staff_Service()
        {
            string query = "exec USP_GetList_Staff_Service";

            DataTable list = Connect.Instance.ExecuteQuery(query);

            List<System_DTO> list_staff = new List<System_DTO>();

            foreach (DataRow item in list.Rows)
            {
                System_DTO account = new System_DTO(item);
                list_staff.Add(account);
            }

            return list_staff;
        }


        public bool Change_password(string username, string password_new)
        {
            string query = "exec USP_Change_password @username , @password";

            int record = Connect.Instance.ExecuteNonQuery(query, new object[] { username, password_new });

            return record == 1;
        }

        public bool CheckExistsAccount()
        {
            string query = "exec USP_CheckExistsAccount";
            int x = (int)Connect.Instance.ExecuteOutPut(query);
            return x == 1;
        }
    }
}
