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
    

    public partial class Form1 : Form
    {

        public static string regNum;
        public static string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRegNum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            regNum = txtRegNum.Text;


            Calculate cal = new Calculate();
            cal.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_Us about = new About_Us();
            about.Show();

            this.Hide();
        }
    }
}
