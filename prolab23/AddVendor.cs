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
    public partial class AddVendor : Form {
        Sql connect;
        List<City> cities = new List<City>();
        const string NotSelected = "Not Selected";
        public AddVendor() {
            InitializeComponent();
            connect = new Sql();
            cities = connect.GetCitiesName();
            var comboBoxes = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("comboBox"));
            foreach (var cmbBox in comboBoxes)
            {
                cmbBox.Items.Add(NotSelected);
                foreach (var city in cities)
                {
                    cmbBox.Items.Add(city.name);
                    cmbBox.SelectedIndex = 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var comboBoxes = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("comboBox")).Reverse();
            foreach (var cmbBox in comboBoxes)
            {
                if (cmbBox.Text != NotSelected)
                {
                    City selected = cities.Find(u => u.name == cmbBox.Text);
                    connect.AddVendor(textBox1.Text, textBox2.Text, selected.id);
                }
            }
            MessageBox.Show("Eklendi!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
