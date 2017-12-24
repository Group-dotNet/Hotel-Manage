using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Other_DAO
    {
    }

    class History_DAO
    {
        private static History_DAO instance;

        internal static History_DAO Instance
        {
            get
            {
                if (instance == null) instance = new History_DAO(); return History_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private History_DAO() { }

        public bool Insert_History(string username, string content)
        {
            string query = "exec Insert_History_System @username , @content";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { username, content });
            return x == 1;
        }

        public List<DTO.History_DTO> Get_List_History(DateTime date)
        {
            string query = "exec GetListHistoryByDay @date";
            List<DTO.History_DTO> list_history = new List<DTO.History_DTO>();
            System.Data.DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { date });
            foreach (System.Data.DataRow item in table.Rows)
            {
                DTO.History_DTO history = new DTO.History_DTO(item);
                list_history.Add(history);
            }
            return list_history;
        }
    }

    class Message_DAO
    {
        private static Message_DAO instance;

        internal static Message_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Message_DAO(); return Message_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Message_DAO() { }

        public bool Insert_Message(string content)
        {
            string query = "exec Insert_Message_System  @content";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { content });
            return x == 1;
        }

        public List<DTO.Message_DTO> Get_List_Message(DateTime date)
        {
            string query = "exec GetListMessageByDay @date";
            List<DTO.Message_DTO> list_message = new List<DTO.Message_DTO>();
            System.Data.DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { date });
            foreach (System.Data.DataRow item in table.Rows)
            {
                DTO.Message_DTO message = new DTO.Message_DTO(item);
                list_message.Add(message);
            }
            return list_message;
        }

        public bool Checked_Message()
        {
            string query = "exec Udpate_Message";
            Connect.Instance.ExecuteNonQuery(query);
            return true;
        }

        public bool Check_Reservation()
        {
            string query = "exec Check_Reservation";
            int x = (int)Connect.Instance.ExecuteOutPut(query);
            if (x == 1) return true;
            else return false;
        }
    }
}
