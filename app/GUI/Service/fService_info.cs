using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.GUI.Service
{
    public partial class fService_info : Form
    {
        public fService_info()
        {
            InitializeComponent();
        }
        private int id_service;

        public int Id_service
        {
            get
            {
                return id_service;
            }

            set
            {
                id_service = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Load_Data()
        {
            DTO.Service_DTO service = BUS.Service_BUS.Instance.Get_Info(this.id_service);
            txt_nameservice.Text = service.Name_service.ToString();
            txt_price.Text = service.Price.ToString();
            txt_unit.Text = service.Unit.ToString();

            lb_used.Text = BUS.Analytic_BUS.Instance.CountServiceUsing(this.id_service).ToString();
            lb_revenue.Text = (BUS.Analytic_BUS.Instance.CountServiceUsing(this.id_service) * (int)service.Price).ToString();
        }

        private void fService_info_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
