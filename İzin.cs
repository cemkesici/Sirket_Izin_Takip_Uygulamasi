using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sirket_Takip_Uygulamasi
{
    public partial class İzin : Form
    {   
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public İzin()
        {
            InitializeComponent();                
        }
        private void İzin_MouseMove(object sender, MouseEventArgs e)
        {
            if (radioButtonBirim.Checked == true) { textboxSil(); }
            if (radioButtonTümü.Checked == true) { textboxSil(); }
        }
        void textboxSil()
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox tbox)
                    {
                        tbox.Clear();
                    }
                }
            }
            catch { }
        }
        int izinHesapla(int id)
        {
            try
            {
                con = new SqlConnection("server=DESKTOP-2OHGSM4\\SQLEXPRESS; Initial Catalog=Db1;Integrated Security=true");
                cmd = new SqlCommand("Select * From Personel Where personel_id LIKE'%" + id + "%'", con);
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch { }
            return id;
        }
        void griddoldur()
        {
            con = new SqlConnection("server=DESKTOP-2OHGSM4\\SQLEXPRESS; Initial Catalog=Db1;Integrated Security=true");
            da = new SqlDataAdapter("Select pr.personel_id,pr.ad,pr.soyad,pr.Tc,pr.tel,pr.mail,pr.baslama_tarih,iz.yıllıkizin_kalan"+
                " From Personel as pr Inner Join izin as iz on iz.personel_id=pr.personel_id", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
            con.Close();
        }
        private void İzin_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'db1DataSet.birim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.birimTableAdapter.Fill(this.db1DataSet.birim);
            radioButtonPersonel.Checked = true;
            griddoldur();
            textboxSil();
        }

        private void Geributton_Click(object sender, EventArgs e)
        {
            Form anasayfaGit = new Anasayfa();
            anasayfaGit.Show();
            this.Hide();
        }

        private void Arabutton_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("server=DESKTOP-2OHGSM4\\SQLEXPRESS; Initial Catalog=Db1;Integrated Security=true");
                da = new SqlDataAdapter("Select personel_id,ad,soyad,Tc,tel,mail, baslama_tarih From Personel Where personel_id LIKE'%" + AratextBox.Text + 
                    "%' or ad LIKE'%" + AratextBox.Text + "%' ", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                con.Close();
            }
            catch { }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { try
            {                
                if (radioButtonPersonel.Checked == true)
                {              
                    IdtextBox.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    AdtextBox.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
                    SoyadtextBox.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
                    TctextBox.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
                    TeltextBox.Text = dataGridView1.CurrentRow.Cells["Tel"].Value.ToString();
                    MailtextBox.Text = dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
                    BaslamatextBox.Text = dataGridView1.CurrentRow.Cells["Baslama"].Value.ToString();
                  
                }              
            } 
           catch { }
        }

        private void İzinbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonBirim.Checked == true) { /*String birimid = comboBoxBirim.SelectedItem;*/ }
                if (radioButtonTümü.Checked == true) { textboxSil(); }
                if(radioButtonPersonel.Checked==true)
                {
                    int a = Convert.ToInt32(IdtextBox.Text);       
                    Form izinal = new İzinAl(a);
                    izinal.Show();
                    this.Hide();

                }
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
