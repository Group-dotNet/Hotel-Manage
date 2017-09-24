using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class System_DTO
    {

        public System_DTO(int id, string username, string password, int id_type)
        {
            this.Id             = id;
            this.Username = username;
            this.Password = password;
            this.Id_type = id_type;
        }


        private int m_id;
        private string m_username;
        private string m_password;
        private int m_id_type;

        public int Id { get => m_id; set => m_id = value; }
        public string Username { get => m_username; set => m_username = value; }
        public string Password { get => m_password; set => m_password = value; }
        public int Id_type { get => m_id_type; set => m_id_type = value; }
    }
}
