using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    public class Staff_DTO
    {

        public Staff_DTO() { }

        public Staff_DTO(string username, string name, bool sex, DateTime birthday, string address, string phone, string email, string image)
        {
            this.Username = username;
            this.Name = name;
            this.Sex = sex;
            this.Birthday = birthday;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Image = image;
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
            this.Image = Staff["image"].ToString();
        }

        private string m_username;
        private string m_name;
        private bool m_sex;
        private DateTime m_birthday;
        private string m_address;
        private string m_phone;
        private string m_email;
        private string m_image;

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

        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        public bool Sex
        {
            get
            {
                return m_sex;
            }

            set
            {
                m_sex = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return m_birthday;
            }

            set
            {
                m_birthday = value;
            }
        }

        public string Address
        {
            get
            {
                return m_address;
            }

            set
            {
                m_address = value;
            }
        }

        public string Phone
        {
            get
            {
                return m_phone;
            }

            set
            {
                m_phone = value;
            }
        }

        public string Email
        {
            get
            {
                return m_email;
            }

            set
            {
                m_email = value;
            }
        }

        public string Image
        {
            get
            {
                return m_image;
            }

            set
            {
                m_image = value;
            }
        }
    }
}
