using app.DTO;
using System;
using System.Collections.Generic;
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

        
    }
}
