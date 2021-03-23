using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApp47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=vt1.accdb");
            OleDbCommand komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.Parameters.Clear();
            komut.CommandText = "DELETE FROM liste WHERE numara=@n";
            komut.Parameters.AddWithValue("@n", Convert.ToInt32(textBox1.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi..(Yeni Versiyon)");
            baglanti.Close();
        }
    }
}
