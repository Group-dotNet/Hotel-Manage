using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public Stuff_DTO Get_Info(int id_stuff) //Xong
        {
            string query = "exec USP_GetInfoStuff @id_stuff";

            //Đổ dữ liệu và 1 bảng có sẵn trong hệ thống tên là "DataTable"
            DataTable Stuff_info = Connect.Instance.ExecuteQuery(query, new object[] { id_stuff });

            Stuff_DTO stuff = null;

            // Đỗi tượng DataRow là từng dòng trong đối tượng DataTable 
            // (Có thể bỏ vòng lặp này do số lượng dòng ta cấn truy xuất bằng 1 hoặc 0)
            foreach (DataRow item in Stuff_info.Rows)
            {
                stuff = new Stuff_DTO((int)item["id_stuff"], item["name_stuff"].ToString());// Do trong file StuffDTO không có hàm DataRow, mình sử dụng hàn int id_stuff, string name
            }

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
        public List<Stuff_DTO> List_Stuff() // Xong
        {
            string query = "exec USP_GetListStuff";
            DataTable List_stuff = Connect.Instance.ExecuteQuery(query);

            List<Stuff_DTO> list_stuff = new List<Stuff_DTO>();
            foreach (DataRow item in List_stuff.Rows)
            {
                Stuff_DTO stuff = new Stuff_DTO((int)item["id_stuff"], item["name_stuff"].ToString());
                list_stuff.Add(stuff);
            }
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
        public bool Add_Stuff(Stuff_DTO stuff)  //Xong
        {
            string query = "exec USP_InsertStuff @name"; // cậu để ý coi video bài số 5, 
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { stuff.Name_stuff });
            return x == 1;
        }


        //@Description:
        //      Chỉnh sửa 1 vật tư bằng id
        //@Parameter
        //    Stuff_DTO stuff  --------Tham số nhập là 1 vật tư
        //     
        //@Proc: 
        //      
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Edit_Stuff(Stuff_DTO stuff) // Xong
        {
            string query = "exec USP_UpdateStuff @id_stuff , @name"; // viết theo thứ tự trong sql đúng tên. phân các 2 biến bằng " , " chú ý 2 dấu cách 2 bên dấu phẩy
            int record = Connect.Instance.ExecuteNonQuery(query, new object[] { stuff.Id_stuff, stuff.Name_stuff });

            return record == 1;
        }



        //@Description:
        //     Xóa 1 vật tư bằng id
        //@Parameter
        //    Stuff_DTO stuff  --------Tham số nhập là 1 vật tư
        //
        //@Proc: 
        //      
        //@Return:
        //   boolean  ------------Thành công trả về true, thất bại trả về false;
        // không có nghĩa xóa vật tư
        public bool Del_Stuff(int id)//xxong
        {
            string query = "exec USP_LockStuff @id_stuff"; //-- cái @id sửa thành @id_stuff gioongstrong database
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { id });// cái id này ssatwj sao cung duoc
            return x == 1;
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
        public bool Del_Mul_Stuff(List<int> list_id)// xong
        {
            foreach(int id in list_id)
            {
                if (this.Del_Stuff(id) == false)
                    return false;

            }
            return true;
            // cái này viết sai rùi.
            //Phải viết vongloapwj foreach cho cái list_id, sau đó mới gọi this.Del_stuff

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
        public List<Stuff_DTO> Search_Stuff(String keyword, int type_search) // viet tiep
        {
            //cái này chưa xong?

            string query = "exec USP_SearchStuff  @keyword , @type";
            DataTable List_stuff = Connect.Instance.ExecuteQuery(query, new object[] { keyword, type_search });

            List<Stuff_DTO> list_stuff = new List<Stuff_DTO>();
            foreach (DataRow item in List_stuff.Rows)
            {
                Stuff_DTO stuff = new Stuff_DTO((int)item["id_stuff"], item["name_stuff"].ToString());
                list_stuff.Add(stuff);
            }
            return list_stuff;
        }
    }
}
