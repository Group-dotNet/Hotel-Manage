using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Stuff_BUS
    {

        private static Stuff_BUS instance;

        internal static Stuff_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Stuff_BUS(); return Stuff_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Stuff_BUS() { }

        //@Description:
        //    Bắt lỗi try - catch trong hàm lấy thông vật tư
        //@Parameter
        //    string id_stuff
        //@Proc: 
        //      
        //@Call:
        //    Stuff_DAO.Get_Info(int id_stuff)
        //@Return:
        //    Stuff_DTO  --- Trả về 1 vật tư
        public Stuff_DTO Get_Info(int id_stuff)
        {
            try
            {
                return Stuff_DAO.Instance.Get_Info(id_stuff);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //      Bắt lỗi hàm Lấy ra danh sách vật tư trong bảng
        //@Parameter
        //    nope
        //@Proc: 
        //      
        //@Call:
        //     Stuff_DAO.Instance.Get_List();
        //@Return:
        //    List<Stuff_DTO>  --- Trả về 1 danh sách các vật tư
        public List<Stuff_DTO> Get_List()
        {
            try
            {
                return Stuff_DAO.Instance.List_Stuff();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //      Bắt lỗi hàm Thêm vào 1 vật tư
        //@Parameter
        //    Stuff_DTO stuff  --------Tham số nhập là 1 vật tư
        //@Proc: 
        //      
        //@Call: 
        //    Stuff_DAO.Instance.Add_Stuff(stuff);
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Add_Stuff(Stuff_DTO stuff)
        {
            try
            {
                return Stuff_DAO.Instance.Add_Stuff(stuff);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //      Bắt lỗi hàm Chỉnh sửa 1 vật tư bằng id
        //@Parameter
        //    Stuff_DTO stuff  --------Tham số nhập là 1 vật tư
        //      
        //@Proc: 
        //      
        //@Call:
        //    Stuff_DAO.Instance.Edit_Stuff(stuff, id);
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Edit_Stuff(Stuff_DTO stuff)
        {
            try
            {
                return Stuff_DAO.Instance.Edit_Stuff(stuff);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }



        //@Description:
        //     Bắt lỗi hàm  Xóa 1 vật tư bằng id
        //@Parameter
        //    Stuff_DTO stuff  --------Tham số nhập là 1 vật tư
        //    int id           -------- Mã vật tư     
        //@Proc: 
        //      
        //@Call:
        //     Stuff_DAO.Instance.Del_Stuff(id);
        //@Return:
        //   boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Del_Stuff(int id)
        {
            try
            {
                return Stuff_DAO.Instance.Del_Stuff(id);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //     Bắt lỗi hàm  Xóa nhiều vật tư bằng danh sách id
        //@Parameter
        //    List<int> list_id  --------Tham số nhập là 1 danh sách mã vật tư
        //@Proc: 
        //      
        //@Call:
        //    Stuff_DAO.Instance.Del_Mul_Stuff(list_id);
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Del_Mul_Stuff(List<int> list_id)
        {
            try
            {
                return Stuff_DAO.Instance.Del_Mul_Stuff(list_id);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //     Bắt lỗi hàm Tìm kiếm vật tư
        //@Parameter
        //    String keyword 
        //    int type_search   ------- tìm kiếm theo mã hay tên, (bên dưới là chú thích loại tìm kiếm)
        //@Proc: 
        //      
        //@Call:
        //    Stuff_DAO.Instance.Search_Stuff(keyword, type_search);
        //@Return:
        //    List<Stuff_DTO>   ------------ Trả về danh sách thỏa mãn
        public List<Stuff_DTO> Search_Stuff(String keyword, int type_search)
        {
            try
            {
                return Stuff_DAO.Instance.Search_Stuff(keyword, type_search);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
