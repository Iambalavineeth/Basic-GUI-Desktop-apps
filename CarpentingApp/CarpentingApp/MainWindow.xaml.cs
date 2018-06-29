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

namespace CarpentingApp
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

        private void btnArea_Click(object sender, RoutedEventArgs e)
        {
            int width, length, area;
            width = Int32.Parse(txtWidth.Text);
            length = Int32.Parse(txtLength.Text);
            area = width * length;
            lblArea.Content = area.ToString();
        }

        private void btnCost_Click(object sender, RoutedEventArgs e)
        {
            int costPF, length, width;
            costPF = Int32.Parse(txtPrice.Text);
            length = Int32.Parse(txtLength.Text);
            width = Int32.Parse(txtWidth.Text);
            lblCost.Content = (costPF * length * width).ToString("c");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblArea.Content = "";
            lblCost.Content = "";
            txtLength.Text = "";
            txtWidth.Text = "";
            txtPrice.Text = "";
        }
    }
}
