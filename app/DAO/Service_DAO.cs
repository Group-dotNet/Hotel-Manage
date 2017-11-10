using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Service_DAO
    {
        private static Service_DAO instance;

        internal static Service_DAO Instance
        {
            get
            {
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        //@Description:
        //      Lấy ra thông tin của dịch vụ bằng id
        //@Parameter
        //    string id_Service
        //@Proc: 
        //      
        //@Return:
        //    Service_DTO  --- Trả về 1 dịch vụ
        public Service_DTO Get_Info(int id_service)
        {
            Service_DTO service = new Service_DTO();
            return service;
        }


        //@Description:
        //      Lấy ra danh sách dịch vụ trong bảng
        //@Parameter
        //    nope
        //@Proc: 
        //      
        //@Return:
        //    List<Service_DTO>  --- Trả về 1 danh sách các dịch vụ
        public List<Service_DTO> Get_List()
        {
            List<Service_DTO> list_service = new List<Service_DTO>();
            return list_service;
        }


        //@Description:
        //      Thêm vào 1 dịch vụ
        //@Parameter
        //    Service_DTO Service  --------Tham số nhập là 1 dịch vụ
        //@Proc: 
        //      
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Add_Service(Service_DTO service)
        {
            return true;
        }


        //@Description:
        //      Chỉnh sửa 1 dịch vụ bằng id
        //@Parameter
        //    Service_DTO Service  --------Tham số nhập là 1 dịch vụ
        //    int id           -------- Mã dịch vụ     
        //@Proc: 
        //      
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Edit_Service(Service_DTO service, int id)
        {
            return true;
        }



        //@Description:
        //     Xóa 1 dịch vụ bằng id
        //@Parameter
        //    Service_DTO Service  --------Tham số nhập là 1 dịch vụ
        //    int id           -------- Mã dịch vụ     
        //@Proc: 
        //      
        //@Return:
        //   boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Del_Service(int id)
        {
            return true;
        }


        //@Description:
        //     Xóa nhiều dịch vụ bằng danh sách id
        //@Parameter
        //    List<int> list_id  --------Tham số nhập là 1 danh sách mã dịch vụ
        //@Proc: 
        //      
        //@Call:
        //    this.Del_Service(int id)
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Del_Mul_Service(List<int> list_id)
        {
            return true;
        }


        //@Description:
        //     Tìm kiếm dịch vụ
        //@Parameter
        //    String keyword 
        //    int type_search   ------- tìm kiếm theo mã hay tên, (bên dưới là chú thích loại tìm kiếm)
        //@Proc: 
        //      
        //@Call:
        //    this.Del_Service(int id)
        //@Return:
        //    List<Service_DTO>   ------------ Trả về danh sách thỏa mãn
        public List<Service_DTO> Search_Service(String keyword, int type_search)
        {
            List<Service_DTO> list_Service = new List<Service_DTO>();
            return list_Service;
        }
    }
}
