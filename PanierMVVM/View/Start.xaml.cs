using PanierMVVM.Model.Classes;
using PanierMVVM.ViewModel;
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

namespace PanierMVVM.View
{
    /// <summary>
    /// Logique d'interaction pour Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        private StartViewModel s;
        private Produit p;

        public Start()
        {
            InitializeComponent();
            DataContext = new StartViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            s = DataContext as StartViewModel;
            s.Client.Save();
        }

        private void AjouterProduit_Click(object sender, RoutedEventArgs e)
        {
            AjoutProduit a = new AjoutProduit(produitLab.Text);
            a.Show();
        }

        private void Recherche_Click(object sender, RoutedEventArgs e)
        {
            s = DataContext as StartViewModel;
            p = s.Produit.Search();
            productFound.Content = p.ToString();
        }

        private void AjoutPanier_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
