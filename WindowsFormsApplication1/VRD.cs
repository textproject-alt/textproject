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
    public partial class VRD : Form
    {
        public VRD()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VPL form3 = new VPL();
            form3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ohm form1 = new Ohm();
            form1.Show();
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

      
       
        }

       
      

      
     

      
    
}
