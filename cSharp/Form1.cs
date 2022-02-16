using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp
{
    public partial class Form1 : Form
    {
        public static string tmp;

        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("계산기 예시입니다.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            tmp = "+";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            tmp = "-";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            tmp = "/";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            tmp = "*";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }
        }
        public void cal_btn(object sender, EventArgs e)
        {
            string[] sumSplit = calResult.Text.Split('+');
            double result = 0;

            for (int i = 0; i < sumSplit.Length; i++)
            {
                string[] subSplit = sumSplit[i].Split('-');
                double subSplitResult = 0;

                for (int j = 0; j < subSplit.Length; j++)
                {
                    string[] mulSplit = subSplit[j].Split('*');
                    double mulSplitResult = 0;

                    for (int k = 0; k < mulSplit.Length; k++)
                    {
                        string[] divSplit = mulSplit[k].Split('/');
                        double divSplitResult = 0;

                        for (int l = 0; l < divSplit.Length; l++)
                        {
                            if (l == 0)
                                divSplitResult += Convert.ToDouble(divSplit[l]);
                            else
                                divSplitResult /= Convert.ToDouble(divSplit[l]);
                        }

                        mulSplit[k] = divSplitResult.ToString();

                        if (k == 0)
                            mulSplitResult += Convert.ToDouble(mulSplit[k]);
                        else
                            mulSplitResult *= Convert.ToDouble(mulSplit[k]);
                    }

                    subSplit[j] = mulSplitResult.ToString();

                    if (j == 0)
                        subSplitResult += Convert.ToDouble(subSplit[j]);
                    else
                        subSplitResult -= Convert.ToDouble(subSplit[j]);
                }

                sumSplit[i] = subSplitResult.ToString();


                result += Convert.ToDouble(sumSplit[i]);
            }

            calResult.Text = result.ToString();
        }
        private void clear_btn(object sender, EventArgs e)
        {
            calResult.Text = null;
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            tmp = "1";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }

        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            tmp = "2";


            while (true)
            {
                calResult.Text += tmp;

                break;
            }

        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            tmp = "3";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }

        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            tmp = "4";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }

        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            tmp = "5";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }

        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            tmp = "6";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }

        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            tmp = "7";

            while (true)
            {
                calResult.Text += tmp;

                break;
            }

        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            tmp = "8";

            while (true)
            {
                calResult.Text += tmp;
                break;
            }

        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            tmp = "9";

            while (true)
            {
                calResult.Text += tmp;
                break;

            }

        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            tmp = "0";

            while (true)
            {
                calResult.Text += tmp;
                break;
            }
        }

        private void remove_btn(object sender, EventArgs e)
        {
            while (true)
            {
                string test = calResult.Text;

                if (test.Length > 0)
                {
                    calResult.Text = test.Substring(0, test.Length - 1);
                    break;
                }
                else
                    break;
            }
        }

        public void test_key(object sender, KeyEventArgs e)
        {
            void cal_btn()
            {
                string[] sumSplit = calResult.Text.Split('+');
                double result = 0;

                for (int i = 0; i < sumSplit.Length; i++)
                {
                    string[] subSplit = sumSplit[i].Split('-');
                    double subSplitResult = 0;

                    for (int j = 0; j < subSplit.Length; j++)
                    {
                        string[] mulSplit = subSplit[j].Split('*');
                        double mulSplitResult = 0;

                        for (int k = 0; k < mulSplit.Length; k++)
                        {
                            string[] divSplit = mulSplit[k].Split('/');
                            double divSplitResult = 0;

                            for (int l = 0; l < divSplit.Length; l++)
                            {
                                if (l == 0)
                                    divSplitResult += Convert.ToDouble(divSplit[l]);
                                else
                                    divSplitResult /= Convert.ToDouble(divSplit[l]);
                            }

                            mulSplit[k] = divSplitResult.ToString();

                            if (k == 0)
                                mulSplitResult += Convert.ToDouble(mulSplit[k]);
                            else
                                mulSplitResult *= Convert.ToDouble(mulSplit[k]);
                        }

                        subSplit[j] = mulSplitResult.ToString();

                        if (j == 0)
                            subSplitResult += Convert.ToDouble(subSplit[j]);
                        else
                            subSplitResult -= Convert.ToDouble(subSplit[j]);
                    }

                    sumSplit[i] = subSplitResult.ToString();


                    result += Convert.ToDouble(sumSplit[i]);
                }

                calResult.Text = result.ToString();
            }
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    cal_btn();
                    break;
            }
        }
    }
}
