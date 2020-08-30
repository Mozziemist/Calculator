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
        bool isOpLastInput = false;
        float num1 = 0.0f;
        String operand = "", history = "";

        public MainWindow()
        {
            InitializeComponent();
        }

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

        }

        private void Dot(object sender, RoutedEventArgs e)
        {

        }

        private void Percent(object sender, RoutedEventArgs e)
        {

        }

        private void OneOver(object sender, RoutedEventArgs e)
        {

        }

        private void CE(object sender, RoutedEventArgs e)
        {

        }

        private void Square(object sender, RoutedEventArgs e)
        {

        }

        private void C(object sender, RoutedEventArgs e)
        {

        }

        private void Root(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Divide(object sender, RoutedEventArgs e)
        {

        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            
            operand = "x";
            isOpLastInput = true;
            if (num1 == 0.0f)
            {
                historyQuickView.Text = screen.Text + " x ";
                num1 = float.Parse(screen.Text);
            }
            else
            {
                historyQuickView.Text += screen.Text + " x ";
                num1 = num1 * float.Parse(screen.Text);
                screen.Text = num1.ToString();
            }
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {

        }

        private void Add(object sender, RoutedEventArgs e)
        {

        }

        private void Equals(object sender, RoutedEventArgs e)
        {
            switch (operand)
            {
                case "x":
                    historyQuickView.Text += screen.Text + " = ";
                    screen.Text = (float.Parse(screen.Text) * num1).ToString();
                    history += historyQuickView + " = " + screen.Text;
                    num1 = 0.0f;
                    break;
                default:
                    break;
            }
        }


        private void showHistory(object sender, RoutedEventArgs e)
        {

        }
    }
}
