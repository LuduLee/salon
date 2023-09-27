using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BeautySalon
{
    public partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            InitializeComponent();
        }

        private void ServicesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<int> selectedServicesCosts = servicesListBox.SelectedItems
                .Cast<ListBoxItem>()
                .Select(item => int.Parse(item.Tag.ToString()))
                .ToList();

            int totalCost = selectedServicesCosts.Sum();
            totalCostTextBlock.Text = $"{totalCost} руб.";
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}