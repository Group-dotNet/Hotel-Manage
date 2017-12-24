using app.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Other_BUS
    {
    }

    class History_BUS
    {
        private static History_BUS instance;

        internal static History_BUS Instance
        {
            get
            {
                if (instance == null) instance = new History_BUS(); return History_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private History_BUS() { }

        public bool Insert_History(string username, string content)
        {
            try
            {
                return History_DAO.Instance.Insert_History(username, content);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
        public List<DTO.History_DTO> Get_List_History(DateTime date)
        {
            try
            {
                return History_DAO.Instance.Get_List_History(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }

    class Message_BUS
    {
        private static Message_BUS instance;

        internal static Message_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Message_BUS(); return Message_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Message_BUS() { }

        public bool Insert_Message(string content)
        {
            try
            {
                return Message_DAO.Instance.Insert_Message(content);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<DTO.Message_DTO> Get_List_Message(DateTime date)
        {
            try
            {
                return Message_DAO.Instance.Get_List_Message(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Checked_Message()
        {
            try
            {
                return Message_DAO.Instance.Checked_Message();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Check_Reservation()
        {
            try
            {
                return Message_DAO.Instance.Check_Reservation();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
