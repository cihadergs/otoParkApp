using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OtoparkAppV1._0
{
    public partial class AdminPanel : Form
    {

        public static double parkUcreti =0.0 ;
        public  static int parkKapasite = 0 ;
        public AdminPanel()
        {

            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            BaglantiClass baglanti = new BaglantiClass();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM park_fis ", baglanti.con());
            DataTable dt = new DataTable();
            da.Fill(dt);
            tableSqlData.DataSource = dt;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            parkKapasite = Convert.ToInt32(aracKpsTxt.Text);
            parkUcreti = Convert.ToDouble(parkUcretiTxt.Text);
            BaglantiClass baglanti = new BaglantiClass();
            baglanti.con().Close();
        }

        private void btnParkaGit_Click(object sender, EventArgs e)
        {
            Form1 girisForm = new Form1();
            this.Hide();
            girisForm.Show();
        }
    }
}
