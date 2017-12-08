using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Customer_BUS
    {
        private static Customer_BUS instance;

        internal static Customer_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Customer_BUS(); return Customer_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Customer_BUS() { }

        //@Description:
        //      Bắt lỗi hàm Lấy ra thông tin của khách hàng bằng id
        //@Parameter
        //    string id_customer
        //@Proc: 
        //      
        //@Call:
        //    Customer_DTO.Instance.Get_Info(id_customer);
        //@Return:
        //    Customer_DTO  --- Trả về 1 khách hàng
        public Customer_DTO Get_Info(int id_customer)
        {
            try
            {
                return Customer_DAO.Instance.Get_Info(id_customer);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //     Bắt lỗi hàm  Lấy ra danh sách khách hàng trong bảng
        //@Parameter
        //    nope
        //@Proc: 
        //      
        //@Call:
        //    Customer_DAO.Instance.Get_List();
        //@Return:
        //    List<Customer_DTO>  --- Trả về 1 danh sách các khách hàng
        public List<Customer_DTO> Get_List()
        {
            try
            {
                return Customer_DAO.Instance.Get_List();
            }
            catch(SqlException e)
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //      Bắt lỗi hàm Thêm vào 1 Khách hàng
        //@Parameter
        //    Customer_DTO customer  --------Tham số nhập là 1 Khách hàng
        //@Proc: 
        //      
        //@Call:
        //    Customer_DAO.Instance.Add_Customer(customer);
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Add_Customer(Customer_DTO customer)
        {
            try
            {
                return Customer_DAO.Instance.Add_Customer(customer);
            }
            catch(SqlException e)
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //      Bắt lỗi hàm Chỉnh sửa 1 khách hàng bằng id
        //@Parameter
        //    Customer_DTO customer  --------Tham số nhập là 1 Khách hàng
        //    int id                  -------- Mã  Khách hàng     
        //@Proc: 
        //      
        //@Call:
        //     Customer_DAO.Instance.Edit_Customer(customer, id);
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Edit_Customer(Customer_DTO customer)
        {
            try
            {
                return Customer_DAO.Instance.Edit_Customer(customer);
            }
            catch(SqlException e)
            {
                throw new Exception("Error!");
            }
        }



        //@Description:
        //     Bắt lỗi hàm Khóa 1 Khách bằng id. (Cập nhật lại trạng thái history)
        //@Parameter
        //    Customer_DTO customer  --------Tham số nhập là 1 vật tư
        //    int id           -------- Mã vật tư     
        //@Proc: 
        //      
        //@Call:
        //    Customer_DAO.Instance.Lock_Customer(id);
        //@Return:
        //   boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Lock_Customer(int id_customer)
        {
            try
            {
                return Customer_DAO.Instance.Lock_Customer(id_customer);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        //@Description:
        //     Bắt lỗi hàm Tìm kiếm khách hàng
        //@Parameter
        //    String keyword 
        //    int type_search   ------- tìm kiếm theo mã hay tên, (bên dưới là chú thích loại tìm kiếm)
        //@Proc: 
        //      
        //@Call:
        //    Customer_DAO.Instance.Search_Customer(keyword, type_search);
        //@Return:
        //    List<Customer_DTO>   ------------ Trả về danh sách thỏa mãn
        public List<Customer_DTO> Search_Customer(String keyword, int type_search)
        {
            try
            {
                return Customer_DAO.Instance.Search_Customer(keyword, type_search);
            }
            catch(SqlException e)
            {
                throw new Exception("Error!");
            }
        }

        public bool Check_Email(string email)
        {
            try
            {
                return Customer_DAO.Instance.Check_Email(email);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
