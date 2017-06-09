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

namespace WpfApp5
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            string text = "Checks";
            if (CheckBox1.IsChecked == true)
            {
                text += " 1";
            }
            if (CheckBox2.IsChecked == true)
            {
                text += " 2";
            }
            if (CheckBox3.IsChecked == true)
            {
                text += " 3";
            }
            Selecionados.Content = text + " selecionados";
        }
    }
}
