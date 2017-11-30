using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Kind_of_room_DAO
    {
        private static Kind_of_room_DAO instance;

        internal static Kind_of_room_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Kind_of_room_DAO(); return  Kind_of_room_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Kind_of_room_DAO() { }

        public List<Kind_of_room_DTO> Get_List()
        {
            string query = "exec USP_GetList_Kindofroom";
            DataTable table = Connect.Instance.ExecuteQuery(query);

            List<Kind_of_room_DTO> list_kind_of_room = new List<Kind_of_room_DTO>();
            foreach (DataRow item in table.Rows)
            {
                Kind_of_room_DTO kof = new Kind_of_room_DTO(item);
                list_kind_of_room.Add(kof);
            }
            return list_kind_of_room;
        }

        public bool Insert_KindofRom(Kind_of_room_DTO kor)
        {
            string query = "exec USP_InsertKindofRoom @name , @price , @people";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { kor.Name, kor.Price, kor.People });
            return x == 1;
        }

        public bool Edit_KindofRoom(Kind_of_room_DTO kor)
        {
            string query = " exec USP_UpdateKindofRoom @id , @name , @price , @people";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { kor.Id, kor.Name, kor.Price, kor.People });
            return x == 1;
        }

        public bool Del_KindofRoom(int id)
        {
            string query = "exec USP_DelKindofRoom @id";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { id });
            return x == 1;
        }

        public int GetIDKindOfRoom(int id_reservation_room)
        {
            string query = "exec USP_GetIDKindOfRoomByReservationroom @id_reservation_room";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation_room });

            foreach (DataRow item in table.Rows)
            {
                return (int)item["id_kind_of_room"];
            }
            return 0;
        }
    }
}
