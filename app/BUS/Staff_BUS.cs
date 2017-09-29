using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    public class Staff_BUS
    {
        private static Staff_BUS instance;

        internal static Staff_BUS Instance
        {
            get { if (instance == null) instance = new Staff_BUS(); return Staff_BUS.instance; }
            private set { instance = value; }
        }

        private Staff_BUS() { }

        public Staff_DTO Get_Info(string username)
        {
            try
            {
                return Staff_DAO.Instance.Get_Info(username);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
