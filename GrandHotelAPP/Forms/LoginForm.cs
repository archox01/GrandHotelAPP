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
using GrandHotelAPP.Forms;

namespace GrandHotelAPP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (var Context = new GrandHotelContext())
            {
                var Login = (from s in Context.Employees where s.Username == UsernameTextBox.Text && s.Password == PasswordTextBox.Text select s).FirstOrDefault<Employee>();
                if(Login.Job.Name == "Housekeeper")
                {
                    var Go = new FrontOfficeMainForm();
                    this.Hide();
                    Go.Show();
                }
                else if(Login.Job.Name == "Housekeeper Supervisor")
                {
                    var Go = new HousekeeperSupervisorForm();
                    this.Hide();
                    Go.Show();
                }
                else if(Login.Job.Name == "Admin")
                {
                    var Go = new AdminForm();
                    this.Hide();
                    Go.Show();
                }
                else if(Login.Job.Name == "Front Office")
                {
                    var Go = new FrontOfficeMainForm();
                    this.Hide();
                    Go.Show();
                }
            }
            
        }
    }
}
