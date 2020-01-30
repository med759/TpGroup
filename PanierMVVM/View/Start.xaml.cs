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
        public Start()
        {
            InitializeComponent();
            DataContext = new StartViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartViewModel s = DataContext as StartViewModel;
            s.Client.Save();
        }

        private void AjouterProduit_Click(object sender, RoutedEventArgs e)
        {
            AjoutProduit a = new AjoutProduit(produitLab.Text);
            a.Show();
        }
    }
}
