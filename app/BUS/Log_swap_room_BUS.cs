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
    class Log_swap_room_BUS
    {
        private static Log_swap_room_BUS instance;

        internal static Log_swap_room_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Log_swap_room_BUS(); return Log_swap_room_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Log_swap_room_BUS() { }

        public List<Log_swap_room_DTO> ListRoomCancel(int id_reservation)
        {
            try
            {
                return Log_swap_room_DAO.Instance.ListRoomCancel(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool SwapRoom(int id_reservation_room, int id_room_new)
        {
            try
            {
                return Log_swap_room_DAO.Instance.SwapRoom(id_reservation_room, id_room_new);
            }
            catch(SqlException e)
            {
                throw new Exception("Error!");
            }
        }
    }
}
