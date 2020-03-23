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
    public partial class CreateCompound : Form {

        Sql sql = new Sql();
        List<Element> elements = new List<Element>();
        const string NotSelected = "Not Selected";
        public CreateCompound() {
            InitializeComponent();
            elements = sql.GetElements();
            var comboBoxes = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("comboBox"));
            foreach (var cmbBox in comboBoxes) {
                cmbBox.Items.Add(NotSelected);
                foreach (var element in elements) {
                    cmbBox.Items.Add(element.name);
                    cmbBox.SelectedIndex = 0;
                }
            }
        }

        private void CreateCompound_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            var comboBoxes = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("comboBox")).Reverse();
            var numericUpDowns = this.Controls.OfType<NumericUpDown>().Where(x => x.Name.StartsWith("numericUpDown")).Reverse();
            int maxID = sql.MaxIDCompound() + 1;
            int index = 0;
            foreach (var cmbBox in comboBoxes) {
                if(cmbBox.Text != NotSelected) {
                    Element selected = elements.Find(u => u.name == cmbBox.Text);
                    sql.AddElementToCompound(maxID, selected.id, (int)numericUpDowns.ElementAt(index).Value);
                }
                index++;
            }
            MessageBox.Show("Eklendi!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
