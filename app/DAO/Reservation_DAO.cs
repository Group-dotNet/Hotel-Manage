using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Reservation_DAO
    {
        private static Reservation_DAO instance;

        internal static Reservation_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Reservation_DAO();  return Reservation_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Reservation_DAO() { }

        public List<Reservation_DTO> GetListReservation()
        {
            string query = "exec USP_GetListReservation";
            DataTable table = Connect.Instance.ExecuteQuery(query);
            List<Reservation_DTO> list_reservation = new List<Reservation_DTO>();
            foreach(DataRow item in table.Rows)
            {
                Reservation_DTO reservation = new Reservation_DTO(item);
                list_reservation.Add(reservation);
            }
            return list_reservation;
        }

        public Reservation_DTO GetInfoReservation(int id_reservation)
        {
            string query = "exec USP_GetInfoReservation @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            Reservation_DTO reservation = new Reservation_DTO();
            foreach (DataRow item in table.Rows)
            {
                reservation.Id_reservation = (int)item["id_reservation"];
                reservation.Customer.Id_customer = (int)item["id_customer"];
                reservation.Customer.Name = item["name"].ToString();
                reservation.Is_group = (bool)item["is_group"];
                reservation.People = (int)item["people"];
                reservation.Staff.Username = item["username"].ToString();
                reservation.Status_reservation = (int)item["status_reservation"];
            }
            return reservation;
        }

       
    }
}
