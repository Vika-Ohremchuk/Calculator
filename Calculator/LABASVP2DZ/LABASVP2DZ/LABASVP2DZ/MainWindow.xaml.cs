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
using ClassLibrary2;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Globalization;


namespace LABASVP2DZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string language;
        public MainWindow()
        {
            InitializeComponent();
            language = "en-US";
        }
        private void Button_Click_Calculate(object sender, RoutedEventArgs e)
        {
            Hide();
            Window1 calculate = new Window1();
            calculate.ShowDialog();
            Close();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_History(object sender, RoutedEventArgs e)
        {
            Process.Start("notepad.exe", "C:\\СВП\\LABASVP2DZ\\Save_Result.txt");
        }

        private void Lang_ch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox cb = sender as ComboBox;
            language = (cb.SelectedItem as ComboBoxItem).Tag.ToString();

            if (language != null)
            {
                CultureInfo lang = new CultureInfo(language);

                if (lang != null)
                {
                    App.Language = lang;
                }

            }
        }

    }
}
