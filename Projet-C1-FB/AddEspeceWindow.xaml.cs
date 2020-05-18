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
    /// Logique d'interaction pour AddEspeceWindow.xaml
    /// </summary>
    public partial class AddEspeceWindow : Window
    {
        public ApplicationContext db;

        public AddEspeceWindow(ApplicationContext DB)
        {
            InitializeComponent();
            db = DB;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            try
            {
                Espece espece = new Espece(nameBox.Text, Convert.ToInt32(nbMaxBox.Text));
                db.ListEspeces.Add(espece);
                db.SaveChanges();
                Close();
            }
            catch(Exception)
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
