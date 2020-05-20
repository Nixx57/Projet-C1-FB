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
using System.Windows.Shapes;

namespace Projet_C1_FB
{
    /// <summary>
    /// Logique d'interaction pour AddAnimalWindow.xaml
    /// </summary>
    public partial class AddAnimalWindow : Window
    {
        private ApplicationContext db;
        public AddAnimalWindow(ApplicationContext DB)
        {
            InitializeComponent();
            db = DB;
            especeField.ItemsSource = db.ListEspeces.ToList();
            genreField.ItemsSource = Enum.GetValues(typeof(Gender));
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Espece queryEspece = (from espece in db.ListEspeces
                                  where espece.Nom == ((Espece)especeField.SelectedItem).Nom
                                  select espece).FirstOrDefault();
            try
            {
                Animal animal = new Animal(nameField.Text, queryEspece, raceField.Text, (Gender)Convert.ToInt32(genreField.SelectedIndex), Convert.ToInt32(ageField.Text), regionHabField.Text);
                db.ListAnimaux.Add(animal);
                db.SaveChanges();
                Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("Entrez des données valide");
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
