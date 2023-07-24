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
    public partial class Final_Report : Form
    {
        int cr1, cr2, cr3, cr4, cr5,cr6;
        string sub1;
        string sub2;
        string sub3;
        string sub4;
        string sub5;
        string sub6;

       

        double totalGpa;
        double finalGpa;

        string gpaString;
        string classGpa;

        int crTotal;
        
        

        public static double gpaS1, gpaS2, gpaS3, gpaS4, gpaS5, gpaS6;
        

        private void btnCalAgain_Click(object sender, EventArgs e)
        {
            Form1 fff = new Form1();
            fff.Show();

            this.Hide();
        }

        public Final_Report()
        {
            InitializeComponent();
        }

        private void Final_Report_Load(object sender, EventArgs e)
        {
            lblFinName.Text = Form1.name;
            lblFinRegNum.Text = Form1.regNum;

            //subjects
            lblFinSub1.Text = Calculate.sub1;
            lblFinSub2.Text = Calculate.sub2;
            lblFinSub3.Text = Calculate.sub3;
            lblFinSub4.Text = Calculate.sub4;
            lblFinSub5.Text = Calculate.sub5;
            lblFinSub6.Text = Calculate.sub6;


            //Grades
            lblFinGr1.Text = Calculate.g1.ToUpper();
            lblFinGr2.Text = Calculate.g2.ToUpper();
            lblFinGr3.Text = Calculate.g3.ToUpper();
            lblFinGr4.Text = Calculate.g4.ToUpper();
            lblFinGr5.Text = Calculate.g5.ToUpper();
            lblFinGr6.Text = Calculate.g6.ToUpper();


            Type_Converts();

            upperCase();

            subCal1();
            subCal2();
            subCal3();
            subCal4();
            subCal5();
            subCal6();
            



            calculateGpa();

            lblFinGPA.Text = gpaString;

            gpaClass();

            lblgpaClass.Text = classGpa;

        }


        private void subCal1()
        {
            if (sub1.Equals("A+")){
                gpaS1 = 4.0 * cr1;
            }
            else if (sub1.Equals("A"))
            {
                gpaS1 = 4.0 * cr1;
            }
            else if (sub1.Equals("A-"))
            {
                gpaS1 = 3.7 * cr1;

            }
            else if (sub1.Equals("B+"))
            {
                gpaS1 = 3.3 * cr1;
            }
            else if (sub1.Equals("B"))
            {
                gpaS1 = 3.0 * cr1;
            }
            else if (sub1.Equals("B-"))
            {
                gpaS1 = 2.7 * cr1;
            }
            else if (sub1.Equals("C+"))
            {
                gpaS1 = 2.3 * cr1;
            }
            else if (sub1.Equals("C"))
            {
                gpaS1 = 2.0 * cr1;
            }
            else if (sub1.Equals("C-"))
            {
                gpaS1 = 1.7 * cr1;
            }
            else if (sub1.Equals("D+"))
            {
                gpaS1 = 1.3 * cr1;
            }
            else if (sub1.Equals("D"))
            {
                gpaS1 = 1.0 * cr1;
            }
            else
            {
                gpaS1 = 0 * cr1;
            }
        }

        private void subCal2()
        {
            if (sub2.Equals("A+"))
            {
                gpaS2 = 4.0 * cr2;
            }
            else if (sub2.Equals("A"))
            {
                gpaS2 = 4.0 * cr2;
            }
            else if (sub2.Equals("A-"))
            {
                gpaS2 = 3.7 * cr2;

            }
            else if (sub2.Equals("B+"))
            {
                gpaS2 = 3.3 * cr2;
            }
            else if (sub2.Equals("B"))
            {
                gpaS2 = 3.0 * cr2;
            }
            else if (sub2.Equals("B-"))
            {
                gpaS2 = 2.7 * cr2;
            }
            else if (sub2.Equals("C+"))
            {
                gpaS2 = 2.3 * cr2;
            }
            else if (sub2.Equals("C"))
            {
                gpaS2 = 2.0 * cr2;
            }
            else if (sub2.Equals("C-"))
            {
                gpaS2 = 1.7 * cr2;
            }
            else if (sub2.Equals("D+"))
            {
                gpaS2 = 1.3 * cr2;
            }
            else if (sub2.Equals("D"))
            {
                gpaS2 = 1.0 * cr2;
            }
            else
            {
                gpaS2 = 0 * cr2;
            }
        }

        private void subCal3()
        {
            if (sub3.Equals("A+"))
            {
                gpaS3 = 4.0 * cr3;
            }
            else if (sub3.Equals("A"))
            {
                gpaS3 = 4.0 * cr3;
            }
            else if (sub3.Equals("A-"))
            {
                gpaS3 = 3.7 * cr3;

            }
            else if (sub3.Equals("B+"))
            {
                gpaS3 = 3.3 * cr3;
            }
            else if (sub3.Equals("B"))
            {
                gpaS3 = 3.0 * cr3;
            }
            else if (sub3.Equals("B-"))
            {
                gpaS3 = 2.7 * cr3;
            }
            else if (sub3.Equals("C+"))
            {
                gpaS3 = 2.3 * cr3;
            }
            else if (sub3.Equals("C"))
            {
                gpaS3 = 2.0 * cr3;
            }
            else if (sub3.Equals("C-"))
            {
                gpaS3 = 1.7 * cr3;
            }
            else if (sub3.Equals("D+"))
            {
                gpaS3 = 1.3 * cr3;
            }
            else if (sub3.Equals("D"))
            {
                gpaS3 = 1.0 * cr3;
            }
            else
            {
                gpaS3 = 0 * cr3;
            }
        }

        private void subCal4()
        {
            if (sub4.Equals("A+"))
            {
                gpaS4 = 4.0 * cr4;
            }
            else if (sub4.Equals("A"))
            {
                gpaS4 = 4.0 * cr4;
            }
            else if (sub4.Equals("A-"))
            {
                gpaS4 = 3.7 * cr4;

            }
            else if (sub4.Equals("B+"))
            {
                gpaS4 = 3.3 * cr4;
            }
            else if (sub4.Equals("B"))
            {
                gpaS4 = 3.0 * cr4;
            }
            else if (sub4.Equals("B-"))
            {
                gpaS4 = 2.7 * cr4;
            }
            else if (sub4.Equals("C+"))
            {
                gpaS4 = 2.3 * cr4;
            }
            else if (sub4.Equals("C"))
            {
                gpaS4 = 2.0 * cr4;
            }
            else if (sub4.Equals("C-"))
            {
                gpaS4 = 1.7 * cr4;
            }
            else if (sub4.Equals("D+"))
            {
                gpaS4 = 1.3 * cr4;
            }
            else if (sub4.Equals("D"))
            {
                gpaS4 = 1.0 * cr4;
            }
            else
            {
                gpaS4 = 0 * cr4;
            }
        }

        private void subCal5()
        {
            if (sub5.Equals("A+"))
            {
                gpaS5 = 4.0 * cr5;
            }
            else if (sub5.Equals("A"))
            {
                gpaS5 = 4.0 * cr5;
            }
            else if (sub5.Equals("A-"))
            {
                gpaS5 = 3.7 * cr5;

            }
            else if (sub5.Equals("B+"))
            {
                gpaS5 = 3.3 * cr5;
            }
            else if (sub5.Equals("B"))
            {
                gpaS5 = 3.0 * cr5;
            }
            else if (sub5.Equals("B-"))
            {
                gpaS5 = 2.7 * cr5;
            }
            else if (sub5.Equals("C+"))
            {
                gpaS5 = 2.3 * cr5;
            }
            else if (sub5.Equals("C"))
            {
                gpaS5 = 2.0 * cr5;
            }
            else if (sub5.Equals("C-"))
            {
                gpaS5 = 1.7 * cr5;
            }
            else if (sub5.Equals("D+"))
            {
                gpaS5 = 1.3 * cr5;
            }
            else if (sub5.Equals("D"))
            {
                gpaS5 = 1.0 * cr5;
            }
            else
            {
                gpaS5 = 0 * cr5;
            }
        }

        private void subCal6()
        {
            if (sub6.Equals("A+"))
            {
                gpaS6 = 4.0 * cr6;
            }
            else if (sub6.Equals("A"))
            {
                gpaS6 = 4.0 * cr6;
            }
            else if (sub6.Equals("A-"))
            {
                gpaS6 = 3.7 * cr6;

            }
            else if (sub6.Equals("B+"))
            {
                gpaS6 = 3.3 * cr6;
            }
            else if (sub6.Equals("B"))
            {
                gpaS6 = 3.0 * cr6;
            }
            else if (sub6.Equals("B-"))
            {
                gpaS6 = 2.7 * cr6;
            }
            else if (sub6.Equals("C+"))
            {
                gpaS6 = 2.3 * cr6;
            }
            else if (sub6.Equals("C"))
            {
                gpaS6 = 2.0 * cr6;
            }
            else if (sub6.Equals("C-"))
            {
                gpaS6 = 1.7 * cr6;
            }
            else if (sub6.Equals("D+"))
            {
                gpaS6 = 1.3 * cr6;
            }
            else if (sub6.Equals("D"))
            {
                gpaS6 = 1.0 * cr6;
            }
            else
            {
                gpaS6 = 0 * cr6;
            }
        }

        private void calculateGpa()
        {
            totalGpa = gpaS1 + gpaS2 + gpaS3 + gpaS4 + gpaS5+gpaS6;
            crTotal = cr1 + cr2 + cr3 + cr4 + cr5+cr6;
            finalGpa = totalGpa / crTotal;

            gpaString = finalGpa.ToString();
        }

        private void gpaClass()
        {
            if (finalGpa >= 3.7)
            {
                classGpa = "(First Class)";
            }
            else if(finalGpa>=3.3 && finalGpa < 3.7)
            {
                classGpa = "(Second Class (Upper Devision))";
            }
            else if(finalGpa>=3.0 && finalGpa < 3.3)
            {
                classGpa = "(Second Class (Lower Devision))";
            }
            else
            {
                classGpa = "(General)";
            }
        }


        private void Type_Converts()
        {
            cr1 = Int32.Parse(Calculate.c1);
            cr2 = Int32.Parse(Calculate.c2);
            cr3 = Int32.Parse(Calculate.c3);
            cr4 = Int32.Parse(Calculate.c4);
            cr5 = Int32.Parse(Calculate.c5);
            cr6= Int32.Parse(Calculate.c6);

           
        }

        private void upperCase()
        {
            sub1 = Calculate.g1.ToUpper();
            sub2 = Calculate.g2.ToUpper();
            sub3 = Calculate.g3.ToUpper();
            sub4 = Calculate.g4.ToUpper();
            sub5 = Calculate.g5.ToUpper();
            sub6= Calculate.g6.ToUpper();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
