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

namespace LessonsWPF2
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
            if (Radio1.IsChecked == true)
            {
                MessageBox.Show("Wrong button");
            }
            else
            {
                
            }


        }

        private int score = 0;

        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked == true)
            {
                score += 1;
                
            }

            if (Radio4.IsChecked == true)
            {
                score += 1;

            }

            if(Radio7.IsChecked == true)
            {
                score += 1;
            }

            if (Radio10.IsChecked == true)
            {
                score += 1;
            }

            MessageBox.Show($"балл: {score}");
        }
    }
}
