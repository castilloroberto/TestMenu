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

namespace TestMenu
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

     

        private void txt_search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txt_search.Foreground.ToString() == "#FF808080")
            {
                txt_search.Text = "";
                txt_search.Foreground = new SolidColorBrush(Colors.Black);

            }
           
        }

        private void txt_search_LostFocus(object sender, RoutedEventArgs e)
        {

            if (txt_search.Text.Length == 0)
            {
                txt_search.Foreground = new SolidColorBrush(Colors.Gray);
                txt_search.Text = "Nombre o Codigo de Producto";

            }
        }
    }
}
