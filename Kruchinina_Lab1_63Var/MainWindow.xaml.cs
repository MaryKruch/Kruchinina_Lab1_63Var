using Kruchinina_Lab1_63Var.rrr;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kruchinina_Lab1_63Var
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Isintegers.IsChecked == true)
            {
                Integer integer = new Integer() {A=int.Parse(FirstSize.Text)};
                ResFirst.Text = integer.Add(integer).ToString();
            }
            else
            if (IsReal.IsChecked == true)
            {
                Real real = new Real() { A = int.Parse(FirstSize.Text) };
                ResFirst.Text = real.Add(real).ToString();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Isintegers.IsChecked == true)
            {
                Integer integer = new Integer() { A = int.Parse(FirstSize.Text) };
                ResFirst.Text = integer.Sub(integer).ToString();
            }
            else
            if (IsReal.IsChecked == true)
            {
                Real real = new Real() { A = int.Parse(FirstSize.Text) };
                ResFirst.Text = real.Sub(real).ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Isintegers.IsChecked == true)
            {
                Integer integer = new Integer() { A = int.Parse(FirstSize.Text) };
                ResFirst.Text = integer.Div(integer).ToString();
            }
            else
            if (IsReal.IsChecked == true)
            {
                Real real = new Real() { A = int.Parse(FirstSize.Text) };
                ResFirst.Text = real.Div(real).ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Isintegers.IsChecked == true)
            {
                Integer integer = new Integer() { A = int.Parse(FirstSize.Text) };
                ResFirst.Text = integer.Mult(integer).ToString();
            }
            else
            if (IsReal.IsChecked == true)
            {
                Real real = new Real() { A = int.Parse(FirstSize.Text) };
                ResFirst.Text = real.Mult(real).ToString();
            }
        }
    }
}