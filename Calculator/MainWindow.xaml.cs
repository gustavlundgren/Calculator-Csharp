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
    public partial class MainWindow : Window
    {
        public float num1;
        public bool first = true;
        public float num2;
        public string tempNum;
        public float sum;

        public bool plus;
        public bool minus;
        public bool div;
        public bool mult;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 1;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 1);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();
            }
            else
            {
                if (num2 == 0)
                {
                    num2 = 1;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 1);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 2;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 2);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();
            }
            else
            {
                if (num2 == 0)
                {
                    num2 = 2;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 2);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 3;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 3);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();
            }
            else
            {
                if (num2 == 0)
                {
                    num2 = 3;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 3);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 4;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 4);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();

            }
            else
            {
                if (num2 == 0)
                {
                        num2 = 4;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 4);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 5;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 5);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();

            }
            else
            {
                if (num2 == 0)
                {
                    num2 = 5;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 5);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();

            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 6;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 6);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();

            }
            else
            {
                if (num2 == 0)
                {
                    num2 = 6;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 6);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();

            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 7;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 7);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();

            }
            else
            {
                if (num2 == 0)
                {
                    num2 = 7;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 7);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 8;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 8);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();

            }
            else
            {
                if (num2 == 0)
                {
                    num2 = 8;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 8);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();

            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 9;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 9);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();
            }
            else
            {
                if (num2 == 0)
                {
                    num2 = 9;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 9);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();

            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (first)
            {
                if (num1 == 0)
                {
                    num1 = 0;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num1, 0);
                    num1 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num1.ToString();

            }
            else
            {
                if (num2 == 0)
                {
                    num2 = 0;
                }
                else
                {
                    tempNum = string.Format("{0}{1}", num2, 0);
                    num2 = Convert.ToInt32(tempNum);
                }

                resultText.Text = num2.ToString();

            }
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            if (num1 != 0)
            {
                first = false;

                tempNum = "";

                plus = true;
            }
        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            if (num1 != 0)
            {
                first = false;

                tempNum = "";

                minus = true;
            }
        }

        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            if (num1 != 0)
            {
                first = false;

                tempNum = "";

                div = true;
            }
        }

        private void Button_Click_Mult(object sender, RoutedEventArgs e)
        {
            if (num1 != 0)
            {
                first = false;

                tempNum = "";

                mult = true;
            }
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            if (plus)
            {
                sum = num1+ num2;
            }

            if (minus)
            {
                sum = num1 - num2;
            }

            if (div)
            {
                sum = num1 / num2;
            }

            if (mult)
            {
                sum = num1 * num2;
            }

            resultText.Text = sum.ToString();
            
            first = true;
            num1 = 0;
            num2 = 0;
            tempNum = "";
            sum = 0;
        }
    }
}