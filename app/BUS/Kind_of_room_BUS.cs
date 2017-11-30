using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Kind_of_room_BUS
    {
        private static Kind_of_room_BUS instance;

        internal static Kind_of_room_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Kind_of_room_BUS(); return Kind_of_room_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Kind_of_room_BUS() { }

        public List<Kind_of_room_DTO> Get_List()
        {
            try
            {
                return Kind_of_room_DAO.Instance.Get_List();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Insert_KindofRom(Kind_of_room_DTO kor)
        {
            try
            {
                return Kind_of_room_DAO.Instance.Insert_KindofRom(kor);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Edit_KindofRoom(Kind_of_room_DTO kor)
        {
            try
            {
                return Kind_of_room_DAO.Instance.Edit_KindofRoom(kor);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Del_KindofRoom(int id)
        {
            try
            {
                return Kind_of_room_DAO.Instance.Del_KindofRoom(id);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int GetIDKindOfRoom(int id_reservation_room)
        {
            try
            {
                return Kind_of_room_DAO.Instance.GetIDKindOfRoom(id_reservation_room);
            }
            catch(SqlException e)
            {

                throw new Exception("Error!");
            }
        }
    }
}
