using System.Windows;
using System.Windows.Controls;

namespace BeautySalon
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void GoToServices_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new ServicesPage());
        }
    }
}