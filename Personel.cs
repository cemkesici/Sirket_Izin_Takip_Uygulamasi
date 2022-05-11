using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sirket_Takip_Uygulamasi
{
    public partial class Personel : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public Personel()
        {
            InitializeComponent();
        }
        void textboxSil()
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tbox = (TextBox)item;
                        tbox.Clear();
                    }
                }
            }
            catch { }
        }
        void griddoldur()
        {
            con = new SqlConnection("server=DESKTOP-2OHGSM4\\SQLEXPRESS; Initial Catalog=Db1;Integrated Security=true");
            da = new SqlDataAdapter("Select * From Personel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'db1DataSet.durum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.durumTableAdapter.Fill(this.db1DataSet.durum);
            // TODO: Bu kod satırı 'db1DataSet.unvan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.unvanTableAdapter.Fill(this.db1DataSet.unvan);
            // TODO: Bu kod satırı 'db1DataSet.birim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.birimTableAdapter.Fill(this.db1DataSet.birim);
            griddoldur();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dogum = dogumTarih.Value;
                DateTime baslama = baslamaTarih.Value;

                con.Open();
                cmd = new SqlCommand("Insert into  Personel (ad,soyad,birim_id,unvan_id,baslama_tarih,dogum_tarih,maas,Tc,tel,mail,durum_id) VALUES  " +
                    "('" + textBoxAd.Text + "','" + textBoxSoyad.Text + "','" + comboBoxBirim.SelectedValue + "','" + comboBoxUnvan.SelectedValue +
                    "','" + baslama.ToString("yyyy-MM-dd") + "','" + dogum.ToString("yyyy-MM-dd") + "','" + textBoxMaas.Text + "','"
                    + textBoxTc.Text + "','" + textBoxTel.Text + "','" + textBoxEmail.Text + "','" + comboBoxDurum.SelectedValue + "')", con);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("SELECT MAX(personel_id) FROM Personel ", con);
                int sayiTut = Convert.ToInt16(cmd1.ExecuteScalar());
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("Insert into  izin(personel_id, yıllıkizin_kalan) VALUES  " + "('" + sayiTut + "','" + 30 + "')", con);
                cmd2.ExecuteNonQuery();

            }
            catch { }
            finally
            {
                con.Close();
                griddoldur();
                textboxSil();
            }

        }

        private void silButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Delete From Personel Where personel_id=" + textBoxId.Text + "", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete From izin Where personel_id=" + textBoxId.Text + "", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { }
            griddoldur();
            textboxSil();
        }

        private void güncelleButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dogum = dogumTarih.Value;
                DateTime baslama = baslamaTarih.Value;
                con.Open();
                cmd = new SqlCommand("update Personel set ad='" + textBoxAd.Text + "',soyad='" + textBoxSoyad.Text + "',birim_id='" + comboBoxBirim.SelectedValue +
                    "',unvan_id='" + comboBoxUnvan.SelectedValue + "',baslama_tarih='" + baslama.ToString("yyyy-MM-dd") + "',dogum_tarih='" + dogum.ToString("yyyy-MM-dd") +
                     "',maas='" + textBoxMaas.Text + "',Tc='" + textBoxTc.Text + "',tel='" + textBoxTel.Text + "',mail='" +
                     textBoxEmail.Text + "',durum_id='" + comboBoxDurum.SelectedValue + "' where personel_id=" + textBoxId.Text + "", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { }
            griddoldur();
            textboxSil();
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBoxId.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                textBoxAd.Text = dataGridView1.CurrentRow.Cells["AD"].Value.ToString();
                textBoxSoyad.Text = dataGridView1.CurrentRow.Cells["SOYAD"].Value.ToString();
                comboBoxBirim.Text = dataGridView1.CurrentRow.Cells["BİRİM"].Value.ToString();
                comboBoxUnvan.Text = dataGridView1.CurrentRow.Cells["UNVAN"].Value.ToString();
                dogumTarih.Text = dataGridView1.CurrentRow.Cells["DOĞUM"].Value.ToString();
                baslamaTarih.Text = dataGridView1.CurrentRow.Cells["BASLAMA"].Value.ToString();
                textBoxMaas.Text = dataGridView1.CurrentRow.Cells["MAAŞ"].Value.ToString();
                textBoxTc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
                textBoxTel.Text = dataGridView1.CurrentRow.Cells["TEL"].Value.ToString();
                textBoxEmail.Text = dataGridView1.CurrentRow.Cells["MAİL"].Value.ToString();
                comboBoxDurum.Text = dataGridView1.CurrentRow.Cells["DURUM"].Value.ToString();
            }
            catch { }
        }

        private void textBoxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
            textBoxAd.Select();
            textBoxAd.Select(textBoxAd.Text.Length, 0);
        }

        private void textBoxSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxPrim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Form anasayfaDön = new Anasayfa();
            anasayfaDön.Show();
            this.Hide();
        }

        private void Arabutton_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("server=DESKTOP-2OHGSM4\\SQLEXPRESS; Initial Catalog=Db1;Integrated Security=true");
                da = new SqlDataAdapter("Select personel_id,ad,soyad,birim_id,unvan_id,dogum_tarih,baslama_tarih,maas,Tc,tel,mail,durum_id From Personel Where personel_id LIKE'%" + AratextBox.Text +
                    "%' or ad LIKE'%" + AratextBox.Text + "%' ", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                con.Close();
            }
            catch { }
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            textboxSil();
            griddoldur();
        }
    }
}