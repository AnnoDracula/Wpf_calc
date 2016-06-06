using System;
using System.Windows;
using System.Windows.Controls;
using MethodsLibrary;

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainCalc.xaml
    /// </summary>
    public partial class MainCalc : Window
    {
        private double? lastValue;
        private string sign;
        public MainCalc()
        {
            InitializeComponent();
        }

        private void Delete_All_Click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = "";
            lastValue = null;
            sign = null;
        }

        private void Digit_Click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text += ((Button) e.OriginalSource).Content;
        }

        private void Operatoin_Click(object sender, RoutedEventArgs e)
        {
            var value = Double.Parse(InputTextBox.Text);
            if (lastValue == null)
            {
                lastValue = value;
            }
            else
            {
                lastValue = MathMethods.Calculate((double)lastValue, value, sign);
            }
            OutputTextBox.Text = lastValue + (string)((Button)e.OriginalSource).Content;
            sign = (string) (((Button) e.OriginalSource).Content);
            InputTextBox.Text = "";
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            var value = Double.Parse(InputTextBox.Text);
            if (lastValue == null)
            {
                lastValue = value;
            }
            else
            {
                lastValue = MathMethods.Calculate((double)lastValue, value, sign);
            }
            InputTextBox.Text = lastValue.ToString();
            OutputTextBox.Text = "";
            lastValue = null;
        }

    }
}
