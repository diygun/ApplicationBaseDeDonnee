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
 public class A_t_produit : ADBase
 {
  #region Constructeurs
  public A_t_produit(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, decimal Prix_vente, decimal Prix_achat, int Quantite_stock, double TVA, int Seuil_stock)
  {
   CreerCommande("Ajoutert_produit");
   int res = 0;
   Commande.Parameters.Add("ID_produit", SqlDbType.Int);
   Direction("ID_produit", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@Nom", Nom);
   Commande.Parameters.AddWithValue("@Prix_vente", Prix_vente);
   Commande.Parameters.AddWithValue("@Prix_achat", Prix_achat);
   Commande.Parameters.AddWithValue("@Quantite_stock", Quantite_stock);
   Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Parameters.AddWithValue("@Seuil_stock", Seuil_stock);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID_produit"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID_produit, string Nom, decimal Prix_vente, decimal Prix_achat, int Quantite_stock, double TVA, int Seuil_stock)
  {
   CreerCommande("Modifiert_produit");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_produit", ID_produit);
   Commande.Parameters.AddWithValue("@Nom", Nom);
   Commande.Parameters.AddWithValue("@Prix_vente", Prix_vente);
   Commande.Parameters.AddWithValue("@Prix_achat", Prix_achat);
   Commande.Parameters.AddWithValue("@Quantite_stock", Quantite_stock);
   Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Parameters.AddWithValue("@Seuil_stock", Seuil_stock);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_produit> Lire(string Index)
  {
   CreerCommande("Selectionnert_produit");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_produit> res = new List<C_t_produit>();
   while (dr.Read())
   {
    C_t_produit tmp = new C_t_produit();
    tmp.ID_produit = int.Parse(dr["ID_produit"].ToString());
    tmp.Nom = dr["Nom"].ToString();
    tmp.Prix_vente = decimal.Parse(dr["Prix_vente"].ToString());
    tmp.Prix_achat = decimal.Parse(dr["Prix_achat"].ToString());
    tmp.Quantite_stock = int.Parse(dr["Quantite_stock"].ToString());
    tmp.TVA = double.Parse(dr["TVA"].ToString());
    tmp.Seuil_stock = int.Parse(dr["Seuil_stock"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_produit Lire_ID(int ID_produit)
  {
   CreerCommande("Selectionnert_produit_ID");
   Commande.Parameters.AddWithValue("@ID_produit", ID_produit);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_produit res = new C_t_produit();
   while (dr.Read())
   {
    res.ID_produit = int.Parse(dr["ID_produit"].ToString());
    res.Nom = dr["Nom"].ToString();
    res.Prix_vente = decimal.Parse(dr["Prix_vente"].ToString());
    res.Prix_achat = decimal.Parse(dr["Prix_achat"].ToString());
    res.Quantite_stock = int.Parse(dr["Quantite_stock"].ToString());
    res.TVA = double.Parse(dr["TVA"].ToString());
    res.Seuil_stock = int.Parse(dr["Seuil_stock"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID_produit)
  {
   CreerCommande("Supprimert_produit");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_produit", ID_produit);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
