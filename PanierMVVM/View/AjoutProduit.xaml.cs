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
    /// Logique d'interaction pour AjoutProduit.xaml
    /// </summary>
    public partial class AjoutProduit : Window
    {
        public AjoutProduit()
        {
            InitializeComponent();
            DataContext = new AjoutProduitViewModel();
        }

        public AjoutProduit(string labProduit) : this()
        {
            AjoutProduitViewModel a = DataContext as AjoutProduitViewModel;
            a.Label = labProduit;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AjoutProduitViewModel a = DataContext as AjoutProduitViewModel;
            a.Produit.Save();
        }
    }
}
