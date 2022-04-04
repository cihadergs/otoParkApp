using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OtoparkAppV1._0
{
    public partial class Form1 : Form
    {
        BaglantiClass baglanti = new BaglantiClass();
        public DateTime baslangic = DateTime.Today;
        AdminPanel pnlAdmin = new AdminPanel();
        public int kapasite = 0;
        public Form1()
        {
            baglanti.con();
            InitializeComponent();
            
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                baslangic = DateTime.Now;

                string sqlSorgusu = @"INSERT INTO park_fis (
                                                            arac_plaka,
                                                            arac_giris
                                                            ) 
                                   VALUES (@arac_plaka,@arac_giris)";
                SqlCommand cmd = new SqlCommand(sqlSorgusu, baglanti.con());
                cmd.Parameters.AddWithValue("@arac_plaka", txt_plaka.Text);
                cmd.Parameters.AddWithValue("@arac_giris", baslangic);
                cmd.ExecuteNonQuery();

                baglanti.con().Close();
                if (kapasite == AdminPanel.parkKapasite)
                {
                    MessageBox.Show("Üzgünüz tüm park yerleri dolu");
                    string sqlSorgusuSilme = "DELETE FROM park_fis where arac_plaka=@arac_plaka";
                    SqlCommand cmdDel = new SqlCommand(sqlSorgusuSilme, baglanti.con());
                    cmdDel.Parameters.AddWithValue("@arac_plaka", txt_plaka.Text);
                    cmdDel.ExecuteNonQuery();
                    System.Environment.Exit(0);
                }
                kapasite++;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            try
            {
              DateTime parkBitis = DateTime.Now;

              string sqlSorgusu = "UPDATE park_fis SET arac_cikis = @arac_cikis WHERE arac_plaka='"+txt_plaka.Text+"'";
              SqlCommand cmd = new SqlCommand(sqlSorgusu, baglanti.con());
              cmd.Parameters.AddWithValue("@arac_cikis", parkBitis);
              cmd.ExecuteNonQuery();

                var otoparkSuresi = (parkBitis - baslangic).Hours ;

                
                double tarifeUcreti = AdminPanel.parkUcreti;
                double ucretPark = otoparkSuresi * tarifeUcreti;
                string sqlSorgusu2 = "UPDATE park_fis SET ücret = @ücret WHERE arac_plaka='" + txt_plaka.Text + "'";
                SqlCommand cmd2 = new SqlCommand(sqlSorgusu2, baglanti.con());
                cmd2.Parameters.AddWithValue("@ücret", (ucretPark + " TL").ToString());
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Giriþ Zamaný = "+baslangic+"" + "\n" + "Çýkýþ Zamaný = "+parkBitis+"" + "\n" + "Ödenecek Tutar = "+ ucretPark + " TL");

                kapasite--;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}