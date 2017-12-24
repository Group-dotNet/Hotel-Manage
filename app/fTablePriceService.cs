using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class fTablePriceService : Form
    {
        public fTablePriceService()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            List<DTO.Service_DTO> list_service = BUS.Service_BUS.Instance.Get_List();
            foreach(DTO.Service_DTO service in list_service)
            {
                ListViewItem item = new ListViewItem(service.Name_service);
                item.SubItems.Add(service.Price.ToString());
                item.SubItems.Add(service.Unit);
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fTablePriceService_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
