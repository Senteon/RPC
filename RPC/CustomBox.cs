using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPCs;

namespace CustomMessageBox
{
    public partial class CustomBox : Form
    {
        private RPC other;
        public CustomBox(Form callingForm, string boxText, string buttonText1, string buttonText2, string buttonText3, string buttonText4)
        {
            InitializeComponent();
            other = callingForm as RPC;
            textBox1.Text = boxText;
            button1.Text = buttonText1;
            button2.Text = buttonText2;
            button3.Text = buttonText3;
            button4.Text = buttonText4;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            other.setChoice(1);
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            other.setChoice(2);
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            other.setChoice(3);
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            other.setChoice(4);
            this.Close();
        }
    }
}
