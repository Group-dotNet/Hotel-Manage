using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Service_ticket_BUS
    {
        private static Service_ticket_BUS instance;

        internal static Service_ticket_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Service_ticket_BUS(); return Service_ticket_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Service_ticket_BUS() { }

        public List<Service_ticket_DTO> Get_ListService(int id_room)
        {
            try
            {
                return Service_ticket_DAO.Instance.Get_ListService(id_room);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Change_Service(int id_room, int id_service, int number, DateTime date_use)
        {
            try
            {
                return Service_ticket_DAO.Instance.Change_Service(id_room, id_service, number, date_use);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<Service_ticket_DTO> Get_ListServiceReservation(int id_reservation)
        {
            try
            {
                return Service_ticket_DAO.Instance.Get_ListServiceReservation(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
