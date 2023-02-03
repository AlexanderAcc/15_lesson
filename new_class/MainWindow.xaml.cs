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

namespace new_class
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
        private void button1_Click(object sender, RoutedEventArgs e) // Вещественный
        {
            Class1<double> double1 = new Class1<double>(Convert.ToDouble(textbox1.Text)); // Создание объекта класса Class1, double1
            Class1<double> double2 = new Class1<double>(Convert.ToDouble(textbox2.Text)); // Создание объекта класса Class1, double2

            label1.Content = double1.local + double2.local; // Сложение local у объектов double1, double2
        }
        private void button2_Click(object sender, RoutedEventArgs e) // Целый
        {
            Class1<int> int1 = new Class1<int>(Convert.ToInt32(textbox3.Text)); // Создание объекта класса Class1, int1
            Class1<int> int2 = new Class1<int>(Convert.ToInt32(textbox4.Text)); // Создание объекта класса Class1, int2

            label2.Content = int1.local + int2.local; // Сложение local у объектов int1, int2
        }
    }
}
