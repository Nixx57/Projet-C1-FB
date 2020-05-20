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

namespace Projet_C1_FB
{
    /// <summary>
    /// Logique d'interaction pour ListeAnimauxPage.xaml
    /// </summary>
    public partial class ListeAnimauxPage : Page
    {
        private ApplicationContext db;
        public ListeAnimauxPage()
        {
            InitializeComponent();
        }

        public ListeAnimauxPage(ApplicationContext DB)
        {
            InitializeComponent();
            db = DB;

            animalsGrid.ItemsSource = db.ListAnimaux.ToList();
            genderFilter.ItemsSource = Enum.GetValues(typeof(Gender));
            especeFilter.ItemsSource = db.ListEspeces.ToList();
        }

        private void Switch_on(object sender, RoutedEventArgs e)
        {
                List<Animal> filteredList = db.ListAnimaux.ToList()
                    .Where(x => x.Genre == (Gender)genderFilter.SelectedIndex)
                    .Where(x => x.Espece == (Espece)especeFilter.SelectedItem)
                    .Where(x => x.RegionHabitat.Contains(regionHabFilter.Text))
                    .ToList();
                animalsGrid.ItemsSource = filteredList;
        }

        private void Switch_off(object sender, RoutedEventArgs e)
        {
            animalsGrid.ItemsSource = db.ListAnimaux.ToList();
        }

        private void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(switchFilter.IsChecked == true)
            {
                Switch_on(this, null);
            }
        }

        private void regionHabFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (switchFilter.IsChecked == true)
            {
                Switch_on(this, null);
            }
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            //Reset Data
            animalsGrid.ItemsSource = db.ListAnimaux.ToList();
            genderFilter.ItemsSource = Enum.GetValues(typeof(Gender));
            especeFilter.ItemsSource = db.ListEspeces.ToList();

            //Reset filtre
            switchFilter.IsChecked = false;
            genderFilter.SelectedItem = null;
            especeFilter.SelectedItem = null;
        }
    }
}
