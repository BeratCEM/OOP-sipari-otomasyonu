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
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
        {
            InitializeComponent();
        }

        private void ÜrnEkle_Click(object sender, EventArgs e)
        {

            StreamWriter yaz = File.AppendText(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
            yaz.Write(ÜrnMarka.Text + "-");
            yaz.Write(ÜrnModel.Text + "-");
            yaz.Write(ÜrnFiyat.Text + "-");
            yaz.Write(ÜrnAdet.Text + "-");
            yaz.WriteLine(ÜrnAgırlık.Text);
            yaz.Close();
            MessageBox.Show("Ürün Başarıyla Eklendi.");

            ÜrnMarka.Text = "";
            ÜrnModel.Text = "";
            ÜrnFiyat.Text = "";
            ÜrnAdet.Text = "";
            ÜrnAgırlık.Text = "";



        }
    }
}


    
