﻿using System;
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
        }
    }
}