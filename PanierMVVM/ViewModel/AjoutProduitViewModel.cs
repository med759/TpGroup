using PanierMVVM.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierMVVM.ViewModel
{
    public class AjoutProduitViewModel
    {
        private Produit produit;

        public Produit Produit { get => produit; set => produit = value; }
        public string Label { get => Produit.Label; set => Produit.Label = value; }
        public decimal Prix { get => Produit.Prix; set => Produit.Prix = value; }

        public AjoutProduitViewModel()
        {
            Produit = new Produit();
        }
    }
}
