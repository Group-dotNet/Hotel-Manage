using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Staff_DTO
    {

        public Staff_DTO(string username, string name, bool sex, DateTime birthday, string address, string phone, string email)
        {
            this.Username = username;
            this.Name = name;
            this.Sex = sex;
            this.Birthday = birthday;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
        }

        public Staff_DTO(DataRow Staff)
        {
            this.Username = Staff["username"].ToString();
            this.Name = Staff["displayname"].ToString();
            this.Sex = (bool)Staff["sex"];
            this.Birthday = (DateTime)Staff["birthday"];
            this.Address = Staff["address"].ToString();
            this.Phone = Staff["phone"].ToString();
            this.Email = Staff["email"].ToString();
        }

        private string m_username;
        private string m_name;
        private bool m_sex;
        private DateTime m_birthday;
        private string m_address;
        private string m_phone;
        private string m_email;

        public string Username { get => m_username; set => m_username = value; }
        public string Name { get => m_name; set => m_name = value; }
        public bool Sex { get => m_sex; set => m_sex = value; }
        public DateTime Birthday { get => m_birthday; set => m_birthday = value; }
        public string Address { get => m_address; set => m_address = value; }
        public string Phone { get => m_phone; set => m_phone = value; }
        public string Email { get => m_email; set => m_email = value; }
    }
}
