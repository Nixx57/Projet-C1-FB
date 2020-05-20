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
    /// Logique d'interaction pour ListeEspecesPage.xaml
    /// </summary>
    public partial class ListeEspecesPage : Page
    {
        private ApplicationContext db;
        public ListeEspecesPage()
        {
            InitializeComponent();
        }

        public ListeEspecesPage(ApplicationContext DB)
        {
            InitializeComponent();
            db = DB;
            especeList.ItemsSource = db.ListEspeces.ToList();
        }

        private void SelectItem(object sender, SelectionChangedEventArgs e)
        {
            IdField.Text = ((Espece)especeList.SelectedItem).Id.ToString();
            NameField.Text = ((Espece)especeList.SelectedItem).Nom;

            NbField.Text = (from anim in db.ListAnimaux
                            where anim.EspeceId == ((Espece)especeList.SelectedItem).Id
                            select anim).Count().ToString();

            NbMaxField.Text = ((Espece)especeList.SelectedItem).NbMaxATuer.ToString();
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            especeList.ItemsSource = db.ListEspeces.ToList();
        }
    }
}
