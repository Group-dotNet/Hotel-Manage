using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Other_DTO
    {

    }

    class Message_DTO
    {
        private int id_message;
        private int id_reservation;
        private string content;
        private DateTime created;
        private bool m_checked;

        public Message_DTO(System.Data.DataRow message)
        {
            this.id_message = (int)message["id_message"];
            this.id_reservation = (int)message["id_reservation"];
            this.content = message["content"].ToString();
            this.created = (DateTime)message["created"];
            this.m_checked = (bool)message["checked"];
        }

        public Message_DTO() { }

        public int Id_message
        {
            get
            {
                return id_message;
            }

            set
            {
                id_message = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public DateTime Created
        {
            get
            {
                return created;
            }

            set
            {
                created = value;
            }
        }

        public int Id_reservation
        {
            get
            {
                return id_reservation;
            }

            set
            {
                id_reservation = value;
            }
        }

        public bool Checked
        {
            get
            {
                return m_checked;
            }

            set
            {
                m_checked = value;
            }
        }
    }

    class History_DTO
    {
        private int id_history;
        private string username;
        private string content;
        private DateTime created;

        public History_DTO(System.Data.DataRow history)
        {
            this.id_history = (int)history["id_history"];
            this.username = history["username"].ToString();
            this.content = history["content"].ToString();
            this.created = (DateTime)history["created"];
        }

        public History_DTO() { }

        public int Id_history
        {
            get
            {
                return id_history;
            }

            set
            {
                id_history = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public DateTime Created
        {
            get
            {
                return created;
            }

            set
            {
                created = value;
            }
        }
    }
}
