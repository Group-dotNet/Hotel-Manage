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

        public bool Change_Service(Service_ticket_DTO service_ticket)
        {
            try
            {
                return Service_ticket_DAO.Instance.Change_Service(service_ticket);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
