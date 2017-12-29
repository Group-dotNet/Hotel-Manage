using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    public class Staff_BUS
    {
        private static Staff_BUS instance;

        internal static Staff_BUS Instance
        {
            get { if (instance == null) instance = new Staff_BUS(); return Staff_BUS.instance; }
            private set { instance = value; }
        }

        private Staff_BUS() { }


        public Staff_DTO Get_Info(string username)
        {
            try
            {
                return Staff_DAO.Instance.Get_Info(username);
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                throw new Exception("Error!");
            }
        }

        public List<Staff_DTO> List_Staff()
        {
            try
            {
                return Staff_DAO.Instance.List_Staff();
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                throw new Exception("Error!");
            }
        }

        public bool Edit_Info_Staff(Staff_DTO staff)
        {
            try
            {
                return Staff_DAO.Instance.Edit_Info_Staff(staff);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public string Get_Role(string username)
        {
            try
            {
                int role = Staff_DAO.Instance.Get_Role(username);
                if (role == -1)
                    return "Account not exists!";
                else if (role == 1)
                    return "Admin";
                else
                    return "Staff";

            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Check_Username(string username)
        {
            try
            {
                return Staff_DAO.Instance.Check_Username(username);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Insert_Account(string username, string password, int id_type)
        {
            try
            {
                MD5 md5 = MD5.Create();
                string password_md5 = Function_Other.Instance.GetMd5Hash(md5, password);
                return Staff_DAO.Instance.Insert_Account(username, password_md5, id_type);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Ban_Account(string username)
        {
            try
            {
                return Staff_DAO.Instance.Ban_Account(username);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool Check_Email(string email)
        {
            try
            {
                return Staff_DAO.Instance.Check_Email(email);
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                throw new Exception("Error!");
            }
        }

        public bool Insert_Staff(System_DTO account, Staff_DTO staff)
        {
            try
            {
                MD5 md5 = MD5.Create();
                string password_md5 = Function_Other.Instance.GetMd5Hash(md5, account.Password);
                account.Password = password_md5;
                return Staff_DAO.Instance.Insert_Staff(account, staff);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception("Error!");
            }
        }

        public List<Staff_DTO> GetListStaffSearch(string keyword)
        {
            try
            {
                return Staff_DAO.Instance.GetListStaffSearch(keyword);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception("Error!");
            }
        }

    }
}
