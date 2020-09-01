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
        bool isOpLastInput = false; // is operation last input
        float num1 = 0.0f; // used as placeholder when user is using multiple operations before equaling
        String operand = "", history = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        // Number inputs - first condition is when user wants new number
        // second condition is for when user is continuing a number
        private void Zero(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "0";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "0";
            }
            
        }

        private void One(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "1";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "1";
            }
        }

        private void Two(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "2";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "2";
            }
        }

        private void Three(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "3";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "3";
            }
        }

        private void Four(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "4";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "4";
            }
        }

        private void Five(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "5";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "5";
            }
        }

        private void Six(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "6";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "6";
            }
        }

        private void Seven(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "7";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "7";
            }
        }

        private void Eight(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "8";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "8";
            }
        }

        private void Nine(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || isOpLastInput)
            {
                screen.Text = "9";
                isOpLastInput = false;
            }
            else
            {
                screen.Text += "9";
            }
        }

        private void Sign(object sender, RoutedEventArgs e)
        {
            screen.Text = (float.Parse(screen.Text) * -1).ToString();
        }

        private void Dot(object sender, RoutedEventArgs e)
        {
            if (!screen.Text.Contains("."))
            {
                screen.Text += '.';
            }
        }

        private void Percent(object sender, RoutedEventArgs e)
        {
            screen.Text = (float.Parse(screen.Text) / 100).ToString();
        }

        private void OneOver(object sender, RoutedEventArgs e)
        {
            historyQuickView.Text += "1/(" + screen.Text + ") = ";
            screen.Text = (1 / float.Parse(screen.Text)).ToString();
            history += historyQuickView + " = " + screen.Text;
        }

        private void CE(object sender, RoutedEventArgs e)
        {
            screen.Text = "0";
        }

        private void Square(object sender, RoutedEventArgs e)
        {
            historyQuickView.Text += screen.Text + "² = ";
            screen.Text = Math.Pow(float.Parse(screen.Text), 2).ToString();
            history += historyQuickView + " = " + screen.Text;
        }

        private void C(object sender, RoutedEventArgs e)
        {
            num1 = 0.0f;
            screen.Text = "0";
            historyQuickView.Text = "";
        }

        private void Root(object sender, RoutedEventArgs e)
        {
            historyQuickView.Text += "√(" + screen.Text + ")";
            if (num1 == 0.0f)
            {
                historyQuickView.Text += "=";
            }
            screen.Text = Math.Sqrt(float.Parse(screen.Text)).ToString();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (screen.Text.Length == 1)
            {
                screen.Text = "0";
            }
            else
            {
                screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
            }
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            operand = "/";
            isOpLastInput = true;
            if (num1 == 0.0f)
            {
                //condition where screen number is first input
                historyQuickView.Text = screen.Text + " ÷ ";
                num1 = float.Parse(screen.Text);
            }
            else
            {
                //condition where user presses multiple operations before pressing equal
                historyQuickView.Text += screen.Text + " ÷ ";
                num1 = num1 / float.Parse(screen.Text);
                screen.Text = num1.ToString();
            }
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            
            operand = "x";
            isOpLastInput = true;
            if (num1 == 0.0f)
            {
                //condition where screen number is first input
                historyQuickView.Text = screen.Text + " x ";
                num1 = float.Parse(screen.Text);
            }
            else
            {
                //condition where user presses multiple operations before pressing equal
                historyQuickView.Text += screen.Text + " x ";
                num1 = num1 * float.Parse(screen.Text);
                screen.Text = num1.ToString();
            }
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {
            operand = "-";
            isOpLastInput = true;
            if (num1 == 0.0f)
            {
                //condition where screen number is first input
                historyQuickView.Text = screen.Text + " - ";
                num1 = float.Parse(screen.Text);
            }
            else
            {
                //condition where user presses multiple operations before pressing equal
                historyQuickView.Text += screen.Text + " - ";
                num1 = num1 - float.Parse(screen.Text);
                screen.Text = num1.ToString();
            }
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            operand = "+";
            isOpLastInput = true;
            if (num1 == 0.0f)
            {
                //condition where screen number is first input
                historyQuickView.Text = screen.Text + " + ";
                num1 = float.Parse(screen.Text);
            }
            else
            {
                //condition where user presses multiple operations before pressing equal
                historyQuickView.Text += screen.Text + " + ";
                num1 = num1 + float.Parse(screen.Text);
                screen.Text = num1.ToString();
            }
        }

        private void Equals(object sender, RoutedEventArgs e)
        {
            switch (operand)
            {
                case "x":
                    if (historyQuickView.Text[historyQuickView.Text.Length - 1] != ')')
                    {
                        historyQuickView.Text += screen.Text + " = ";
                    }
                    else
                        historyQuickView.Text += "=";

                    screen.Text = (num1 * float.Parse(screen.Text)).ToString();
                    history += historyQuickView.Text + screen.Text + '\n';
                    num1 = 0.0f;
                    break;
                case "/":
                    historyQuickView.Text += screen.Text + " = ";
                    screen.Text = (num1 / float.Parse(screen.Text)).ToString();
                    history += historyQuickView.Text + screen.Text + '\n';
                    num1 = 0.0f;
                    break;
                case "+":
                    historyQuickView.Text += screen.Text + " = ";
                    screen.Text = (num1 + float.Parse(screen.Text)).ToString();
                    history += historyQuickView.Text + screen.Text + '\n';
                    num1 = 0.0f;
                    break;
                case "-":
                    historyQuickView.Text += screen.Text + " = ";
                    screen.Text = (num1 - float.Parse(screen.Text)).ToString();
                    history += historyQuickView.Text + screen.Text + '\n';
                    num1 = 0.0f;
                    break;
                default:
                    break;
            }
        }


        private void showHistory(object sender, RoutedEventArgs e)
        {
            if (historyCanvas.IsVisible)
            {
                calcWindow.Background = Brushes.AliceBlue;
                screen.Background = Brushes.AliceBlue;
                historyBtn.Background = Brushes.AliceBlue;
                menu.Background = Brushes.AliceBlue;
                historyCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                historyTextBlock.Text = history;
                calcWindow.Background = Brushes.Gray;
                screen.Background = Brushes.Gray;
                historyBtn.Background = Brushes.Gray;
                menu.Background = Brushes.Gray;
                historyCanvas.Visibility = Visibility.Visible;
            }
        }
    }
}
