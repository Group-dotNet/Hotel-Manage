using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
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

       
    }
}
