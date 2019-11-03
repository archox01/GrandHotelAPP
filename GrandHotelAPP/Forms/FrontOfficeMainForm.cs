using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrandHotelAPP.DataSource;

namespace GrandHotelAPP
{
    public partial class FrontOfficeMainForm : Form
    {
        public FrontOfficeMainForm()
        {
            InitializeComponent();
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
            
            panel2.BringToFront();
        }

        private void FrontOfficeMainForm_Load(object sender, EventArgs e)
        {

        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            panel2.Height = reservationForm1.Height;
            panel2.Height = ReservationButton.Top;
            reservationForm1.BringToFront();
        }

        private void ReservationPanel_Load(object sender, EventArgs e)
        {

        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            panel2.Height = CheckInButton.Height;
            panel2.Height = CheckInButton.Top;
            checkInUC1.BringToFront();
        }

        private void checkInUC1_Load(object sender, EventArgs e)
        {
            
        }

        private void RAIButton_Click(object sender, EventArgs e)
        {
            panel2.Height = RAIButton.Height;
            panel2.Height = RAIButton.Top;
            requestAditionalItemUC1.BringToFront();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            panel2.Height = CheckOutButton.Height;
            panel2.Height = CheckOutButton.Top;
            checkOutUC1.BringToFront();
        }

        private void MRTButton_Click(object sender, EventArgs e)
        {
            panel2.Height = MRTButton.Height;
            panel2.Height = MRTButton.Top;
            mrTypeUC1.BringToFront();
        }

        private void MRButton_Click(object sender, EventArgs e)
        {
            panel2.Height = MIButton.Top;
            panel2.Height = MIButton.Top;
            masterRoomUC1.BringToFront();
        }

        private void MIButton_Click(object sender, EventArgs e)
        {
            panel2.Height = CheckInButton.Height;
            panel2.Height = CheckInButton.Top;
            masterItemUC1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
