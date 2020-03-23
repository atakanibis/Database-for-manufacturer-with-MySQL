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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form buyer = new BuyerForm();
            buyer.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Deletebuyer = new DeleteBuyer();
            Deletebuyer.Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            Form createCompund = new CreateCompound();
            createCompund.Show();
        }

        private void button6_Click(object sender, EventArgs e) {
            (new AddElementsToVendor()).Show();
        }

        private void button7_Click(object sender, EventArgs e) {
            (new ProduceNewCompound()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form vendor = new AddVendor();
            vendor.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form addelement = new AddElement();
            addelement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form buycom = new BuyCompound();
            buycom.Show();
        }
    }
}
