using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Room_BUS
    {
        private static Room_BUS instance;

        internal static Room_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Room_BUS(); return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Room_BUS() { }

        public List<Room_DTO> Get_List_Room_Floor(int floor)
        {
            try
            {
                return Room_DAO.Instance.Get_List_Room_Floor(floor);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int Get_Max_Floor()
        {
            try
            {
                return Room_DAO.Instance.Get_Max_Floor();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Check_Exists_Room(int floor, int order)
        {
            try
            {
                return Room_DAO.Instance.Check_Exists_Room(floor, order);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Insert_Room(int floor, int order, int id_type, string username)
        {
            try
            {
                return Room_DAO.Instance.Insert_Room(floor, order, id_type, username);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Edit_Room(int id_room, int id_type, string username)
        {
            try
            {
                return Room_DAO.Instance.Edit_Room(id_room, id_type, username);
            }
            catch
            {
                return false;
            }
        }

        public bool Del_Room(int id_room)
        {
            try
            {
                return Room_DAO.Instance.Del_Room(id_room);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        public Room_DTO Get_Info_Room(int id_room)
        {
            try
            {
                return Room_DAO.Instance.Get_Info_Room(id_room);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
