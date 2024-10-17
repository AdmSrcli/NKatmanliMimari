using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntitiyLayer;
using DataAccessLayer;
using LogicLayer;
using System.Data.SqlClient;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntitiyPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntitiyPersonel ent=new EntitiyPersonel();
            ent.Ad=txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir=txtsehir.Text;
            ent.Maas =short.Parse( txtmaas.Text);
            ent.Gorev=txtgorev.Text;
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            EntitiyPersonel ent=new EntitiyPersonel();
            ent.Id=Convert.ToInt32(txtid.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntitiyPersonel ent = new EntitiyPersonel();

            ent.Id = Convert.ToInt32(txtid.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            LogicPersonel.LLPersonelGuncelle(ent);


        }
    }
}
