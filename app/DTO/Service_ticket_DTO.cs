using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Service_ticket_DTO
    {
        private Reservation_room_DTO reservation_room = new Reservation_room_DTO();
        private Service_DTO service = new Service_DTO();
        private int number;
        private DateTime date_use;

        public Service_ticket_DTO() { }

        public Service_ticket_DTO(int id_reservation_rooom, int id_service, int number, DateTime date)
        {
            
            this.service.Id_service = id_service;
            this.number = number;
            this.Date_use = date;
        }
        public Service_ticket_DTO(DataRow service_ticket)
        {

        }


        internal Service_DTO Service
        {
            get
            {
                return service;
            }

            set
            {
                service = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public DateTime Date_use
        {
            get
            {
                return date_use;
            }

            set
            {
                date_use = value;
            }
        }

        internal Reservation_room_DTO Reservation_room
        {
            get
            {
                return reservation_room;
            }

            set
            {
                reservation_room = value;
            }
        }
    }
}
