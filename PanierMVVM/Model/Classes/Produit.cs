using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierMVVM.Model.Classes
{
    public class Produit
    {
        private int id;
        private string label;
        private decimal prix;

        public static SqlCommand command;
        public static SqlDataAdapter dataAdapter;
        public static SqlDataReader reader;


        public int Id { get => id; set => id = value; }
        public string Label { get => label; set => label = value; }
        public decimal Prix { get => prix; set => prix = value; }


        public static void Load()
        {
            if (Configuration.DataSet.Tables["produit"] != null)
            {
                Configuration.DataSet.Tables["produit"].Rows.Clear();
            }
            dataAdapter = new SqlDataAdapter("SELECT * FROM produit", Configuration.Connection);
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO produit (label, prix) values(@label, @prix)", Configuration.Connection);
            dataAdapter.InsertCommand.Parameters.Add("@label", SqlDbType.VarChar, 50, "label");
            dataAdapter.InsertCommand.Parameters.Add("@prix", SqlDbType.Decimal, 10, "prix");
            dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM produit where id=@id", Configuration.Connection);
            dataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 11, "id");
            Configuration.Connection.Open();
            dataAdapter.Fill(Configuration.DataSet, "produit");
            Configuration.Connection.Close();
        }


        public bool Save()
        {
            command = new SqlCommand("INSERT INTO produit (label, prix) OUTPUT INSERTED.ID values (@label, @prix)", Configuration.Connection);
            command.Parameters.Add(new SqlParameter("@label", Label));
            command.Parameters.Add(new SqlParameter("@prix", Prix));
            Configuration.Connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            Configuration.Connection.Close();
            return Id > 0;
        }

        public Produit Search()
        {
            Produit p = null;
            string request = @"SELECT TOP 1 label, prix FROM produit where label = @label";
            command = new SqlCommand(request, Configuration.Connection);
            command.Parameters.Add(new SqlParameter("@label", Label));
            Configuration.Connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                p = new Produit() { Label = reader.GetString(0), Prix = reader.GetDecimal(1) };
            }
            command.Dispose();
            Configuration.Connection.Close();

            return p;
        }

        public override string ToString()
        {
            return $"Label : {label}, Prix {prix}";
        }
    }
}
