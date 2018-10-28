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

namespace Dictionary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        KeyValuePair<string, string> keyValuePair;
        bool flag = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Translate_Click(object sender, RoutedEventArgs e)//обработчик нажатия на кнопку 
        {
            string txt = Forein_word.Text;
            if (Forein_word.Text == "")
                MessageBox.Show("Введите слово");
            else if (txt[0] == Convert.ToChar(" "))
                MessageBox.Show("Введенное слово начинается с пробела");
            else
            {
                foreach (string word in dictionary.Keys)
                {
                    if (word == txt)
                    {
                        Native_word.Text = dictionary[word];
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    
                    MessageBoxResult result = MessageBox.Show("Данное слово отсутвует, добавить?", 
                        "Сообщение", MessageBoxButton.YesNoCancel, 
                        MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        second second = new second();
                        FirstWin.IsEnabled = false;
                        second.Show();
                    }
                }
            }
        }

        private void ADD_WORD_Click(object sender, RoutedEventArgs e)
        {
            dictionary.Add(Forein_word.Text, Native_word.Text);
        }

        private void DELETE_WORD_Click(object sender, RoutedEventArgs e)
        {
            string txt = Forein_word.Text;
            if (Forein_word.Text == "")
                MessageBox.Show("Введите слово");
            else if (txt[0] == Convert.ToChar(" "))
                MessageBox.Show("Слово не может начинаться с пробела!");
            else
            {
                if (To_Russian.IsChecked == true)
                {

                }
                foreach (string word in dictionary.Keys)
                {
                    if (word == txt)
                    {
                        dictionary.Remove(word);
                        break;
                    }
                }
            }

        }

        private void To_Russian_Checked(object sender, RoutedEventArgs e)
        {
            Label_1.Content = "English";
            Label_2.Content = "Русский";
        }

        private void To_English_Checked(object sender, RoutedEventArgs e)
        {
            Label_1.Content = "Русский";
            Label_2.Content = "English";
        }
    }
}
