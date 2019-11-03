using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrandHotelAPP.DataSource;

namespace GrandHotelAPP
{
    public partial class MRTypeUC : UserControl
    {
        public MRTypeUC()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadData()
        {
            using(GrandHotelContext Context = new GrandHotelContext())
            {
                var GetData = Context.RoomTypes.ToList<RoomType>();
                var BindData = from s in Context.RoomTypes select new
                {
                    s.Name,
                    s.Capacity,
                    s.RoomPrice
                };
                dataGridView1.DataSource = BindData.ToList();
                dataGridView1.Columns[0].HeaderText = "Name";
                dataGridView1.Columns[1].HeaderText = "Capacity";
                dataGridView1.Columns[2].HeaderText = "Room Price";
                
            }
        }

        private void MRTypeUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
