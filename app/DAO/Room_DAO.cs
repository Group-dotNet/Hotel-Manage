using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Room_DAO
    {
        private static Room_DAO instance;

        internal static Room_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Room_DAO(); return instance;
            }

           private set
            {
                instance = value;
            }
        }


        //public static double RoomWidth = 50;
        //public static double RoomHeight = 50;

        private Room_DAO() { }

        public List<Room_DTO> Get_List_Room_Floor(int floor)
        {
            string query = "exec USP_Get_ListRoom_Floor @floor";
            DataTable room_floor =  Connect.Instance.ExecuteQuery(query, new object[] { floor });

            List<Room_DTO> list_room = new List<Room_DTO>();
            foreach(DataRow item in room_floor.Rows)
            {
                Room_DTO room = new Room_DTO(item);
                list_room.Add(room);
            }

            return list_room;
        }


        public int Get_Max_Floor()
        {
            string query = "exec USP_GetMaxFloor";
            int x = (int)Connect.Instance.ExecuteScalar(query);
            return x;
        }


        public bool Check_Exists_Room(int floor, int order)
        {
            string query = "exec USP_CheckExistsRoom @num_floor , @num_order";
            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { floor, order });
            return x == 0;
        }

        public bool Insert_Room(int floor, int order, int id_type, string username)
        {
            string query = "exec USP_InsertRoom @num_floor , @num_order , @id_kind_of_room , @staff";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { floor, order, id_type, username });
            return x == 1;
        }

        public bool Edit_Room(int id_room, int id_type, string username)
        {
            string query = "exec USP_EditeRoom @id_room , @id_type , @staff";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { id_room, id_type, username });
            return x == 1;
        }

        public bool Del_Room(int id_room)
        {
            string query = "exec USP_DeleteRoom @id_room";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { id_room });
            return x == 1;
        }

        public Room_DTO Get_Info_Room(int id_room)
        {
            string query = "exec USP_GetInfoRoom @id_room";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_room });

            Room_DTO room = null;
            foreach (DataRow item in table.Rows)
            {
                room = new Room_DTO(item);
            }
            return room;
        }
    }
}
