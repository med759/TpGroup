using PanierMVVM.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierMVVM.ViewModel
{
    public class StartViewModel
    {
        private Client client;
        private Produit produit;

        public string Nom { get => Client.NomClient; set => Client.NomClient = value; }
        public string Prenom { get => Client.PrenomClient; set => Client.PrenomClient = value; }
        public string Telephone { get => Client.Telephone; set => Client.Telephone = value; }
        public string Label { get => Produit.Label; set => Produit.Label = value; }
        public decimal Prix { get => Produit.Prix; set => Produit.Prix = value; }
        public Client Client { get => client; set => client = value; }
        public Produit Produit { get => produit; set => produit = value; }


        public StartViewModel()
        {
            Client = new Client();
            Produit = new Produit();
        }

    }

}
