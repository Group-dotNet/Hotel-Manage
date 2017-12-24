using app.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    public class Analytic_BUS
    {
        private static Analytic_BUS instance;

        internal static Analytic_BUS Instance
        {
            get { if (instance == null) instance = new Analytic_BUS(); return Analytic_BUS.instance; }
            private set { instance = value; }
        }

        private Analytic_BUS() { }

        public int CountReservationInDay(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.CountReservationInDay(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountRoomEmtyInDay()
        {
            try
            {
                return Analytic_DAO.Instance.CountRoomEmtyInDay();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountRoomUsingInDay()
        {
            try
            {
                return Analytic_DAO.Instance.CountRoomUsingInDay();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountServiceUsingInDay(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.CountServiceUsingInDay(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountRevenueInDay(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.CountRevenueInDay(date);
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                throw new Exception("Error!");
            }
        }

        public int CountBillInDay(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.CountBillInDay(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        public int CountServiceUsing(int id_service)
        {
            try
            {
                return Analytic_DAO.Instance.CountServiceUsing(id_service);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountReservationByCustomer(int id_customer)
        {
            try
            {
                return Analytic_DAO.Instance.CountReservationByCustomer(id_customer);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int GetSpendMoney(int id_customer)
        {
            try
            {
                return Analytic_DAO.Instance.GetSpendMoney(id_customer);
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                throw new Exception("Error!");
            }
        }

        public int CountStuffInRoom(int id_kor)
        {
            try
            {
                return Analytic_DAO.Instance.CountStuffInRoom(id_kor);
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                throw new Exception("Error!");
            }
        }

        public int CountUsingRoom(int id_room)
        {
            try
            {
                return Analytic_DAO.Instance.CountUsingRoom(id_room);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountReservationByStaff(string username)
        {
            try
            {
                return Analytic_DAO.Instance.CountReservationByStaff(username);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountRoomOfStaff(string username)
        {
            try
            {
                return Analytic_DAO.Instance.CountRoomOfStaff(username);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountCheckOutByStaff(string username)
        {
            try
            {
                return Analytic_DAO.Instance.CountCheckOutByStaff(username);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }


        public List<DTO.Reservation_DGV> Get_Analytic_Reservation(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.Get_Analytic_Reservation(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<DTO.Room_DGV> Get_Analytic_Room_Emty()
        {
            try
            {
                return Analytic_DAO.Instance.Get_Analytic_Room_Emty();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<DTO.Room_DGV> Get_Analytic_Room_Using()
        {
            try
            {
                return Analytic_DAO.Instance.Get_Analytic_Room_Using();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<DTO.Service_DGV> Get_Analytic_Service(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.Get_Analytic_Service(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<DTO.Bill_DGV> Get_Analytic_Bill(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.Get_Analytic_Bill(date);
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                throw new Exception("Error!");
            }
        }

    }
}