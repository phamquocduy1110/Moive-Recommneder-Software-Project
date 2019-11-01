using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Main_GUI_Form_29_10_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton10_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton9_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton11_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {
                iExit = MessageBox.Show("Confirm if you want to exit", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Error! Check your system", ex);
            }
        }
    }
}
