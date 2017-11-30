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

        public int Insert_Reservation(Reservation_DTO reservation, DateTime end_date, List<Room_DTO> list_room)
        {
            string query = "exec USP_InsertReservation @id_customer , @is_group , @people , @username , @end_date";
            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { reservation.Customer.Id_customer, reservation.Is_group, reservation.People, reservation.Staff.Username, end_date });
            foreach (Room_DTO room in list_room)
            {
                string query_room = "exec USP_InsertReservationRoom @id_reservation , @id_room";
                Connect.Instance.ExecuteNonQuery(query_room, new object[] { x, room.Id_room });
            }
            return x;

        }

        public bool Cancel_Reservation(int id_reservation)
        {
            string query = "exec USP_CancelReservation @id_reservation";
            Connect.Instance.ExecuteNonQuery(query, new object[] { id_reservation });
            return true;
        }

        public bool CheckConfirmBillByReservation(int id_reservation)
        {
            string query = "exec USP_CheckConfirmBillByReservation @id_reservation";
            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { id_reservation });
            return x == 1;
        }


        public List<Reservation_DTO> GetListReservationByFilter(int type)
        {
            string query = "exec USP_FilterReservation @type";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { type });
            List<Reservation_DTO> list_reservation = new List<Reservation_DTO>();
            foreach (DataRow item in table.Rows)
            {
                Reservation_DTO reservation = new Reservation_DTO(item);
                list_reservation.Add(reservation);
            }
            return list_reservation;
        }

        public List<Reservation_DTO> Search_Reservation(int id_type, string keyword)
        {
            string query = "exec USP_SearchReservation @id_type , @keyword";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_type, keyword });
            List<Reservation_DTO> list_reservation = new List<Reservation_DTO>();
            foreach (DataRow item in table.Rows)
            {
                Reservation_DTO reservation = new Reservation_DTO(item);
                list_reservation.Add(reservation);
            }
            return list_reservation;
        }
    }
}
