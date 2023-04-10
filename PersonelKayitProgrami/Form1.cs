using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelKayitProgrami
{
    public partial class Form1 : Form
    {
        
        SqlConnection baglanti = new SqlConnection("Data Source=aknclk\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form açıldığında otomatik olarak sql'den tabloyu listeler
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Listele butonuna tıklandığında sql'den tabloyu listeler,amaç değişiklik sonrası yenilikleri görmek
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }
    }
}
