using app.BUS;
using app.DTO;
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
    public partial class fEdit_Service : Form
    {
        public fEdit_Service()
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


        private Service_DTO Set_Service()
        {
            Service_DTO ser = new Service_DTO();
            if (this.id_service != 0)
                ser.Id_service = this.Id_service;
            ser.Name_service = txt_1.Text;
            ser.Price = decimal.Parse(txt_2.Text);
            ser.Unit = txt_3.Text;
            return ser;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
                if (Service_BUS.Instance.Edit_Service(this.Set_Service()))
                {
                    MessageBox.Show("Edit Successful");
                    this.id_service = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("False");

                }
            
        }

        private void fEdit_Service_Load(object sender, EventArgs e)
        {
            Service_DTO service_info = Service_BUS.Instance.Get_Info(this.Id_service);
            txt_1.Text = service_info.Name_service;
            txt_2.Text = service_info.Price.ToString();
            txt_3.Text = service_info.Unit;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }
    }
}
    