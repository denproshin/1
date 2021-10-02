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

namespace МДК_03._01
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

        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page1();
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page2();
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page3();
        }

        private void Page4_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page4();
        }

        private void Page5_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page5();
        }

        private void Page6_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page6();
        }

        private void Page7_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page7();
        }

        private void Page8_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page8();
        }

        private void Page9_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page9();
        }

        private void Page10_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page10();
        }

        private void Page11_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page11();
        }

        
    }
}
