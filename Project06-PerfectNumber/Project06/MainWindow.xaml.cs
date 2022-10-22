using System;
using System.Windows;
namespace Project06
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
        private void btn_Result_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(a.Text) <= 1000 && Convert.ToInt32(b.Text) > 0)
            {
                Result.Text = "";

                for (int i = Convert.ToInt32(a.Text); i <= Convert.ToInt32(b.Text); i++)
                {
                    if (ResultS(i))
                    {
                        if (Result.Text == "")
                            Result.Text += $"{i}";
                        else
                            Result.Text += $", {i}";
                    }
                }
            }
        }
        private bool ResultS(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum == n;
        }
    }
}
