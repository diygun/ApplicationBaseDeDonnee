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
 public class A_t_frn : ADBase
 {
  #region Constructeurs
  public A_t_frn(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, string Adresse, string Email, string GSM, string N_compte)
  {
   CreerCommande("Ajoutert_frn");
   int res = 0;
   Commande.Parameters.Add("ID_frn", SqlDbType.Int);
   Direction("ID_frn", ParameterDirection.Output);


   Commande.Parameters.AddWithValue("@Nom", Nom);
   Commande.Parameters.AddWithValue("@Adresse", Adresse);
   Commande.Parameters.AddWithValue("@Email", Email);
   Commande.Parameters.AddWithValue("@GSM", GSM);
   Commande.Parameters.AddWithValue("@N_compte", N_compte);

   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID_frn"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID_frn, string Nom, string Adresse, string Email, string GSM, string N_compte)
  {
   CreerCommande("Modifiert_frn");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_frn", ID_frn);
   Commande.Parameters.AddWithValue("@Nom", Nom);
   Commande.Parameters.AddWithValue("@Adresse", Adresse);
   Commande.Parameters.AddWithValue("@Email", Email);
   Commande.Parameters.AddWithValue("@GSM", GSM);
   Commande.Parameters.AddWithValue("@N_compte", N_compte);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_frn> Lire(string Index)
  {
   CreerCommande("Selectionnert_frn");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_frn> res = new List<C_t_frn>();
   while (dr.Read())
   {
    C_t_frn tmp = new C_t_frn();
    tmp.ID_frn = int.Parse(dr["ID_frn"].ToString());
    tmp.Nom = dr["Nom"].ToString();
    tmp.Adresse = dr["Adresse"].ToString();
    tmp.Email = dr["Email"].ToString();
    tmp.GSM = dr["GSM"].ToString();
    tmp.N_compte = dr["N_compte"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_frn Lire_ID(int ID_frn)
  {
   CreerCommande("Selectionnert_frn_ID");
   Commande.Parameters.AddWithValue("@ID_frn", ID_frn);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_frn res = new C_t_frn();
   while (dr.Read())
   {
    res.ID_frn = int.Parse(dr["ID_frn"].ToString());
    res.Nom = dr["Nom"].ToString();
    res.Adresse = dr["Adresse"].ToString();
    res.Email = dr["Email"].ToString();
    res.GSM = dr["GSM"].ToString();
    res.N_compte = dr["N_compte"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID_frn)
  {
   CreerCommande("Supprimert_frn");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_frn", ID_frn);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
