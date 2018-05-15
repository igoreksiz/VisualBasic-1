using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NulladikCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="Elrejt")
            {
                label1.Hide();
                button1.Text = "Megmutat";
            }
            else
            {
                label1.Show();
                button1.Text = "Elrejt";
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Int32 HolX;
            Int32 HolY;

            HolX = (this.Width - label1.Width) / 2;
            HolY = (this.ClientSize.Height - label1.Height) / 2;

            label1.SetBounds(HolX, HolY, label1.Width, label1.Height);
        }
    }
}
