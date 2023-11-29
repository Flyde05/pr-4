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

namespace pr_4__z2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(N.Text, out int n))
            { }
            if (int.TryParse(M.Text, out int m))
            { }
            switch (n)
            {
                case 1:
                    res1.Text = ("пик").ToString();
                    break;
                case 2:
                    res1.Text = ("треф").ToString();
                    break;
                case 3:
                    res1.Text = ("черв").ToString();
                    break;
                case 4:
                    res1.Text = ("бубен").ToString();
                    break;

            }
            switch (m)
            {
                case 6:
                    res2.Text = ("шестерка").ToString();
                    break;
                case 7:
                    res2.Text = ("семерка").ToString();
                    break;
                case 8:
                    res2.Text = ("восьмерка").ToString();
                    break;
                case 9:
                    res2.Text = ("девятка").ToString();
                    break;
                case 10:
                    res2.Text = ("десятка").ToString();
                    break;
                case 11:
                    res2.Text = ("валет").ToString();
                    break;
                case 12:
                    res2.Text = ("дама").ToString();
                    break;
                case 13:
                    res2.Text = ("король").ToString();
                    break;
                case 14:
                    res2.Text = ("туз").ToString();
                    break;
            }
        }
    }
}
