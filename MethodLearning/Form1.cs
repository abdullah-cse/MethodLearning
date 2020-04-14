using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodLearning
{
    public partial class FormHome : Form
    {
        int number = 0;
        int result = 0;
        public FormHome()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBoxInput.Text);
            textBoxResult.Text = (number * number).ToString();

        }
    }
}
