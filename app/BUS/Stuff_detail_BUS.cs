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

        public bool Get_Commit(Stuff_detail_DTO stuff_detail)
        {
            try
            {
                return Stuff_detail_DAO.Instance.Get_Commit(stuff_detail);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
