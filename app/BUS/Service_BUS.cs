using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Service_BUS
    {
        private static Service_BUS instance;

        internal static Service_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Service_BUS(); return Service_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Service_BUS() { }

        //@Description:
        //      Bắt lỗi hàm Lấy ra thông tin của dịch vụ bằng id
        //@Parameter
        //    string id_Service
        //@Proc: 
        //      
        //@Call:
        //      Service_DAO.Instance.Get_Info(id_service);
        //@Return:
        //    Service_DTO  --- Trả về 1 dịch vụ
        public Service_DTO Get_Info(int id_service)
        {
            try
            {
                return Service_DAO.Instance.Get_Info(id_service);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //      Bắt lỗi hàm Lấy ra danh sách dịch vụ trong bảng
        //@Parameter
        //    nope
        //@Proc: 
        //      
        //@Call:
        //       Service_DAO.Instance.Get_Info(id_service);
        //@Return:
        //    List<Service_DTO>  --- Trả về 1 danh sách các dịch vụ
        public List<Service_DTO> Get_List()
        {
            try
            {
                return Service_DAO.Instance.Get_List();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //      Bắt lỗi hàm Thêm vào 1 dịch vụ
        //@Parameter
        //    Service_DTO Service  --------Tham số nhập là 1 dịch vụ
        //@Proc: 
        //      
        //@Call:
        //      Service_DAO.Instance.Add_Service(service);
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Add_Service(Service_DTO service)
        {
            try
            {
                return Service_DAO.Instance.Add_Service(service);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //      Bắt lỗi hàm Chỉnh sửa 1 dịch vụ bằng id
        //@Parameter
        //    Service_DTO Service  --------Tham số nhập là 1 dịch vụ
        //    int id           -------- Mã dịch vụ     
        //@Proc: 
        //      
        //@Call:
        //      Service_DAO.Instance.Edit_Service(service, id);
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Edit_Service(Service_DTO service)
        {
            try
            {
                return Service_DAO.Instance.Edit_Service(service);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }



        //@Description:
        //     Bắt lỗi hàm Xóa 1 dịch vụ bằng id
        //@Parameter
        //    Service_DTO Service  --------Tham số nhập là 1 dịch vụ
        //    int id           -------- Mã dịch vụ     
        //@Proc: 
        //      
        //@Call:
        //      Service_DAO.Instance.Del_Service(id);
        //@Return:
        //   boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Del_Service(int id)
        {
            try
            {
                return Service_DAO.Instance.Del_Service(id);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //    Bắt lỗi hàm  Xóa nhiều dịch vụ bằng danh sách id
        //@Parameter
        //    List<int> list_id  --------Tham số nhập là 1 danh sách mã dịch vụ
        //@Proc: 
        //      
        //@Call:
        //    Service_DAO.Instance.Del_Mul_Service(list_id);
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Del_Mul_Service(List<int> list_id)
        {
            try
            {
                return Service_DAO.Instance.Del_Mul_Service(list_id);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //     Bắt lỗi hàm Tìm kiếm dịch vụ
        //@Parameter
        //    String keyword 
        //    int type_search   ------- tìm kiếm theo mã hay tên, (bên dưới là chú thích loại tìm kiếm)
        //@Proc: 
        //      
        //@Call:
        //    Service_DAO.Instance.Del_Mul_Service(list_id);
        //@Return:
        //    List<Service_DTO>   ------------ Trả về danh sách thỏa mãn
        public List<Service_DTO> Search_Service(String keyword, int type_search)
        {
            try
            {
                return Service_DAO.Instance.Search_Service(keyword, type_search);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
