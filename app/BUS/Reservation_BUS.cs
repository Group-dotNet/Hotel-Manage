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
    class Reservation_BUS
    {
        private static Reservation_BUS instance;

        internal static Reservation_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Reservation_BUS(); return Reservation_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }
        private Reservation_BUS() { }

        public List<Reservation_DTO> GetListReservation()
        {
            try
            {
                return Reservation_DAO.Instance.GetListReservation();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
        public Reservation_DTO GetInfoReservation(int id_reservation)
        {
            try
            {
                return Reservation_DAO.Instance.GetInfoReservation(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int Insert_Reservation(Reservation_DTO reservation, DateTime end_date, List<Room_DTO> list_room)
        {
            try
            {
                return Reservation_DAO.Instance.Insert_Reservation(reservation, end_date, list_room);
            }
            catch
            {
                return 0;
            }
        }


        public bool Cancel_Reservation(int id_reservation)
        {
            try
            {
                return Reservation_DAO.Instance.Cancel_Reservation(id_reservation);
            }
            catch
            {
                return false;
            }
        }

        public bool CheckConfirmBillByReservation(int id_reservation)
        {
            try
            {
                return Reservation_DAO.Instance.CheckConfirmBillByReservation(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<Reservation_DTO> GetListReservationByFilter(int type)
        {
            try
            {
                return Reservation_DAO.Instance.GetListReservationByFilter(type);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<Reservation_DTO> Search_Reservation(int id_type, string keyword)
        {
            try
            {
                return Reservation_DAO.Instance.Search_Reservation(id_type, keyword);
            }
            catch(SqlException e)
            {
                throw new Exception("Error!");
            }
        }
    }
}
