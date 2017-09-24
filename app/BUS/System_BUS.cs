using app.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool Login_System(string username, string password)
        {
            try
            {
                return System_DAO.Instance.Login_System(username, password);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
