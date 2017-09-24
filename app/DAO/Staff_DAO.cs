using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Staff_DAO
    {
        private static Staff_DAO instance;

        internal static Staff_DAO Instance
        {
            get { if (instance == null) instance = new Staff_DAO(); return Staff_DAO.instance; }
            private set { instance = value; }
        }

        private Staff_DAO() { }

        public Staff_DTO Get_Info(string username)
        {
            string query = "exec dbo.USP_GetAccount @username";

            DataTable Staff_info = Connect.Instance.ExecuteQuery(query, new object[]{ username });

            Staff_DTO staff = null;

            foreach (DataRow item in Staff_info.Rows)
            {
                  staff = new Staff_DTO(item);
            }

            return staff;
        }
    }
}
