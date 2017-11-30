using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Stuff_detail_DAO
    {
        private static Stuff_detail_DAO instance;

        private Stuff_detail_DAO() { }

        internal static Stuff_detail_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Stuff_detail_DAO(); return Stuff_detail_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<Stuff_detail_DTO> Get_List(int id_type_room)
        {
            string query = "exec USP_GetListStuffDetail_Room @id_kind_of_room";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_type_room });
            List<Stuff_detail_DTO> list_stuff_detail = new List<Stuff_detail_DTO>();
            foreach (DataRow item in table.Rows)
            {
                Stuff_detail_DTO stuff_detail = new Stuff_detail_DTO(item);
                list_stuff_detail.Add(stuff_detail);
            }

            return list_stuff_detail;
        }

        public bool Get_Commit(int id_stuff, int id_kind_of_room, int number)
        {
            string query = "USP_InsertStuff_Detail @id_stuff , @id_kind_of_room , @number";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { id_stuff, id_kind_of_room, number });
            return x == 1;
        }
    }
}
