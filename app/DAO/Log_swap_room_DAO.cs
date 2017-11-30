using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Log_swap_room_DAO
    {
        private static Log_swap_room_DAO instance;

        internal static Log_swap_room_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Log_swap_room_DAO(); return Log_swap_room_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Log_swap_room_DAO() { }


        public List<Log_swap_room_DTO> ListRoomCancel(int id_reservation)
        {
            string query = "exec USP_GetListRoomCancelByReservation @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            List<Log_swap_room_DTO> list_log_swap_room = new List<Log_swap_room_DTO>();
            foreach(DataRow item in table.Rows)
            {
                Log_swap_room_DTO log = new Log_swap_room_DTO();
                log.Id_log = (int)item["id_log"];
                log.Reservation_room.Id_reservation_room = (int)item["id_reservation_room"];
                log.Reservation_room.Room.Id_room = (int)item["id_room"];
                log.Reservation_room.Reservation.Id_reservation = (int)item["id_reservation"];
                log.Id_room_new.Id_room = (int)item["id_room_new"];
                log.Select_record = (bool)item["select_record"];
                log.Created = (DateTime)item["created"];
                list_log_swap_room.Add(log);
            }
            return list_log_swap_room;
        }

        public bool SwapRoom(int id_reservation_room, int id_room_new)
        {
            string query = "exec USP_InsertSwapRoom @id_reservation_room , @id_new_room";
            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { id_reservation_room, id_room_new });
            return x == 1;
        }
    }
}
