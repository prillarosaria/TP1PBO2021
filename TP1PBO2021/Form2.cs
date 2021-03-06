using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TP1PBO2021
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void link3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form1 = new Form();
            form1.Show();
        }

        private void link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://shopee.co.id/");
        }

        public void beliItem_Click(object sender, EventArgs e, string nama)
        {
            button1.Enabled = true;
            label5.Text = "Detail Barang :";

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            void cetakBarang(Barang item, int posisi_awal, int i)
            {
                //Cetak Panel
                Panel panelItem = new Panel();
                this.Controls.Add(panelItem);
                panelItem.Name = "Panel" + i.ToString();
                panelItem.BackColor = Color.MistyRose;
                panelItem.Width = 166;
                panelItem.Height = 206;

                //Cetak Nama Barang
                Label namaItem = new Label();
                this.Controls.Add(namaItem);
                namaItem.Name = "Item" + i.ToString();
                namaItem.TextAlign = ContentAlignment.MiddleCenter;
                namaItem.AutoSize = true;
                namaItem.Text = item.nama_barang;
                namaItem.Location = new System.Drawing.Point(posisi_awal + 30, 310);
                namaItem.Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);

                //Cetak Harga Barang
                Label hargaItem = new Label();
                this.Controls.Add(hargaItem);
                hargaItem.Name = "Harga" + i.ToString();
                hargaItem.TextAlign = ContentAlignment.MiddleCenter;
                hargaItem.AutoSize = true;
                hargaItem.Text = item.harga;
                hargaItem.Location = new System.Drawing.Point(posisi_awal + 40, 330);
                hargaItem.Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);


                //Cetak Foto Barang
                PictureBox gambarItem = new PictureBox();
                this.Controls.Add(gambarItem);
                gambarItem.Name = "Gambar" + i.ToString();
                gambarItem.BackColor = Color.MistyRose;
                gambarItem.Size = new System.Drawing.Size(150, 150);
                gambarItem.Location = new System.Drawing.Point(posisi_awal, 150);
                gambarItem.TabIndex = 12;
                gambarItem.TabStop = false;

                //Cetak Tombol beli
                Button beliItem = new Button();
                this.Controls.Add(beliItem);
                beliItem.Name = "beli" + i.ToString();
                beliItem.TextAlign = ContentAlignment.MiddleCenter;
                beliItem.AutoSize = true;
                beliItem.Text = "Beli";
                beliItem.Location = new System.Drawing.Point(posisi_awal + 40, 350);
                beliItem.Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);
                beliItem.BackColor = Color.Salmon;
                beliItem.ForeColor = Color.White;
                
            }

            

            Barang item1 = new Barang("Outer Trendy", "Pakaian", "130.000");
            Barang item2 = new Barang("Tteokpokki", "Makanan", "100.000");
            Barang item3 = new Barang("Vaccum Cleaner", "Elektronik", "725.000");
            Barang item4 = new Barang("Blouse Korea", "Pakaian", "250.000");
            Barang item5 = new Barang("Earphone", "Elektronik", "350.000");

            List<Barang> Item = new List<Barang>();
            Item.Add(item1);
            Item.Add(item2);
            Item.Add(item3);
            Item.Add(item4);
            Item.Add(item5);

            int posisi = 220;
            foreach(Barang stuff in Item)
            {
                cetakBarang(stuff, posisi, 1);
                posisi += 170;
                
            }
        }
        
    }
}

