using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class Calculate : Form
    {

        public static string sub1, sub2, sub3, sub4, sub5, sub6;
        public static string c1, c2, c3, c4, c5, c6;

        private void txtCM6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCM1.Text = "";
            txtCM2.Text = "";
            txtCM3.Text = "";
            txtCM4.Text = "";
            txtCM5.Text = "";
            txtCM6.Text = "";


            txtCr1.Text = "";
            txtCr2.Text = "";
            txtCr3.Text = "";
            txtCr4.Text = "";
            txtCr5.Text = "";
            txtcr6.Text = "";
            

            txtG1.Text = "";
            txtG2.Text = "";
            txtG3.Text = "";
            txtG4.Text = "";
            txtG5.Text = "";
            txtG6.Text = "";
        }

        public static string g1, g2, g3, g4, g5,g6;

        private void btnCalGpa_Click(object sender, EventArgs e)
        {
            //subjects to label
            sub1 = txtCM1.Text;
            sub2 = txtCM2.Text;
            sub3 = txtCM3.Text;
            sub4 = txtCM4.Text;
            sub5 = txtCM5.Text;
            sub6 = txtCM6.Text;
            

            //credits to label
            c1 = txtCr1.Text;
            c2 = txtCr2.Text;
            c3 = txtCr3.Text;
            c4 = txtCr4.Text;
            c5 = txtCr5.Text;
            c6 = txtcr6.Text;

            //grade to label
            g1 = txtG1.Text;
            g2 = txtG2.Text;
            g3 = txtG3.Text;
            g4 = txtG4.Text;
            g5 = txtG5.Text;
            g6 = txtG6.Text;


            Final_Report fin = new Final_Report();
            fin.Show();

            this.Hide();


        }

        
        public Calculate()
        {
            InitializeComponent();
        }

        private void Calculate_Load(object sender, EventArgs e)
        {
            lblCalName.Text = Form1.name;
            lblCalRegNum.Text = Form1.regNum;
        }
    }
}
