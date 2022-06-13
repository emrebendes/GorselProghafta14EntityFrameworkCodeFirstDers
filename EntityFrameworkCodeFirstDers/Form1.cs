using EntityLayer;
using EntityLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCodeFirstDers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            veriGuncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var okuldb = new OkulDb())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.OgrenciAdi = textBox1.Text;
                ogrenci.DTarihi = dateTimePicker1.Value;
                okuldb.ogrenciler.Add(ogrenci);
                okuldb.SaveChanges();
            }
            veriGuncelle();
        }
        public void veriGuncelle()
        {
            using (OkulDb okul = new OkulDb())
            {
                dataGridView1.DataSource = okul.ogrenciler
                    .Select(p => new { p.OgrenciId, p.DTarihi, p.OgrenciAdi })
                    .ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var okuldb = new OkulDb())
            {
                Ogrenci ogrenci = okuldb.ogrenciler.Find(dataGridView1.SelectedRows[0].Cells[0].Value);
                
                okuldb.ogrenciler.Remove(ogrenci);
                okuldb.SaveChanges();
            }
            veriGuncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var okuldb = new OkulDb())
            {
                Ogrenci ogrenci = okuldb.ogrenciler.Find(dataGridView1.SelectedRows[0].Cells[0].Value);

                ogrenci.OgrenciAdi = textBox1.Text;
                ogrenci.DTarihi = dateTimePicker1.Value;

                okuldb.SaveChanges();
            }
            veriGuncelle();
        }
    }
}
