using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Reservation_room_BUS
    {
        private static Reservation_room_BUS instance;

        internal static Reservation_room_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Reservation_room_BUS(); return Reservation_room_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Reservation_room_BUS() { }

        public List<Reservation_room_DTO> Get_ListReservation_Using(int id_reservation)
        {
            try
            {
                return Reservation_room_DAO.Instance.Get_ListReservation_Using(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<Reservation_room_DTO> GetListHistoryRoom(int id_reservation)
        {
            try
            {
                return Reservation_room_DAO.Instance.GetListHistoryRoom(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public Reservation_room_DTO GetInfoReservationRoom(int id_room)
        {
            try
            {
                return Reservation_room_DAO.Instance.GetInfoReservationRoom(id_room);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int Count_Room_Using_In_Reservation(int id_reservation)
        {
            try
            {
                return Reservation_room_DAO.Instance.Count_Room_Using_In_Reservation(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
