using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace nypodev
{
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }

        private void KaydolBtn_Click(object sender, EventArgs e)
        {

            StreamWriter yaz = File.AppendText(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\kullanıcı.txt");
            yaz.Write(mstrad.Text + "-");
            yaz.Write(mstrsoy.Text + "-");
            yaz.Write(kllanad.Text + "-");
            yaz.WriteLine(sifre.Text + "-");
            yaz.Close();
            MessageBox.Show("Aramıza Hoşgeldiniz");

            mstrad.Text = "";
            kllanad.Text = "";
            mstrsoy.Text = "";
            sifre.Text = "";


        }

        private void AnaSyfBtn_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
        }
    }
}
