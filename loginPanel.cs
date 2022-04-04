using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkAppV1._0
{
    public partial class loginPanel : Form
    {
        public loginPanel()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtPass.Text == "12345")
            {
                MessageBox.Show("Giriş Başarılı");
                AdminPanel pnlAdmin = new AdminPanel();
                this.Hide();
                pnlAdmin.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
