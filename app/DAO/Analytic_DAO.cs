using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    public class Analytic_DAO
    {
        private static Analytic_DAO instance;

        internal static Analytic_DAO Instance
        {
            get { if (instance == null) instance = new Analytic_DAO(); return Analytic_DAO.instance; }
            private set { instance = value; }
        }

        private Analytic_DAO() { }

        public int CountReservationInDay(DateTime date)
        {
            string query = "exec USP_CountReservationInDay @date";

            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { date });
            return x;

        }

        public int CountRoomEmtyInDay()
        {
            string query = "exec USP_CountRoomEmty";

            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] {  });
            return x;

        }

        public int CountRoomUsingInDay()
        {
            string query = "exec USP_CountRoomUsing";

            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] {  });
            return x;
        }

        public int CountServiceUsingInDay(DateTime date)
        {
            string query = "exec USP_CountServiceUsingInDay @date";

            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { date });
            return x ;
        }

        public int CountRevenueInDay(DateTime date)
        {

            string query = "exec USP_CountRevenueInDay @date";

            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { date });
            return  x;
        }

        public int CountBillInDay(DateTime date)
        {
            string query = "exec USP_CountBillInDay @date";

            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { date });
            return x;
        }


        //  New function 

        public int CountServiceUsing(int id_service)
        {
            string query = "exec USP_CountUsingService @id_service";

            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { id_service });
            return x;
        }

        public int CountReservationByCustomer(int id_customer)
        {
            string query = "exec USP_CountReservationByCustomer @id_customer";
            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { id_customer });
            return x;
        }

        public int GetSpendMoney(int id_customer)
        {
            string query = "exec USP_GetSpendMoney @id_customer";
            int money = (int)Connect.Instance.ExecuteOutPut(query, new object[] { id_customer });
            return money;
        }

        public int CountStuffInRoom(int id_kor)
        {
            string query = "exec USP_CountStuffInRoom @id_kor";
            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { id_kor });
            return x;
        }

        public int CountUsingRoom(int id_room)
        {
            string query = "exec USP_CountUsingRoom @id_room";
            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { id_room });
            return x;
        }

        public int CountReservationByStaff(string username)
        {
            string query = "exec USP_CountReservationByStaff @username";
            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { username });
            return x;
        }

        public int CountRoomOfStaff(string username)
        {
            string query = "exec USP_CountRoomOfStaff @username";
            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { username });
            return x;
        }

        public int CountCheckOutByStaff(string username)
        {
            string query = "exec USP_CountCheckOutByStaff @username";
            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { username });
            return x;
        }

        // New fuction 


        public List<DTO.Reservation_DGV> Get_Analytic_Reservation(DateTime date)
        {
            string query = "exec USP_ReservationInDay @date";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { date });
            List<DTO.Reservation_DGV> list_reservation = new List<DTO.Reservation_DGV>();
            foreach (DataRow item in table.Rows)
            {
                DTO.Reservation_DGV reservation = new DTO.Reservation_DGV((int)item["id_reservation"], item["name"].ToString(), (bool)item["is_group"], (int)item["people"], item["username"].ToString(), (int)item["status_reservation"]);
                list_reservation.Add(reservation);
            }
            return list_reservation;
        }

        public List<DTO.Room_DGV> Get_Analytic_Room_Emty()
        {
            string query = "exec USP_RoomEmty";
            DataTable table = Connect.Instance.ExecuteQuery(query);
            List<DTO.Room_DGV> list_room = new List<DTO.Room_DGV>();
            foreach(DataRow item in table.Rows)
            {
                DTO.Room_DGV room = new DTO.Room_DGV((int)item["id_room"], (int)item["num_floor"], (int)item["num_order"], item["name"].ToString(), item["username"].ToString());
                list_room.Add(room);
            }
            return list_room;
        }

        public List<DTO.Room_DGV> Get_Analytic_Room_Using()
        {
            string query = "exec USP_RoomUsing";
            DataTable table = Connect.Instance.ExecuteQuery(query);
            List<DTO.Room_DGV> list_room = new List<DTO.Room_DGV>();
            foreach (DataRow item in table.Rows)
            {
                DTO.Room_DGV room = new DTO.Room_DGV((int)item["id_room"], (int)item["num_floor"], (int)item["num_order"], item["name"].ToString(), item["username"].ToString());
                list_room.Add(room);
            }
            return list_room;
        }

        public List<DTO.Service_DGV> Get_Analytic_Service(DateTime date)
        {
            string query = "exec USP_ServiceUsingInDay @date";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { date });
            List<DTO.Service_DGV> list_service = new List<DTO.Service_DGV>();
            foreach(DataRow item in table.Rows)
            {
                DTO.Service_DGV service = new DTO.Service_DGV((int)item["id_service"], (int)item["number"], (DateTime)item["date_use"], item["name_service"].ToString(), (int)item["price"], (int)item["num_floor"], (int)item["num_order"]);
                list_service.Add(service);
            }
            return list_service;
        }

        public List<DTO.Bill_DGV> Get_Analytic_Bill(DateTime date)
        {
            string query = "exec USP_BillInDay @date";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { date });
            List<DTO.Bill_DGV> list_bill = new List<DTO.Bill_DGV>();
            foreach (DataRow item in table.Rows)
            {
                DTO.Bill_DGV bill = new DTO.Bill_DGV((int)item["id_bill"], (double)((decimal)item["total_money"]), item["username"].ToString(), (bool)item["confirm"], (DateTime)item["created"]);
                list_bill.Add(bill);
            }
            return list_bill;
        }

    }
}