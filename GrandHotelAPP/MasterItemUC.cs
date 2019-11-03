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
    public partial class MasterItemUC : UserControl
    {
        public MasterItemUC()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using(var Context = new GrandHotelContext())
            {
                var GetData = from s in Context.Items
                              select new
                              {
                                  s.Name,
                                  s.RequestPrice,
                                  s.CompensationFee
                              };
                datagridv.DataSource = GetData.ToList();
            }
           
            datagridv.Columns[0].HeaderText = "Name";
            datagridv.Columns[1].HeaderText = "Request Price";
            datagridv.Columns[2].HeaderText = "Compensation Fee";

        }
        private void MasterItemUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
