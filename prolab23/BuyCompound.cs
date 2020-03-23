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
    public partial class BuyCompound : Form {
        Sql sql = new Sql();
        List<Compound> compounds;
        public BuyCompound() {
            InitializeComponent();
            compounds = sql.GetAllCompounds();
            foreach (var compound in compounds)
            {
                listBox1.Items.Add(compound.name);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || int.Parse(textBox2.Text) < 0 )
            {
                MessageBox.Show("Geçerli bir değer giriniz.");
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
