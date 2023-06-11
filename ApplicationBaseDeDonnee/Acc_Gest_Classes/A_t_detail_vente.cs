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
 public class A_t_detail_vente : ADBase
 {
  #region Constructeurs
  public A_t_detail_vente(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_commande_client, int? ID_produit, int? Quantite, decimal? Prix_vente, double? TVA)
  {
   CreerCommande("Ajoutert_detail_vente");
   int res = 0;
   Commande.Parameters.Add("ID_detail_vente", SqlDbType.Int);
   Direction("ID_detail_vente", ParameterDirection.Output);
   if(ID_commande_client == null) Commande.Parameters.AddWithValue("@ID_commande_client", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_commande_client", ID_commande_client);
   if(ID_produit == null) Commande.Parameters.AddWithValue("@ID_produit", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_produit", ID_produit);
   if(Quantite == null) Commande.Parameters.AddWithValue("@Quantite", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Quantite", Quantite);
   if(Prix_vente == null) Commande.Parameters.AddWithValue("@Prix_vente", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Prix_vente", Prix_vente);
   if(TVA == null) Commande.Parameters.AddWithValue("@TVA", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID_detail_vente"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID_detail_vente, int? ID_commande_client, int? ID_produit, int? Quantite, decimal? Prix_vente, double? TVA)
  {
   CreerCommande("Modifiert_detail_vente");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_detail_vente", ID_detail_vente);
   if(ID_commande_client == null) Commande.Parameters.AddWithValue("@ID_commande_client", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_commande_client", ID_commande_client);
   if(ID_produit == null) Commande.Parameters.AddWithValue("@ID_produit", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@ID_produit", ID_produit);
   if(Quantite == null) Commande.Parameters.AddWithValue("@Quantite", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Quantite", Quantite);
   if(Prix_vente == null) Commande.Parameters.AddWithValue("@Prix_vente", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Prix_vente", Prix_vente);
   if(TVA == null) Commande.Parameters.AddWithValue("@TVA", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TVA", TVA);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_detail_vente> Lire(string Index)
  {
   CreerCommande("Selectionnert_detail_vente");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_detail_vente> res = new List<C_t_detail_vente>();
   while (dr.Read())
   {
    C_t_detail_vente tmp = new C_t_detail_vente();
    tmp.ID_detail_vente = int.Parse(dr["ID_detail_vente"].ToString());
   if(dr["ID_commande_client"] != DBNull.Value) tmp.ID_commande_client = int.Parse(dr["ID_commande_client"].ToString());
   if(dr["ID_produit"] != DBNull.Value) tmp.ID_produit = int.Parse(dr["ID_produit"].ToString());
   if(dr["Quantite"] != DBNull.Value) tmp.Quantite = int.Parse(dr["Quantite"].ToString());
   if(dr["Prix_vente"] != DBNull.Value) tmp.Prix_vente = decimal.Parse(dr["Prix_vente"].ToString());
   if(dr["TVA"] != DBNull.Value) tmp.TVA = double.Parse(dr["TVA"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_detail_vente Lire_ID(int ID_detail_vente)
  {
   CreerCommande("Selectionnert_detail_vente_ID");
   Commande.Parameters.AddWithValue("@ID_detail_vente", ID_detail_vente);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_detail_vente res = new C_t_detail_vente();
   while (dr.Read())
   {
    res.ID_detail_vente = int.Parse(dr["ID_detail_vente"].ToString());
   if(dr["ID_commande_client"] != DBNull.Value) res.ID_commande_client = int.Parse(dr["ID_commande_client"].ToString());
   if(dr["ID_produit"] != DBNull.Value) res.ID_produit = int.Parse(dr["ID_produit"].ToString());
   if(dr["Quantite"] != DBNull.Value) res.Quantite = int.Parse(dr["Quantite"].ToString());
   if(dr["Prix_vente"] != DBNull.Value) res.Prix_vente = decimal.Parse(dr["Prix_vente"].ToString());
   if(dr["TVA"] != DBNull.Value) res.TVA = double.Parse(dr["TVA"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID_detail_vente)
  {
   CreerCommande("Supprimert_detail_vente");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_detail_vente", ID_detail_vente);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
