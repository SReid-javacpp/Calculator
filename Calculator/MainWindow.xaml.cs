using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    

    public partial class MainWindow : Window
    {

        float num1;
        float ans;
        int count;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Button00_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0 + 0;
        }
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;

        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void ButtonEqu_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void ButtonPer_Click(object sender, EventArgs e)
        {
            //int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            int c = text.Length;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

    }
}
