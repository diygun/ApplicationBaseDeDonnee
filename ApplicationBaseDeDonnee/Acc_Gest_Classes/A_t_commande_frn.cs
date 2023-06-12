#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_DB_ManagmentAPP.Classes;
#endregion

namespace Projet_DB_ManagmentAPP.Acces
{
    /// <summary>
    /// Couche d'accès aux données (Data Access Layer)
    /// </summary>
    public class A_t_commande_frn : ADBase
    {
        #region Constructeurs
        public A_t_commande_frn(string sChaineConnexion)
            : base(sChaineConnexion)
        { }
        #endregion
        
        public int Ajouter(int ID_commande_frn, int ID_frn, DateTime Date_commande)
        {
            CreerCommande("Ajoutert_commande_frn");
            int res = 0;
            Commande.Parameters.Add("ID_commande_frn", SqlDbType.Int); // ajout en plus a la place de Commande.Parameters.AddWithValue("@ID_commande_frn", ID_commande_frn);
            Direction("ID_commande_frn", ParameterDirection.Output); // ajout de se que vous avez demandé
            Commande.Parameters.AddWithValue("@ID_frn", ID_frn);
            Commande.Parameters.AddWithValue("@Date_commande", Date_commande);
            Commande.Connection.Open();
            Commande.ExecuteNonQuery();
            res = int.Parse(LireParametre("ID_commande_frn"));
            Commande.Connection.Close();
            return res;
        }

        public int Modifier(int ID_commande_frn, int ID_frn, DateTime Date_commande)
        {
            CreerCommande("Modifiert_commande_frn");
            int res = 0;
            Commande.Parameters.AddWithValue("@ID_commande_frn", ID_commande_frn);
            Commande.Parameters.AddWithValue("@ID_frn", ID_frn);
            Commande.Parameters.AddWithValue("@Date_commande", Date_commande);
            Commande.Connection.Open();
            Commande.ExecuteNonQuery();
            Commande.Connection.Close();
            return res;
        }
        public List<C_t_commande_frn> Lire(string Index)
        {
            CreerCommande("Selectionnert_commande_frn");
            Commande.Parameters.AddWithValue("@Index", Index);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_t_commande_frn> res = new List<C_t_commande_frn>();
            while (dr.Read())
            {
                C_t_commande_frn tmp = new C_t_commande_frn();
                tmp.ID_commande_frn = int.Parse(dr["ID_commande_frn"].ToString());
                tmp.ID_frn = int.Parse(dr["ID_frn"].ToString());
                tmp.Date_commande = DateTime.Parse(dr["Date_commande"].ToString());
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public C_t_commande_frn Lire_ID(int ID_commande_frn)
        {
            CreerCommande("Selectionnert_commande_frn_ID");
            Commande.Parameters.AddWithValue("@ID_commande_frn", ID_commande_frn);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            C_t_commande_frn res = new C_t_commande_frn();
            while (dr.Read())
            {
                res.ID_commande_frn = int.Parse(dr["ID_commande_frn"].ToString());
                res.ID_frn = int.Parse(dr["ID_frn"].ToString());
                res.Date_commande = DateTime.Parse(dr["Date_commande"].ToString());
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public int Supprimer(int ID_commande_frn)
        {
            CreerCommande("Supprimert_commande_frn");
            int res = 0;
            Commande.Parameters.AddWithValue("@ID_commande_frn", ID_commande_frn);
            Commande.Connection.Open();
            res = Commande.ExecuteNonQuery();
            Commande.Connection.Close();
            return res;
        }
    }
}
