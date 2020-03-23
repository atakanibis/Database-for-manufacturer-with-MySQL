using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab23 {
    public partial class DeleteBuyer : Form {
        Sql connect;
        public DeleteBuyer() {
            InitializeComponent();
            connect = new Sql();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Delete_Buyer(int.Parse(textBox1.Text));
                MessageBox.Show("Kayıt Başarıyla silindi.");
            }
            catch (Exception eror)
            {
                MessageBox.Show("Kayıt Silinemedi! " + eror);
            }
        }
    }
}
