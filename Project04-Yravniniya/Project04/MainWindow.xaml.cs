using System.Windows;

namespace Project04
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

        private void btn_NewtonCotes_Click(object sender, RoutedEventArgs e)
        {
            WinNewtonCotes winNewtonCotes = new WinNewtonCotes();
            winNewtonCotes.Show();

            this.Close();
        }

        private void btn_Trapezoid_Click(object sender, RoutedEventArgs e)
        {
            WinTrapezoid winTrapezoid = new WinTrapezoid();
            winTrapezoid.Show();

            this.Close();
        }

        private void btn_Simpson_Click(object sender, RoutedEventArgs e)
        {
            WinLangrag winSimpsona = new WinLangrag();
            winSimpsona.Show();

            this.Close();
        }

        
    }
}
