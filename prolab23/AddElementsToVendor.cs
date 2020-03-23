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
    public partial class AddElementsToVendor : Form {

        Sql sql = new Sql();
        List<Element> elements;
        List<Vendor> vendors;

        public AddElementsToVendor() {
            InitializeComponent();
            numericUpDown1.Maximum = Decimal.MaxValue;
            numericUpDown2.Maximum = Decimal.MaxValue;
            textBox1.ReadOnly = true;
            elements = sql.GetElements();
            vendors = sql.GetVendors();
            foreach (var vendor in vendors) {
                listBox1.Items.Add(vendor.name);
            }
            foreach (var element in elements) {
                listBox2.Items.Add(element.name);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if(numericUpDown1.Value <= 0 || numericUpDown2.Value <= 0 || listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1) {
                MessageBox.Show("Geçerli bir değer giriniz.");
                return;
            }
            int vid = vendors.First(v => v.name == listBox1.Text).id;
            int eid = elements.First(v => v.name == listBox2.Text).id;
            sql.UpdateVendorsElement(vid, eid, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
            MessageBox.Show("Eklendi");
            updateStock();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {
            updateStock();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            updateStock();
        }

        private void updateStock() {
            if(listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1) {
                int vid = vendors.First(v => v.name == listBox1.Text).id;
                int eid = elements.First(v => v.name == listBox2.Text).id;
                VendorElement element = sql.GetVendorElement(vid, eid);
                textBox1.Text = element.stock.ToString();
                numericUpDown2.Value = element.price;
                numericUpDown1.Value = 0;
            }
        }

    }
}
