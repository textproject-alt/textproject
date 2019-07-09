using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using System.IO;
using AForge.Controls;

namespace WindowsFormsApplication1
{
    public partial class Ohm : Form
    {
        public Ohm()
        {
            InitializeComponent();
    
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            VPL form3 = new VPL();
            form3.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

     

       
      

      
     

        

        

        

      

      
     

      

      

      
    }
}
