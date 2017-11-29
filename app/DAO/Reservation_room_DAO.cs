using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Reservation_room_DAO
    {
        private static Reservation_room_DAO instance;

        internal static Reservation_room_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Reservation_room_DAO();  return Reservation_room_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }


        private Reservation_room_DAO() { }

        public List<Reservation_room_DTO> Get_ListReservation_Using(int id_reservation)
        {
            string query = "exec USP_GetListReservationRoomUsing @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            List<Reservation_room_DTO> list_reservation_using = new List<Reservation_room_DTO>();
            foreach(DataRow item in table.Rows)
            {
                Reservation_room_DTO reservation_room = new Reservation_room_DTO();
                reservation_room.Id_reservation_room = (int)item["id_reservation_room"];
                reservation_room.Room.Id_room = (int)item["id_room"];
                reservation_room.Room.Num_floor = (int)item["num_floor"];
                reservation_room.Room.Num_order = (int)item["num_order"];
                reservation_room.Room.Kind_of_room.Name = item["name"].ToString();
                reservation_room.Room.Kind_of_room.People = (int)item["people"];
                reservation_room.Room.Kind_of_room.Price = (decimal)item["price"];
                list_reservation_using.Add(reservation_room);
            }
            return list_reservation_using;
        }

        public List<Reservation_room_DTO> GetListHistoryRoom(int id_reservation)
        {
            string query = "exec USP_GetHistory @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            List<Reservation_room_DTO> list_reservation_room = new List<Reservation_room_DTO>();
            foreach(DataRow item in table.Rows)
            {
                Reservation_room_DTO reservation_room = new Reservation_room_DTO();
                reservation_room.Id_reservation_room = (int)item["id_reservation"];
                reservation_room.Reservation.Id_reservation = (int)item["id_reservation"];
                reservation_room.Room.Id_room = (int)item["id_room"];
                reservation_room.Room.Num_floor = (int)item["num_floor"];
                reservation_room.Room.Num_order = (int)item["num_order"];
                reservation_room.Using = (int)item["using"];
                list_reservation_room.Add(reservation_room);
            }
            return list_reservation_room;
        }

        public Reservation_room_DTO GetInfoReservationRoom(int id_room)
        {
            string query = "exec USP_GetInfoReservationRoom @id_room";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_room });
            Reservation_room_DTO reservation_room = new Reservation_room_DTO();
            foreach(DataRow item in table.Rows)
            {
                reservation_room.Reservation.Id_reservation = (int)item["id_reservation"];
            }
            return reservation_room;

        }
    }
}
