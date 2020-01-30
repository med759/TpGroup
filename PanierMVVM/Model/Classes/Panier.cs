using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierMVVM.Model.Classes
{
    public class Panier
    {
        private int id;
        private string idClient;
        private decimal total;
        private ObservableCollection<Produit> produits;

        public static SqlCommand command;
        public int Id { get => id; set => id = value; }
        public decimal Total { get => Total1; }
        public ObservableCollection<Produit> Produits { get => produits; set => produits = value; }
        public string IdClient { get => idClient; set => idClient = value; }
        public decimal Total1 { get => total; set => total = value; }

        public Panier()
        {
            Produits = new ObservableCollection<Produit>();
        }

        public bool Save()
        {
            
            return Id > 0;
        }
    }
}
