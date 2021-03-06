﻿using System;
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
    public partial class ÜrünSil : Form
    {
        public ÜrünSil()
        {
            InitializeComponent();
        }

        public void Listele()
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
            int row = 0;// int cell = 0;
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


        private void UrunSil_Click(object sender, EventArgs e)
        {

            string ÜrnAdı;
            StreamReader st = new StreamReader(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");

            int SatırSayac = 0;
            while (st.Read() > 0)
            {
                st.ReadLine();
                SatırSayac++;
            }
            st.Close();
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            ÜrnAdı = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            dataGridView1.Rows.RemoveAt(rowindex);
            string satır = "a";

            string[] lines = File.ReadAllLines(@"C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");
            int sayac = 0;

            while (sayac != SatırSayac)
            {
                StreamWriter yaz = File.AppendText("C:\\Users\\cem\\Desktop\\nypodev\\db\\yeni ürünler.txt");

                satır = lines[sayac];

                string[] parça = satır.Split('-');

                if (ÜrnAdı == parça[0])
                {
                    sayac++;
                    yaz.Close();
                    continue;
                }
                if (ÜrnAdı != parça[0])
                {
                    yaz.Write(satır + Environment.NewLine);
                    yaz.Close();
                    sayac++;
                }
            }


            string yol = "C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt";  
            File.Delete(yol);
            File.Move("C:\\Users\\cem\\Desktop\\nypodev\\db\\yeni ürünler.txt", "C:\\Users\\cem\\Desktop\\nypodev\\db\\ürünler.txt");

            

        }


        private void ÜrünSil_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
