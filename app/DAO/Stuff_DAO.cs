using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Stuff_DAO
    {
        private static Stuff_DAO instance;

        internal static Stuff_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Stuff_DAO(); return Stuff_DAO.instance;
             }

            private set
            {
                instance = value;
            }
        }

        private Stuff_DAO() { }

        //@Description:
        //      Lấy ra thông tin của vật tư bằng id
        //@Parameter
        //    string id_stuff
        //@Proc: 
        //      
        //@Return:
        //    Stuff_DTO  --- Trả về 1 vật tư
        public Stuff_DTO Get_Info(int id_stuff)
        {
            Stuff_DTO stuff = new Stuff_DTO();
            return stuff;
        }


        //@Description:
        //      Lấy ra danh sách vật tư trong bảng
        //@Parameter
        //    nope
        //@Proc: 
        //      
        //@Return:
        //    List<Stuff_DTO>  --- Trả về 1 danh sách các vật tư
        public List<Stuff_DTO> Get_List()
        {
            List<Stuff_DTO> list_stuff = new List<Stuff_DTO>();
            return list_stuff;
        }


        //@Description:
        //      Thêm vào 1 vật tư
        //@Parameter
        //    Stuff_DTO stuff  --------Tham số nhập là 1 vật tư
        //@Proc: 
        //      
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Add_Stuff(Stuff_DTO stuff)
        {
            return true;
        }


        //@Description:
        //      Chỉnh sửa 1 vật tư bằng id
        //@Parameter
        //    Stuff_DTO stuff  --------Tham số nhập là 1 vật tư
        //    int id           -------- Mã vật tư     
        //@Proc: 
        //      
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Edit_Stuff(Stuff_DTO stuff, int id)
        {
            return true;
        }



        //@Description:
        //     Xóa 1 vật tư bằng id
        //@Parameter
        //    Stuff_DTO stuff  --------Tham số nhập là 1 vật tư
        //    int id           -------- Mã vật tư     
        //@Proc: 
        //      
        //@Return:
        //   boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Del_Stuff(int id)
        {
            return true;
        }


        //@Description:
        //     Xóa nhiều vật tư bằng danh sách id
        //@Parameter
        //    List<int> list_id  --------Tham số nhập là 1 danh sách mã vật tư
        //@Proc: 
        //      
        //@Call:
        //    this.Del_Stuff(int id)
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Del_Mul_Stuff(List<int> list_id)
        {
            return true;
        }


        //@Description:
        //     Tìm kiếm vật tư
        //@Parameter
        //    String keyword 
        //    int type_search   ------- tìm kiếm theo mã hay tên, (bên dưới là chú thích loại tìm kiếm)
        //@Proc: 
        //      
        //@Call:
        //    this.Del_Stuff(int id)
        //@Return:
        //    List<Stuff_DTO>   ------------ Trả về danh sách thỏa mãn
        public List<Stuff_DTO> Search_Stuff(String keyword, int type_search)
        {
            List<Stuff_DTO> list_stuff = new List<Stuff_DTO>();
            return list_stuff;
        }
    }
}
