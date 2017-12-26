using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public Customer_DTO Get_Info(int id_customer)// Xong
        {
            string query = "exec USP_GetInfo @id_customer";
            DataTable Customer_info = Connect.Instance.ExecuteQuery(query, new object[] { id_customer });

            Customer_DTO customer = null;

            // Đỗi tượng DataRow là từng dòng trong đối tượng DataTable 
            // (Có thể bỏ vòng lặp này do số lượng dòng ta cấn truy xuất bằng 1 hoặc 0)
            foreach (DataRow item in Customer_info.Rows)
            {
                customer = new Customer_DTO(item);// cái này thiết Item
            }

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
        public List<Customer_DTO> Get_List() // Xong
        {
            string query = "exec USP_GetList";
            DataTable List_customer = Connect.Instance.ExecuteQuery(query);

            List<Customer_DTO> list_customer = new List<Customer_DTO>();
            foreach (DataRow item in List_customer.Rows)
            {
                Customer_DTO customer = new Customer_DTO(item);//thieu item
                list_customer.Add(customer);
            }
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

        //    @name NVARCHAR(100),
        //@sex bit,
        //@identity_card VARCHAR(20),
        //@address nvarchar(200),
        //@email varchar(80),
        //@phone varchar(11),
        //@company nvarchar(50),
        //@id_history int
        public bool Add_Customer(Customer_DTO customer)//Sửa lại
        {
            string query = "exec USP_InsertCustomer @name , @sex , @identity_card , @address , @email , @phone , @company"; // cái này viết sai tham số, điền đây đủ như trên
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { customer.Name, customer.Sex, customer.Identity_card, customer.Address, customer.Email, customer.Phone, customer.Company});// dưới này tướng ưng với từng tham số | tham khảo Staff, 
            return x == 1;
        }

        //Cậu dừng sửa têm hàm của tớ nha! hệ thông đã chạy theo ten của tớ đặt
        //@Description:
        //      Chỉnh sửa 1 khách hàng bằng id
        //@Parameter
        //    Customer_DTO customer  --------Tham số nhập là 1 Khách hàng
        //    int id                  -------- Mã  Khách hàng     
        //@Proc: 
        //      
        //@Return:
        //    boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Edit_Customer(Customer_DTO customer) // Sửa lại
        {
            string query = "exec USP_EditCustomer @id_customer , @name , @sex , @identity_card , @address , @email , @phone , @company ";// cái nàu cung jaor suaw tham só
            int record = Connect.Instance.ExecuteNonQuery(query, new object[] { customer.Id_customer, customer.Name, customer.Sex, customer.Identity_card, customer.Address, customer.Email, customer.Phone, customer.Company });
            return record == 1;
        }



        //@Description:
        //     Khóa 1 Khách bằng id. (Cập nhật lại trạng thái history)
        //@Parameter
        //    @username string 
        //         
        //@Proc: 
        //     USP_BanAccount 
        //@Return:
        //   boolean  ------------Thành công trả về true, thất bại trả về false;
        public bool Lock_Customer(int id_customer)// Hàm này tui quên chưa chỉnh sưa cho đúng databse hien tại | Nhung cũng xong rùi!
        {
            string query = "exec USP_LockCustomer @id_customer";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { id_customer });
            return x == 1;
        }

        public bool UnLock_Customer(int id_customer)
        {
            string query = "exec USP_UnLockCustomer @id_customer";
            int x = Connect.Instance.ExecuteNonQuery(query, new object[] { id_customer });
            return x == 1;
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
        public List<Customer_DTO> Search_Customer(String keyword, int type_search) // Viết tiếp
        {
            string query = "exec USP_SearchCustomer @keyword , @type ";//cái này có vấn đề nhé thếu tham só vào!. để tớ sửa lại cho, chút ý lần sau nhé
            DataTable List_customer = Connect.Instance.ExecuteQuery(query,new object[] { keyword , type_search });

            List<Customer_DTO> list_customer = new List<Customer_DTO>();
            foreach (DataRow item in List_customer.Rows)
            {
                Customer_DTO customer = new Customer_DTO(item);//thieu item
                list_customer.Add(customer);
            }
            return list_customer;

        }

        public bool Check_Email(string email)
        {
            string query = "exec USP_CheckEmail @email";
            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { email });
            return x == 1;
        }
    }
}

