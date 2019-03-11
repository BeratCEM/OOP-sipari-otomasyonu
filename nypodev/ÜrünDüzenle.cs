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
    public partial class ÜrünDüzenle : Form
    {
        public ÜrünDüzenle()
        {
            InitializeComponent();
        }
        private void ÜrünDüzenle_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            StreamReader st = new StreamReader(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");

            int SatırSayac = 0;
            while (st.Read() > 0)
            {
                st.ReadLine();
                SatırSayac++;
            }
            st.Close();
            string satır = "a";
            int row = 0;
            string[] lines = File.ReadAllLines(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
            int sayac = 0; int i = 0;

            while (sayac != SatırSayac)
            {
                satır = lines[sayac];
                dataGridView1.Rows.Add();

                string[] parça = satır.Split('-');

                for (i = 0; i < 5; i++)
                {
                    dataGridView1.Rows[row].Cells[i].Value = parça[i];
                }

                sayac++; row++;
            }


        }

        private void UrunDuzenle_Click(object sender, EventArgs e)
        {

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            Textmark.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            TextModel.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            TextFiyat.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            TextAdet.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            TextAgırlık.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();

            Textmark.Visible = true;
            TextModel.Visible = true;
            TextFiyat.Visible = true;
            TextAdet.Visible = true;
            TextAgırlık.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            UrunGuncel.Visible = true;
        }

        private void UrunGuncel_Click(object sender, EventArgs e)
        {

            
            string Marka, Model, Fiyat, Adedi, Ağırl;
            StreamReader st = new StreamReader(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
            int SatırSayac = 0;
            while (st.Read() > 0)

            {
                st.ReadLine();
                SatırSayac++;
                
            }
            st.Close();
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string marka = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string model = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            Marka = Textmark.Text;
            Model = TextModel.Text;
            Fiyat = TextFiyat.Text;
            Adedi = TextAdet.Text;
            Ağırl = TextAgırlık.Text;

            StringBuilder sb = new StringBuilder();
            string deger = string.Empty;

            string[] dosya = File.ReadAllLines(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
            
            foreach (string satır in dosya)
            {
                string[] parça = satır.Split('-');
               
                if (parça[0] == marka && parça[1] == model)
                {
                    

                    deger = satır.Replace(parça[0] + "-" + parça[1] + "-" + parça[2] + "-" + parça[3] + "-" + parça[4], Marka + "-" + Model + "-" + Fiyat + "-" + Adedi + "-" + Ağırl);
                    
                    sb.Append(deger + Environment.NewLine);
                    continue;
                }
                sb.Append(satır + Environment.NewLine);
            }

            File.WriteAllText(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\yeni ürünler.txt", sb.ToString());

            string yol = "C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt";
            File.Delete(yol);

            
            File.Move("C:\\Users\\cem\\Desktop\\nypodev\\db\\yeni ürünler.txt","C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
            Listele();
        }
    }
}
