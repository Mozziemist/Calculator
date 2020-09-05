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
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isOpLastInput = false; // is operation last input
        bool prePrinted = false; //cases where operation self prints to quickView (ex: root)
        bool windowSizeChanged = false;
        double num1 = 0.0d; // used as placeholder when user is using multiple operations before equaling
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
            screen.Text = (double.Parse(screen.Text) / 100).ToString();
            historyQuickView.Text += screen.Text;
            prePrinted = true;
        }

        private void OneOver(object sender, RoutedEventArgs e)
        {
            if (prePrinted)
            {
                historyQuickView.Text = "";
            }
            historyQuickView.Text += "1/(" + screen.Text + ")";
            prePrinted = true;
            screen.Text = (1 / double.Parse(screen.Text)).ToString();
        }

        private void CE(object sender, RoutedEventArgs e)
        {
            screen.Text = "0";
        }

        private void Square(object sender, RoutedEventArgs e)
        {
            if (prePrinted)
            {
                historyQuickView.Text = "";
            }
            historyQuickView.Text += screen.Text + "²";
            prePrinted = true;
            screen.Text = Math.Pow(double.Parse(screen.Text), 2).ToString();
        }

        private void C(object sender, RoutedEventArgs e)
        {
            num1 = 0.0f;
            screen.Text = "0";
            historyQuickView.Text = "";
            isOpLastInput = false;
            operand = "";
            prePrinted = false;
        }

        private void Root(object sender, RoutedEventArgs e)
        {
            if (prePrinted)
            {
                historyQuickView.Text = "";
            }
            historyQuickView.Text += "√(" + screen.Text + ")";
            prePrinted = true;
            screen.Text = Math.Sqrt(double.Parse(screen.Text)).ToString();
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
            if (historyQuickView.Text.Contains("="))
            {
                historyQuickView.Text = "";
            }
            if (!prePrinted)
            {
                historyQuickView.Text += screen.Text + " ÷ ";
            }
            else
            {
                historyQuickView.Text += " ÷ ";
                prePrinted = false;
            }

            //Solve frontside of problem
            if (num1 != 0.0d && operand != "")
            {
                //print ans to scrn
                screen.Text = Solve(num1, double.Parse(screen.Text), operand).ToString();
            }

            //Setup backside of problem
            num1 = double.Parse(screen.Text);
            operand = "/";
            isOpLastInput = true;
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            if (historyQuickView.Text.Contains("="))
            {
                historyQuickView.Text = "";
            }
            if (!prePrinted)
            {
                historyQuickView.Text += screen.Text + " x ";
            }
            else
            {
                historyQuickView.Text += " x ";
                prePrinted = false;
            }

            //Solve frontside of problem
            if (num1 != 0.0d && operand != "")
            {
                //print ans to scrn
                screen.Text = Solve(num1, double.Parse(screen.Text), operand).ToString();
            }

            //Setup backside of problem
            num1 = double.Parse(screen.Text);
            operand = "x";
            isOpLastInput = true;
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {
            if (historyQuickView.Text.Contains("="))
            {
                historyQuickView.Text = "";
            }
            if (!prePrinted)
            {
                historyQuickView.Text += screen.Text + " - ";
            }
            else
            {
                historyQuickView.Text += " - ";
                prePrinted = false;
            }

            //Solve frontside of problem
            if (num1 != 0.0d && operand != "")
            {
                //print ans to scrn
                screen.Text = Solve(num1, double.Parse(screen.Text), operand).ToString();
            }

            //Setup backside of problem
            num1 = double.Parse(screen.Text);
            operand = "-";
            isOpLastInput = true;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (historyQuickView.Text.Contains("="))
            {
                historyQuickView.Text = "";
            }
            if (!prePrinted)
            {
                historyQuickView.Text += screen.Text + " + ";
            }
            else
            {
                historyQuickView.Text += " + ";
                prePrinted = false;
            }

            //Solve frontside of problem
            if (num1 != 0.0d && operand != "")
            {
                //print ans to scrn
                screen.Text = Solve(num1, double.Parse(screen.Text), operand).ToString();
            }

            //Setup backside of problem
            num1 = double.Parse(screen.Text);
            operand = "+";
            isOpLastInput = true;
        }

        private void Equals(object sender, RoutedEventArgs e)
        {
            if (!prePrinted)
            {
                historyQuickView.Text += screen.Text + " = ";
            }
            else
            {
                historyQuickView.Text += " = ";
            }

            screen.Text = Solve(num1, double.Parse(screen.Text), operand).ToString();
            history += historyQuickView.Text + screen.Text + '\n';
            historyColumnTextBlock.Text += historyQuickView.Text + screen.Text + '\n';
            num1 = double.Parse(screen.Text);
            operand = "";
            prePrinted = false;
        }


        private void ShowHistory(object sender, RoutedEventArgs e)
        {
            if (historyGrid.IsVisible)
            {
                screenCanvas.Visibility = Visibility.Hidden;
                calcWindow.Background = Brushes.AliceBlue;
                screen.Background = Brushes.AliceBlue;
                historyBtn.Background = Brushes.AliceBlue;
                menu.Background = Brushes.AliceBlue;
                historyGrid.Visibility = Visibility.Hidden;
            }
            else
            {
                screenCanvas.Visibility = Visibility.Visible;
                historyTextBlock.Text = history;
                calcWindow.Background = Brushes.Gray;
                screen.Background = Brushes.Gray;
                historyBtn.Background = Brushes.Gray;
                menu.Background = Brushes.Gray;
                historyGrid.Visibility = Visibility.Visible;
            }
        }

        private void DeleteHistory(object sender, RoutedEventArgs e)
        {
            history = "";
            historyTextBlock.Text = "";
            historyColumnTextBlock.Text = "";
        }

        //User decides to press outside history bounds to leave history instead of
        //pressing history button again
        private void HistoryClickOff(object sender, MouseButtonEventArgs e)
        {
            screenCanvas.Visibility = Visibility.Hidden;
            historyGrid.Visibility = Visibility.Hidden;
            calcWindow.Background = Brushes.AliceBlue;
            screen.Background = Brushes.AliceBlue;
            historyBtn.Background = Brushes.AliceBlue;
            menu.Background = Brushes.AliceBlue;
        }

        private void WindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (!historyGrid.IsVisible)
            {
                if (this.Width > 600 && !windowSizeChanged)
                {
                    historyBtn.Visibility = Visibility.Hidden;
                    historyColumnTextBlock.Visibility = Visibility.Visible;
                    windowSizeChanged = true;
                }

                if (this.Width <= 600 && windowSizeChanged)
                {
                    historyColumnTextBlock.Visibility = Visibility.Collapsed;
                    historyBtn.Visibility = Visibility.Visible;
                    windowSizeChanged = false;
                }
            }
            
        }

        private double Solve(double num1, double num2, string op)
        {
            double answer = 0.0d;

            switch (op)
            {
                case "x":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                default:
                    break;
            }

            return answer;
        }



    }
}
