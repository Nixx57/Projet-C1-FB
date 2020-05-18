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
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
