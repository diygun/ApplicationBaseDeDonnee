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
 public class A_t_client : ADBase
 {
  #region Constructeurs
  public A_t_client(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, string Adresse, string Email, string GSM)
  {
   CreerCommande("Ajoutert_client");
   int res = 0;
   Commande.Parameters.Add("ID_client", SqlDbType.Int);
   Direction("ID_client", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@Nom", Nom);
   if(Adresse == null) Commande.Parameters.AddWithValue("@Adresse", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Adresse", Adresse);
   if(Email == null) Commande.Parameters.AddWithValue("@Email", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Email", Email);
   if(GSM == null) Commande.Parameters.AddWithValue("@GSM", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@GSM", GSM);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID_client"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID_client, string Nom, string Adresse, string Email, string GSM)
  {
   CreerCommande("Modifiert_client");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_client", ID_client);
   Commande.Parameters.AddWithValue("@Nom", Nom);
   if(Adresse == null) Commande.Parameters.AddWithValue("@Adresse", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Adresse", Adresse);
   if(Email == null) Commande.Parameters.AddWithValue("@Email", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Email", Email);
   if(GSM == null) Commande.Parameters.AddWithValue("@GSM", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@GSM", GSM);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_client> Lire(string Index)
  {
   CreerCommande("Selectionnert_client");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_client> res = new List<C_t_client>();
   while (dr.Read())
   {
    C_t_client tmp = new C_t_client();
    tmp.ID_client = int.Parse(dr["ID_client"].ToString());
    tmp.Nom = dr["Nom"].ToString();
    tmp.Adresse = dr["Adresse"].ToString();
    tmp.Email = dr["Email"].ToString();
    tmp.GSM = dr["GSM"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_client Lire_ID(int ID_client)
  {
   CreerCommande("Selectionnert_client_ID");
   Commande.Parameters.AddWithValue("@ID_client", ID_client);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_client res = new C_t_client();
   while (dr.Read())
   {
    res.ID_client = int.Parse(dr["ID_client"].ToString());
    res.Nom = dr["Nom"].ToString();
    res.Adresse = dr["Adresse"].ToString();
    res.Email = dr["Email"].ToString();
    res.GSM = dr["GSM"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID_client)
  {
   CreerCommande("Supprimert_client");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_client", ID_client);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
