using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Customer_DAO
    {
        private static Customer_DAO instance;

        internal static Customer_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Customer_DAO(); return Customer_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Customer_DAO() { }

        //@Description:
        //      Lấy ra thông tin của khách hàng bằng id
        //@Parameter
        //    string id_customer
        //@Proc: 
        //      
        //@Return:
        //    Customer_DTO  --- Trả về 1 khách hàng
        public Customer_DTO Get_Info(int id_customer)
        {
            Customer_DTO customer = new Customer_DTO();
            return customer;
        }


        //@Description:
        //      Lấy ra danh sách khách hàng trong bảng
        //@Parameter
        //    nope
        //@Proc: 
        //      
        //@Return:
        //    List<Customer_DTO>  --- Trả về 1 danh sách các khách hàng
        public List<Customer_DTO> Get_List()
        {
            List<Customer_DTO> list_customer = new List<Customer_DTO>();
            return list_customer;
        }


        //@Description:
        //      Thêm vào 1 Khách hàng
        //@Parameter
        //    Customer_DTO customer  --------Tham số nhập là 1 Khách hàng
        //@Proc: 
        //      
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Add_Customer(Customer_DTO customer)
        {
            return true;
        }


        //@Description:
        //      Chỉnh sửa 1 khách hàng bằng id
        //@Parameter
        //    Customer_DTO customer  --------Tham số nhập là 1 Khách hàng
        //    int id                  -------- Mã  Khách hàng     
        //@Proc: 
        //      
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Edit_Customer(Customer_DTO customer, int id)
        {
            return true;
        }



        //@Description:
        //     Khóa 1 Khách bằng id. (Cập nhật lại trạng thái history)
        //@Parameter
        //    Customer_DTO customer  --------Tham số nhập là 1 vật tư
        //    int id           -------- Mã vật tư     
        //@Proc: 
        //      
        //@Return:
        //   boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Lock_Customer(int id)
        {
            return true;
        }


        //@Description:
        //     Tìm kiếm khách hàng
        //@Parameter
        //    String keyword 
        //    int type_search   ------- tìm kiếm theo mã hay tên, (bên dưới là chú thích loại tìm kiếm)
        //@Proc: 
        //      
        //@Return:
        //    List<Customer_DTO>   ------------ Trả về danh sách thỏa mãn
        public List<Customer_DTO> Search_Customer(String keyword, int type_search)
        {
            List<Customer_DTO> list_serch_customer = new List<Customer_DTO>();
            return list_serch_customer;
        }
    }
}
