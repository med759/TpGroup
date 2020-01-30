using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierMVVM.Model.Classes
{
    public class Client
    {
        private int id;
        private string nomClient;
        private string prenomClient;
        private string telephone;

        public static SqlCommand command;

        public int Id { get => id; set => id = value; }
        public string NomClient { get => nomClient; set => nomClient = value; }
        public string PrenomClient { get => prenomClient; set => prenomClient = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public bool Save()
        {
            command = new SqlCommand("INSERT INTO client (nom, prenom, telephone) OUTPUT INSERTED.ID values (@nom, @prenom, @telephone)", Configuration.Connection);
            command.Parameters.Add(new SqlParameter("@nom", NomClient));
            command.Parameters.Add(new SqlParameter("@prenom", PrenomClient));
            command.Parameters.Add(new SqlParameter("@telephone", Telephone));
            Configuration.Connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            Configuration.Connection.Close();
            return Id > 0;
        }
    }
}
