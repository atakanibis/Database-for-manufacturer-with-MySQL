using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prolab23 {
    public partial class BuyerForm : Form {
        Sql connect;
        string bname;
        string badress;
        public BuyerForm() {
            InitializeComponent();
            connect = new Sql();
        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bname = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            badress = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.AddBuyer(bname, badress);
                MessageBox.Show("Kayıt Gerçekleştirildi.");
            }
            catch(Exception eror)
            {
                MessageBox.Show("Kayıt Gerçekleştirilemedi !" + eror);
            }
        }
    }
}
