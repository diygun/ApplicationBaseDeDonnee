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
 public class A_t_detail_achat : ADBase
 {
  #region Constructeurs
  public A_t_detail_achat(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int ID_commande_frn, int ID_produit, int Quantite, decimal Prix_unitaire, double TVA)
  {
   CreerCommande("Ajoutert_detail_achat");
   int res = 0;
   Commande.Parameters.Add("ID_detail_achat", SqlDbType.Int);
   Direction("ID_detail_achat", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@ID_commande_frn", ID_commande_frn);
   Commande.Parameters.AddWithValue("@ID_produit", ID_produit);
   Commande.Parameters.AddWithValue("@Quantite", Quantite);
   Commande.Parameters.AddWithValue("@Prix_unitaire", Prix_unitaire);
   Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID_detail_achat"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID_detail_achat, int ID_commande_frn, int ID_produit, int Quantite, decimal Prix_unitaire, double TVA)
  {
   CreerCommande("Modifiert_detail_achat");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_detail_achat", ID_detail_achat);
   Commande.Parameters.AddWithValue("@ID_commande_frn", ID_commande_frn);
   Commande.Parameters.AddWithValue("@ID_produit", ID_produit);
   Commande.Parameters.AddWithValue("@Quantite", Quantite);
   Commande.Parameters.AddWithValue("@Prix_unitaire", Prix_unitaire);
   Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_detail_achat> Lire(string Index)
  {
   CreerCommande("Selectionnert_detail_achat");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_detail_achat> res = new List<C_t_detail_achat>();
   while (dr.Read())
   {
    C_t_detail_achat tmp = new C_t_detail_achat();
    tmp.ID_detail_achat = int.Parse(dr["ID_detail_achat"].ToString());
    tmp.ID_commande_frn = int.Parse(dr["ID_commande_frn"].ToString());
    tmp.ID_produit = int.Parse(dr["ID_produit"].ToString());
    tmp.Quantite = int.Parse(dr["Quantite"].ToString());
    tmp.Prix_unitaire = decimal.Parse(dr["Prix_unitaire"].ToString());
    tmp.TVA = double.Parse(dr["TVA"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_detail_achat Lire_ID(int ID_detail_achat)
  {
   CreerCommande("Selectionnert_detail_achat_ID");
   Commande.Parameters.AddWithValue("@ID_detail_achat", ID_detail_achat);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_detail_achat res = new C_t_detail_achat();
   while (dr.Read())
   {
    res.ID_detail_achat = int.Parse(dr["ID_detail_achat"].ToString());
    res.ID_commande_frn = int.Parse(dr["ID_commande_frn"].ToString());
    res.ID_produit = int.Parse(dr["ID_produit"].ToString());
    res.Quantite = int.Parse(dr["Quantite"].ToString());
    res.Prix_unitaire = decimal.Parse(dr["Prix_unitaire"].ToString());
    res.TVA = double.Parse(dr["TVA"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID_detail_achat)
  {
   CreerCommande("Supprimert_detail_achat");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_detail_achat", ID_detail_achat);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
