using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Stuff_detail_DTO
    {

        private Stuff_DTO m_stuff = new Stuff_DTO();
        private Kind_of_room_DTO m_kind_of_room = new Kind_of_room_DTO();
        private int m_number;


        public Stuff_detail_DTO() { }

        public Stuff_detail_DTO(int id_room, int id_kind_of_room , int number)
        {
            this.Kind_of_room.Id = id_room;
            this.Stuff.Id_stuff = id_kind_of_room;
            this.Number = number;
        }

        public Stuff_detail_DTO(DataRow stuff_detail)
        {
            this.Stuff.Id_stuff = (int)stuff_detail["id_stuff"];
            this.Stuff.Name_stuff = stuff_detail["name_stuff"].ToString();
            this.Kind_of_room.Id = (int)stuff_detail["id"];
            this.Kind_of_room.Name = stuff_detail["name"].ToString();
            this.Kind_of_room.Price = (decimal)stuff_detail["price"];
            this.Kind_of_room.People = (int)stuff_detail["people"];
            this.Number = (int)stuff_detail["number"];
        }


        internal Stuff_DTO Stuff
        {
            get
            {
                return m_stuff;
            }

            set
            {
                m_stuff = value;
            }
        }

        internal Kind_of_room_DTO Kind_of_room
        {
            get
            {
                return m_kind_of_room;
            }

            set
            {
                m_kind_of_room = value;
            }
        }

        public int Number
        {
            get
            {
                return m_number;
            }

            set
            {
                m_number = value;
            }
        }
    }
}
