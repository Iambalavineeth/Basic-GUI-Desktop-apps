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

namespace SimpleInterestCalculator
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

        private void simpleButton_Click(object sender, RoutedEventArgs e)
        {
            double initialAmt, rate, time;
            initialAmt = Double.Parse(simpleAmt.Text);
            rate = Double.Parse(simpleRate.Text);
            time = Double.Parse(simpleTime.Text);
            simpleAns.Content = (initialAmt * (1 + rate * time)).ToString("c");
        }

        private void compButton_Click(object sender, RoutedEventArgs e)
        {
            double initialAmt, rate, time, num;
            initialAmt = Double.Parse(compAmt1.Text);
            rate = Double.Parse(compRate.Text);
            time = Double.Parse(compTime.Text);
            num = Double.Parse(compNum.Text);
            compAns.Content = (initialAmt * Math.Pow((1 + (rate/num)), (num*time))).ToString("c");
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            simpleAmt.Text = "";
            simpleRate.Text = "";
            simpleTime.Text = "";
            simpleAns.Content = "Ans";

            compAmt1.Text = "";
            compRate.Text = "";
            compTime.Text = "";
            compNum.Text = "";
            compAns.Content = "Ans";
        }
    }
}
