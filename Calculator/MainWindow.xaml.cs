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
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zero(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "0";
            }
            else
                result.Text += "0";
        }

        private void One(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "1";
            }
            else
                result.Text += "1";
        }

        private void Two(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "2";
            }
            else
                result.Text += "2";
        }

        private void Three(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "3";
            }
            else
                result.Text += "3";
        }

        private void Four(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "4";
            }
            else
                result.Text += "4";
        }

        private void Five(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "5";
            }
            else
                result.Text += "5";
        }

        private void Six(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "6";
            }
            else
                result.Text += "6";
        }

        private void Seven(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "7";
            }
            else
                result.Text += "7";
        }

        private void Eight(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "8";
            }
            else
                result.Text += "8";
        }

        private void Nine(object sender, RoutedEventArgs e)
        {
            if (result.Text.Equals("0"))
            {
                result.Text = "9";
            }
            else
                result.Text += "9";
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
            
            
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {

        }

        private void Add(object sender, RoutedEventArgs e)
        {

        }

        private void Equals(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
