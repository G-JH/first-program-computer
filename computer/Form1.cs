using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer
{
    public partial class Form1 : Form
    {
        public double FirstNumber = 0, SecondNumber = 0;
        public int a = 0;
        public bool leap = false, result = false, bug = true,dian=false,dou=false;

        private void BackSpace_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                if (result == false)
                {
                    if (Output.Text.Length == 1) Output.Text = "0";
                    else
                    {
                        Output.Text = Output.Text.Substring(0, Output.Text.Length - 1);
                        if (Output.Text == "-") Output.Text = "0";
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void OppNmb_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                if (dou == false)
                {
                    FirstNumber = Convert.ToDouble(Output.Text);
                    Output.Text = (-FirstNumber).ToString();
                }
                else
                {
                    FirstNumber = Convert.ToDouble(Output.Text);
                    if (FirstNumber != 0)
                    {
                        Output.Text = (-FirstNumber).ToString();
                        Output.Text += ".";
                    }
                    else
                    {
                        if (Output.Text == "-0.") Output.Text = "0.";
                        else if(Output .Text =="0.") Output.Text = "-0.";
                    }
                }
            }
        }

        private void Recip_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                FirstNumber = Convert.ToDouble(Output.Text);
                if (FirstNumber != 0) Output.Text = (1 / FirstNumber).ToString();
                else
                {
                    Output.Text = "除数不能为零";
                    bug = false;
                }
                dou = false;
                if (Output.Text.IndexOf(".") == -1) dian = true;
                result = true;
            }
        }

        private void Square_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                FirstNumber = Convert.ToDouble(Output.Text);
                Output.Text = (FirstNumber * FirstNumber).ToString();
                dou = false;
                if (Output.Text.IndexOf(".") == -1) dian = true;
                result = true;
            }
        }

        private void Root_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                FirstNumber = Convert.ToDouble(Output.Text);
                if (FirstNumber >= 0) Output.Text = Math.Sqrt(FirstNumber).ToString();
                else
                {
                    Output.Text = "无效输入";
                    bug = false;
                }
                dou = false;
                if (Output.Text.IndexOf(".") == -1) dian = true;
                result = true;
            }
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                FirstNumber = Convert.ToDouble(Output.Text);
                Output.Text = (FirstNumber / 100).ToString();
                dou = false;
                if (Output.Text.IndexOf(".") == -1) dian = true;
                result = true;
            }
        }

        private void Equel_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                if (a != 0)
                {
                    if (result == false)
                    {
                        if (leap == false)
                        {
                            SecondNumber = Convert.ToDouble(Output.Text);
                            if (SecondNumber != 0)
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                                    case (4): Output.Text = (FirstNumber / SecondNumber).ToString(); break;
                                }
                                FirstNumber = Convert.ToDouble(Output.Text);
                            }
                            else
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); FirstNumber = Convert.ToDouble(Output.Text); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); FirstNumber = Convert.ToDouble(Output.Text); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); FirstNumber = Convert.ToDouble(Output.Text); break;
                                    case (4): Output.Text = "除数不能为零"; bug = false; break;
                                }
                            }
                            leap = false;
                            result = true;
                        }
                        else
                        {
                            switch (a)
                            {
                                case 1: Output.Text = (FirstNumber + FirstNumber).ToString(); break;
                                case 2: Output.Text = (FirstNumber - FirstNumber).ToString(); break;
                                case 3: Output.Text = (FirstNumber * FirstNumber).ToString(); break;
                                case 4: if (FirstNumber == 0) Output.Text = "结果未定义"; else { Output.Text = (FirstNumber / FirstNumber).ToString();bug = true; } break;
                            }
                            SecondNumber = FirstNumber;
                            leap = false;
                            result = true;
                        }
                    }
                    else
                   {
                        switch (a)
                        {
                            case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                            case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                            case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                            case (4): Output.Text = (FirstNumber / SecondNumber).ToString(); break;
                        }
                        FirstNumber = Convert.ToDouble(Output.Text);
                    }
                }
            }
        }

        private void Miuns_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                if (a == 0)
                {
                    FirstNumber = Convert.ToDouble(Output.Text);
                    a = 2;
                    leap = true;
                    result = false;
                }
                else
                {
                    if (result == false)
                    {
                        if (leap == false)
                        {
                            SecondNumber = Convert.ToDouble(Output.Text);
                            if (SecondNumber != 0)
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                                    case (4): Output.Text = (FirstNumber / SecondNumber).ToString(); break;
                                }
                            }
                            else
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                                    case (4): Output.Text = "除数不能为零"; bug = false; break;
                                }
                            }
                            FirstNumber = Convert.ToDouble(Output.Text);
                            leap = true;
                            a = 2;
                        }
                        else a = 2;
                    }
                    else
                    {
                        FirstNumber = Convert.ToDouble(Output.Text);
                        leap = true;
                        a = 2;
                        result = false;
                    }
                }
                dian = false;
                dou = false;
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                if (a == 0)
                {
                    FirstNumber = Convert.ToDouble(Output.Text);
                    a = 3;
                    leap = true;
                    result = false;
                }
                else
                {
                    if (result == false)
                    {
                        if (leap == false)
                        {
                            SecondNumber = Convert.ToDouble(Output.Text);
                            if (SecondNumber != 0)
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                                    case (4): Output.Text = (FirstNumber / SecondNumber).ToString(); break;
                                }
                            }
                            else
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                                    case (4): Output.Text = "除数不能为零"; bug = false; break;
                                }
                            }
                            FirstNumber = Convert.ToDouble(Output.Text);
                            leap = true;
                            a = 3;
                        }
                        else a = 3;
                    }
                    else
                    {
                        FirstNumber = Convert.ToDouble(Output.Text);
                        leap = true;
                        a = 3;
                        result = false;
                    }
                }
                dian = false;
                dou = false;
            }
        }

        private void Devide_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                if (a == 0)
                {
                    FirstNumber = Convert.ToDouble(Output.Text);
                    a = 4;
                    leap = true;
                    result = false;
                }
                else
                {
                    if (result == false)
                    {
                        if (leap == false)
                        {
                            SecondNumber = Convert.ToDouble(Output.Text);
                            if (SecondNumber != 0)
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                                    case (4): Output.Text = (FirstNumber / SecondNumber).ToString(); break;
                                }
                            }
                            else
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                                    case (4): Output.Text = "除数不能为零"; bug = false; break;
                                }
                            }
                            FirstNumber = Convert.ToDouble(Output.Text);
                            leap = true;
                            a = 4;
                        }
                        else a = 4;
                    }
                    else
                    {
                        FirstNumber = Convert.ToDouble(Output.Text);
                        leap = true;
                        a = 4;
                        result = false;
                    }
                }
                dian = false;
                dou = false;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                if (a == 0)
                {
                    FirstNumber = Convert.ToDouble(Output.Text);
                    a = 1;
                    leap = true;
                    result = false;
                }
                else
                {
                    if (leap == false)
                    {

                        if (result == false)
                        {
                            SecondNumber = Convert.ToDouble(Output.Text);
                            if (SecondNumber != 0)
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                                    case (4): Output.Text = (FirstNumber / SecondNumber).ToString(); break;
                                }
                            }
                            else
                            {
                                switch (a)
                                {
                                    case (1): Output.Text = (FirstNumber + SecondNumber).ToString(); break;
                                    case (2): Output.Text = (FirstNumber - SecondNumber).ToString(); break;
                                    case (3): Output.Text = (FirstNumber * SecondNumber).ToString(); break;
                                    case (4): Output.Text = "除数不能为零"; bug = false; break;
                                }
                            }
                            FirstNumber = Convert.ToDouble(Output.Text);
                            leap = true;
                        }
                        else
                        {
                            FirstNumber = Convert.ToDouble(Output.Text);
                            leap = true;
                            a = 1;
                            result = false;
                        }
                        a = 1;
                    }
                    else a = 1;
                }
                dian = false;
                dou = false;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                if (result == true || leap == true)
                {
                    Output.Text = "0.";
                    dian = true;
                    dou = true;
                    result = false;
                    leap = false;
                }
                else
                {
                    if (dian == false)
                    {
                        Output.Text += ".";
                        dian = true;
                        dou = true;
                    }
                }
            }
        }

        private void ReLoad_Click(object sender, EventArgs e)
        {
            if (bug == true) Output.Text = "0";
            else
            {
                FirstNumber = 0;
                SecondNumber = 0;
                a = 0;
                leap = false;
                result = false;
                Output.Text = "0";
                bug = true;
            }
            dou = false;
            dian = false;
        }

        private void ReturnZero_Click(object sender, EventArgs e)
        {
            FirstNumber = 0;
            SecondNumber = 0;
            a = 0;
            leap = false;
            result = false;
            Output.Text = "0";
            bug = true;
            dou = false;
            dian = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (bug == true)
            {
                if (result == false)
                {
                    Button But = (Button)sender;
                    if (Output.Text == "0") Output.Text = But.Text;
                    else
                    {
                        if (leap == true) Output.Text = But.Text;
                        else
                        {
                            Output.Text += But.Text;
                            dou = false;
                        }
                    }
                    leap = false;
                    result = false;
                }
                else
                {
                    FirstNumber = 0;
                    SecondNumber = 0;
                    a = 0;
                    leap = false;
                    result = false;
                    Button But = (Button)sender;
                    Output.Text = But.Text;
                    dou = false;
                }
            }
        }
    }
}
