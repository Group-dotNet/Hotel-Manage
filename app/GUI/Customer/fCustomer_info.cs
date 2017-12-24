using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.GUI.Customer
{
    public partial class fCustomer_info : Form
    {
        public fCustomer_info()
        {
            InitializeComponent();
        }

        private int id_customer;

        public int Id_customer
        {
            get
            {
                return id_customer;
            }

            set
            {
                id_customer = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            DTO.Customer_DTO customer_info = BUS.Customer_BUS.Instance.Get_Info(this.id_customer);
            txt_name.Text = customer_info.Name;
            if (customer_info.Sex == false)
                txt_sex.Text = "Woman";
            else
                txt_sex.Text = "Men";
            txt_passport.Text = customer_info.Identity_card;
            txt_email.Text = customer_info.Email;
            txt_address.Text = customer_info.Address;
            txt_phone.Text = customer_info.Phone;
            txt_company.Text = customer_info.Company;

            if (customer_info.Id_history == 0)
                lb_history.Text = "Good";
            else
                lb_history.Text = "Bad";

            lb_spendmoney.Text = BUS.Analytic_BUS.Instance.GetSpendMoney(customer_info.Id_customer).ToString();
            lb_reservation.Text = BUS.Analytic_BUS.Instance.CountReservationByCustomer(customer_info.Id_customer).ToString();
        }

        private void fCustomer_info_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
