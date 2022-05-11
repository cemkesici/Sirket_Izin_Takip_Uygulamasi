using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirket_Takip_Uygulamasi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personelGit = new Personel();
            personelGit.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form izinGit=new İzin();
            izinGit.Show();
            this.Hide();
        }
    }
}
