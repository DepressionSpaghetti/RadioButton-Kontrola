using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radAvion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void brnRezerviraj_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            if (radAvion.Checked) txtBox.AppendText("Odabrali ste prijevoz avionom.");
            if (radAutobus.Checked) txtBox.AppendText("Odabrali ste prijevoz autobusom.");
            if (radVprijevoz.Checked) txtBox.AppendText("Odabrali ste prijevoz vlastitim vozilom.");

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
