using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Service_ticket_DAO
    {

        private static Service_ticket_DAO instance;

        internal static Service_ticket_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Service_ticket_DAO(); return Service_ticket_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Service_ticket_DAO() { }


        public bool Change_Service(Service_ticket_DTO  service_ticket)
        {
            string query = "exec USP_InsertServiceTikcket @id_reservation , @id_room , @id_service , @number , @date_use";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] {});
            return x == 1;
        }

        /// <summary>
        /// Lấy ra các dịch vụ trong 1 phòng
        /// </summary>
        /// <param name="id_room"> mã phòng</param>
        /// <returns>Danh sách các dịch vu</returns>
        public List<Service_ticket_DTO> Get_ListService(int id_room)
        {
            string query = "exec USP_Get_ListServiceTicket_Room @id_room";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_room });
            List<Service_ticket_DTO> list_service_ticket = new List<Service_ticket_DTO>();
            foreach (DataRow item in table.Rows)
            {
                Service_ticket_DTO service_ticket = new Service_ticket_DTO();


                list_service_ticket.Add(service_ticket);
            }

            return list_service_ticket;
        }

        public List<Service_ticket_DTO> Get_ListServiceReservation(int id_reservation)
        {
            string query = "exec USP_GetListServiceReservation @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            List<Service_ticket_DTO> list_service_reservation = new List<Service_ticket_DTO>();
            foreach (DataRow item in table.Rows)
            {
                Service_ticket_DTO service = new Service_ticket_DTO();
                service.Reservation_room.Id_reservation_room = (int)item["id_reservation_room"];
                service.Reservation_room.Room.Id_room = (int)item["id_room"];
                service.Service.Id_service = (int)item["id_service"];
                service.Service.Name_service = item["name_service"].ToString();
                service.Service.Price = (decimal)item["price"];
                service.Number = (int)item["number"];
                service.Date_use = (DateTime)item["date_use"];
                list_service_reservation.Add(service);
            }
            return list_service_reservation;
        }
    }
}
