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

namespace pr_4_z3
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
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(num.Text, out int elementNumber))
            {
            }  

            double elementValue = double.Parse(value.Text);

            double a, R1, R2, S;

            switch (elementNumber)
            {
                case 1:
                    a = elementValue;
                    R1 = a * Math.Sqrt(3) / 4;
                    R2 = 2 * R1;
                    S = a * a * Math.Sqrt(3) / 4;
                    break;

                case 2:
                    R1 = elementValue;
                    a = R1 * 4 / Math.Sqrt(3);
                    R2 = 2 * R1;
                    S = a * a * Math.Sqrt(3) / 4;
                    break;

                case 3:
                    R2 = elementValue;
                    R1 = R2 / 2;
                    a = R1 * 4 / Math.Sqrt(3);
                    S = a * a * Math.Sqrt(3) / 4;
                    break;

                case 4:
                    S = elementValue;
                    a = Math.Sqrt(4 * S / Math.Sqrt(3));
                    R1 = a * Math.Sqrt(3) / 4;
                    R2 = 2 * R1;
                    break;

                default:
                    MessageBox.Show("Неверный номер элемента!");
                    return;
            }

            result.Text = ($"a:{a} R1:{R1} R2:{R2} S:{S}");





        }
    }
}