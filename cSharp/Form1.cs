using System;
using System.Windows.Forms;

namespace cSharp
{
    public partial class Form1 : Form
    {
        public static string tmp;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 버튼입력 
        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            tmp = btn.Text;

            while (true)
            {
                calResult.Text += tmp;

                break;
            }
        }

        public void cal_btn(object sender, EventArgs e)
        {
            char[] textbox = calResult.Text.ToCharArray();
            float[] arrNum = new float[10];
            char[] arrOper = new char[10];
            int numCnt = 0;
            int opCnt = 0;
            int idx = 0;
            float param = 0.01f;
            bool contNum = false;
            bool isCheck = false;
            bool isFloat;


            for (int i = 0; i < textbox.Length; i++)
            {
                string check = arrNum[numCnt].ToString();

                if ((check.Contains(".")) || (isCheck == true))
                    isFloat = true;
                else
                    isFloat = false;

                if ((textbox[i] >= '0') && (textbox[i] <= '9'))
                {
                    if (contNum && isFloat == false)
                    {
                        arrNum[numCnt] = (arrNum[numCnt] * 10) + float.Parse(textbox[i].ToString());
                    }

                    else if (contNum && isFloat == true)
                    {
                        arrNum[numCnt] = (arrNum[numCnt]) + (param * float.Parse(textbox[i].ToString()));
                        param = param * 0.1f;
                    }

                    else
                    {
                        arrNum[numCnt] = float.Parse(textbox[i].ToString());
                    }

                    contNum = true;
                }

                // 소수점 처리하기
                else if (textbox[i] == '.')
                {
                    check += '.';

                    if (textbox[i + 1] != '0')
                        arrNum[numCnt] = (arrNum[numCnt]) + (0.1f * float.Parse(textbox[i + 1].ToString()));
                    else
                        isCheck = true;


                    if ((textbox[i + 1] >= '0') && (textbox[(i + 1)] <= '9'))
                        contNum = true;
                    else
                        contNum = false;
                    i++;
                }

                else
                {
                    param = 0.01f;
                    numCnt++;
                    arrOper[opCnt++] = textbox[i];
                    contNum = false;
                    isCheck = false;
                }
            }

            for (int i = 0; i < arrOper.Length; i++)
            {
                if (arrOper[i] == '*' && arrOper[i + 1] == '-' && calResult.Text.Contains("*-"))
                {
                    arrNum[0] = -(arrNum[0] * arrNum[idx + 2]);

                    idx++;
                    i++;
                }

                else if (arrOper[i] == '/' && arrOper[i + 1] == '-' && calResult.Text.Contains("/-"))
                {
                    arrNum[0] = -(arrNum[0] / arrNum[idx + 2]);

                    idx++;
                    i++;
                }

                else
                {
                    if (arrOper[i] == '+')
                    {
                        arrNum[0] = (arrNum[0] + arrNum[idx + 1]);

                        idx++;
                    }

                    if (arrOper[i] == '-')
                    {
                        arrNum[0] = (arrNum[0] - arrNum[idx + 1]);

                        idx++;
                    }

                    if (arrOper[i] == '*')
                    {
                        arrNum[0] = (arrNum[0] * arrNum[idx + 1]);

                        idx++;
                    }

                    if (arrOper[i] == '/')
                    {
                        arrNum[0] = (arrNum[0] / arrNum[idx + 1]);

                        idx++;
                    }

                }
            }

            calResult.Text = arrNum[0].ToString();

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
        private void clear_btn(object sender, EventArgs e)
        {
            calResult.Text = null;
        }
        public void test_key(object sender, KeyEventArgs e)
        {
            char[] textbox = calResult.Text.ToCharArray();
            float[] arrNum = new float[100];
            char[] arrOper = new char[100];
            int numCnt = 0;
            int opCnt = 0;
            int idx = 0;
            float param = 0.01f;
            bool contNum = false;
            bool isCheck = false;
            bool isFloat;

            // 입력 test parse 하는 부분
            void parse()
            {
                for (int i = 0; i < textbox.Length; i++)
                {
                    string check = arrNum[numCnt].ToString();

                    if ( (check.Contains(".")) || (isCheck == true))
                        isFloat = true;
                    else
                        isFloat = false;

                    if ((textbox[i] >= '0') && (textbox[i] <= '9'))
                    {
                        if (contNum && isFloat == false)
                        { 
                            arrNum[numCnt] = (arrNum[numCnt] * 10) + float.Parse(textbox[i].ToString());
                        }

                        else if (contNum && isFloat == true)
                        {
                            arrNum[numCnt] = (arrNum[numCnt]) + (param * float.Parse(textbox[i].ToString()));
                            param = param * 0.1f;
                        }

                        else
                        { 
                            arrNum[numCnt] = float.Parse(textbox[i].ToString());
                        }

                        contNum = true;
                    }

                    // 소수점 처리하기
                    else if (textbox[i] == '.')
                    {
                        check += '.';
                        if (textbox[i + 1] != '0')
                            arrNum[numCnt] = (arrNum[numCnt]) + (0.1f * float.Parse(textbox[i + 1].ToString()));
                        else
                            isCheck = true;


                        if ((textbox[i + 1] >= '0') && (textbox[(i + 1)] <= '9'))
                            contNum = true;
                        else
                            contNum = false;

                        i++;
                    }

                    else
                    {
                        param = 0.01f;
                        numCnt++;
                        arrOper[opCnt++] = textbox[i];
                        contNum = false;
                        isCheck = false;
                    }
                }
            }

            void cal()
            {
                for (int i = 0; i < arrOper.Length; i++)
                {
                    if (arrOper[i] == '*' && arrOper[i + 1] == '-' && calResult.Text.Contains("*-") )
                    {
                        arrNum[0] = - (arrNum[0] * arrNum[idx + 2]);

                        idx++;
                        i++;
                    }

                    else if (arrOper[i] == '/' && arrOper[i + 1] == '-' && calResult.Text.Contains("/-"))
                    {
                        arrNum[0] = -(arrNum[0] / arrNum[idx + 2]);

                        idx++;
                        i++;
                    }

                    else
                    {
                        if (arrOper[i] == '+')
                        {
                            arrNum[0] = (arrNum[0] + arrNum[idx + 1]);

                            idx++;
                        }

                        if (arrOper[i] == '-')
                        {
                            arrNum[0] = (arrNum[0] - arrNum[idx + 1]);

                            idx++;
                        }

                        if (arrOper[i] == '*')
                        {
                            arrNum[0] = (arrNum[0] * arrNum[idx + 1]);

                            idx++;
                        }

                        if (arrOper[i] == '/')
                        {
                            arrNum[0] = (arrNum[0] / arrNum[idx + 1]);

                            idx++;
                        }

                    }
                }

                calResult.Text = arrNum[0].ToString();

            }

            void backSpace()
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

            switch (e.KeyCode)
            {
                case Keys.Enter:

                    try
                    {
                        parse();

                        cal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "잘못된 수식입니다.");
                    }

                    break;

                case Keys.Back:

                    backSpace();

                    break;

            }
        }
    }
}