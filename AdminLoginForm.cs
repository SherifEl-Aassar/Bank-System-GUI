using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_GUI
{
    public partial class AdminLoginForm : MetroFramework.Forms.MetroForm
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            if (txtID.Text == obj.get_ID() && txtPass.Text == obj.get_Pass())
            {
                this.Hide();
                AdminMenu form = new AdminMenu();
                form.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(AdminLoginForm.ActiveForm, "You Enter a wrong ID or Password");
            }

        }
    }
}
