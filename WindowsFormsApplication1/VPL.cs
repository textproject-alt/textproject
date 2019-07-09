using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class VPL : Form
    {
        public VPL()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ohm form1 = new Ohm();
            this.Hide();
            form1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VRD form4 = new VRD();
            form4.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RSI form2 = new RSI();
            form2.Show();
            this.Hide();
        }

      

        private void button9_Click(object sender, EventArgs e)
        {
            Setting form5 = new Setting();
            form5.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Help form6 = new Help();
            form6.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"G:\vs2008\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\图片6.png");
        }
       
       
       

       
    }
}
