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
using System.Windows.Shapes;

namespace Dictionary
{
    /// <summary>
    /// Логика взаимодействия для second.xaml
    /// </summary>
    public partial class second : Window
    {
        public second(string s)
        {
            InitializeComponent();
            foreign2.Text = s;
        }

        private void ADD2_Click(object sender, RoutedEventArgs e)
        {
            //Mw.IsEnabled = false;
            MainWindow.dictionary.Add(foreign2.Text, Native2.Text);
            Close();
           // Mw.IsEnabled = true;
        }
    }
}
