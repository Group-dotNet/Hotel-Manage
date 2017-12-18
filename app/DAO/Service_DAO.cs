using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
                if (instance == null) instance = new Service_DAO(); return Service_DAO.instance;
            }

            private set
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
            string query = "exec USP_GetInfoService @id_service";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_service });
            Service_DTO service = null;
            foreach (DataRow item in table.Rows)
            {
                service = new Service_DTO(item);
            }
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
            string query = "exec USP_GetListService";
            DataTable table = Connect.Instance.ExecuteQuery(query);
            List<Service_DTO> list_service = new List<Service_DTO>();
            foreach (DataRow item in table.Rows)
            {
                Service_DTO service = new Service_DTO(item);
                list_service.Add(service);
            }
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
            string query = "exec USP_InsertService @name_service , @price , @unit";// exec USP_InsertStuff @name = value , @price = value , @unit =value
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { service.Name_service, service.Price, service.Unit });
            return x==1;
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
        public bool Edit_Service(Service_DTO service)
        {
            string query = "exec USP_EditService @id_service , @name_service , @price , @unit";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { service.Id_service, service.Name_service, service.Price, service.Unit });
            return x == 1;
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
        public bool Del_Service(int id_service)
        {
            string query = "exec USP_DelService @id_service";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { id_service });
            return x == 1;
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
            foreach(int id in list_id)
            {
                if (this.Del_Service(id) == false)
                    return false;
            }
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
        public List<Service_DTO> Search_Service(String keyword, int type)
        {
            string query = "exec USP_SearchService @keyword , @type";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { keyword, type });
            List<Service_DTO> list_Service = new List<Service_DTO>();
            foreach (DataRow item in table.Rows)
            {
                Service_DTO service = new Service_DTO(item);
                list_Service.Add(service);
            }
            return list_Service;
        }
    }
}
