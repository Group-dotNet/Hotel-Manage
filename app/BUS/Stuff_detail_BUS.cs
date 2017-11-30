using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Stuff_detail_BUS
    {
        private static Stuff_detail_BUS instance;

        internal static Stuff_detail_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Stuff_detail_BUS(); return Stuff_detail_BUS.instance;
            }

            private set
            {
                instance = value;
            }

        }

        private Stuff_detail_BUS() { }


        public List<Stuff_detail_DTO> Get_List(int id_type_room)
        {
            try
            {
                return Stuff_detail_DAO.Instance.Get_List(id_type_room);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Get_Commit(int id_stuff, int id_kind_of_room, int number)
        {
            try
            {
                return Stuff_detail_DAO.Instance.Get_Commit(id_stuff, id_kind_of_room, number);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
