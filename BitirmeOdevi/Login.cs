using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitirmeOdevi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciTb.Text = "";
            SifreTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KullaniciTb.Text==""||SifreTb.Text=="")
            {
                MessageBox.Show("eksik bilgi");
            }
            else if(KullaniciTb.Text=="Berkcan"&&SifreTb.Text=="1234")
            {
                AnaSayfa anasayfa=new AnaSayfa();
                anasayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hatalı kulanıcı adı veya şifre");
            }
        }
    }
}
