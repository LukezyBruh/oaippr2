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

namespace Практическая_WPF_2
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

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 31 день ";
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 28 (29) дней";
        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 31 день ";
        }

        private void rb3_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 30 дней ";
        }

        private void rb4_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 31 день ";
        }

        private void rb5_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 30 дней ";
        }

        private void rb6_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 31 день ";
        }

        private void rb7_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 31 день ";
        }

        private void rb8_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 30 день ";
        }

        private void rb9_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 31 день ";
        }

        private void rb10_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 30 дней ";
        }


        private void rb11_Checked(object sender, RoutedEventArgs e)
        {
            Text.Text = "В этом месяце 31 день ";
        }

        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked== true)
            {
                gb.IsEnabled = true; checkBox2.IsChecked = false;gb_Copy.IsEnabled = false;
            }
            else 
            { 
                   gb.IsEnabled = false; checkBox2.IsChecked = true; gb_Copy.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rb12.IsChecked==true)Text1.Text= "В этом месяце 31 день ";
            if (rb13.IsChecked==true)Text1.Text= "В этом месяце 28 (29) дней ";
            if (rb14.IsChecked==true)Text1.Text= "В этом месяце 31 день ";
            if (rb15.IsChecked==true)Text1.Text= "В этом месяце 30 дней ";
            if (rb16.IsChecked==true)Text1.Text= "В этом месяце 31 день ";
            if (rb17.IsChecked==true)Text1.Text= "В этом месяце 30 дней ";
            if (rb18.IsChecked==true)Text1.Text= "В этом месяце 31 день ";
            if (rb19.IsChecked==true)Text1.Text= "В этом месяце 31 день ";
            if (rb20.IsChecked==true)Text1.Text= "В этом месяце 30 дней ";
            if (rb21.IsChecked==true)Text1.Text= "В этом месяце 31 день ";
            if (rb22.IsChecked==true)Text1.Text= "В этом месяце 30 дней ";
            if (rb23.IsChecked==true)Text1.Text= "В этом месяце 31 день ";
        }

        private void checkBox2_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox2.IsChecked == true)
            {
                gb_Copy.IsEnabled = true;checkBox.IsChecked = false; gb.IsEnabled = false;
            }
            else
            {
                gb_Copy.IsEnabled = false; checkBox.IsChecked = true; gb.IsEnabled=true ;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Гуреева Ирина Дмитриевна. \n18 практическаяю \nСоставить программу, которая бы по названию месяца выдавала бы количество дней в месяце. \nНе замужем ", "Обо мне");
        }
    }
}
