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

namespace Cap8y9
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            FechaTextBox.Text = DateTime.Now.ToString();
        }
        string orden;
        private void OrdenarButton_Click(object sender, RoutedEventArgs e)
        {
            orden = string.Empty;
            String cad1 = String.Empty;
            String cad2 = String.Empty;

            cad1 = Cadena1Textbox.Text;
            cad2 = Cadena2Textbox.Text;

           
            if (cad1.CompareTo(cad2)>0)
            {
               orden = cad1;
               orden += "\n" + cad2;

            }
            OrdenarTextBox.Text = orden;
        }
    }
}
