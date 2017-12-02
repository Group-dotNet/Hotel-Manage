using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    public class System_DTO
    {

        public System_DTO(int id, string username, string password, int id_type)
        {
            this.Id             = id;
            this.Username = username;
            this.Password = password;
            this.Id_type = id_type;
        }


        public System_DTO(DataRow account)
        {
            this.Id = (int)account["id_account"];
            this.Username = account["username"].ToString();
            this.Password = account["password"].ToString();
            this.Id_type = (int)account["id_type"];
            this.Ban_account = (bool)account["ban_account"];
        }

        private int m_id;
        private string m_username;
        private string m_password;
        private int m_id_type;
        private bool m_ban_account;

        public int Id
        {
            get
            {
                return m_id;
            }

            set
            {
                m_id = value;
            }
        }

        public string Username
        {
            get
            {
                return m_username;
            }

            set
            {
                m_username = value;
            }
        }

        public string Password
        {
            get
            {
                return m_password;
            }

            set
            {
                m_password = value;
            }
        }

        public int Id_type
        {
            get
            {
                return m_id_type;
            }

            set
            {
                m_id_type = value;
            }
        }

        public bool Ban_account
        {
            get
            {
                return m_ban_account;
            }

            set
            {
                m_ban_account = value;
            }
        }
    }
}
