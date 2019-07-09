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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ohm form1 = new Ohm();
            form1.Show();
            this.Hide();
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

        private void button10_Click(object sender, EventArgs e)
        {
            Help form6 = new Help();
            form6.Show();
            this.Hide();
        }


     
     

        private void button4_Click(object sender, EventArgs e)
        {
            
           initial initial = new initial();
            initial.Show();
            this.Hide();   
            
        }


        private void button1_Click(object sender, EventArgs e)
        {           
            calibration cali = new calibration();
            cali.Show();
            this.Hide();
        }


        private void Setting_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Size = panel1.Size;
            panel3.Size = panel1.Size;
            panel4.Size = panel1.Size;
            panel2.Location = panel1.Location;
            panel3.Location = panel1.Location;
            panel4.Location = panel1.Location;
            panel1.BringToFront();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.BringToFront();
            initial initial = new initial();
            initial.TopLevel = false;
            initial.Parent = panel2;
            panel2.Controls.Add(initial);
            initial.Show();

        }

        public void SetPanelVisible()
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel1.BringToFront();
        
        }

        private void button4_MouseDown_1(object sender, MouseEventArgs e)
        {
            button4.Image = Image.FromFile(@"G:\vs2008\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\图片11.png");
        }

        private void button1_MouseDown_1(object sender, MouseEventArgs e)
        {
            button1.Image = Image.FromFile(@"G:\vs2008\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\图片26.png");
        }

        private void button2_MouseDown_1(object sender, MouseEventArgs e)
        {
            button2.Image = Image.FromFile(@"G:\vs2008\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\图片27.png");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            panel3.BringToFront();
            calibration cali = new calibration();
            cali.TopLevel = false;
            cali.Parent = panel3;
            panel3.Controls.Add(cali);
            cali.Show();



        }

        public void SetPanel3Visible()
        {
            panel1.Visible = true;
            panel3.Visible = false;
            panel1.BringToFront();
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel1.Visible = false;
            panel4.BringToFront();
            Newpassword pwd = new Newpassword();
            pwd.TopLevel = false;
            pwd.Parent = panel4;
            panel4.Controls.Add(pwd);
            pwd.Show();


        }

        public void SetPanel4Visible()
        {
            panel1.Visible = true;
            panel4.Visible = false;
            panel1.BringToFront();

        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片10.png");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片28.png");
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Image = Image.FromFile(@"G:\vs2008\Projects\LeiDaJinorderproject2\LeiDaJinorderproject2\Resources\图片29.png");
        }
    }
}
