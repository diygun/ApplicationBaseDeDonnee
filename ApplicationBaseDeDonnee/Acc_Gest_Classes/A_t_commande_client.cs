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
 public class A_t_commande_client : ADBase
 {
  #region Constructeurs
  public A_t_commande_client(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int ID_client, DateTime Date_vente, DateTime Date_commande)
  {
   CreerCommande("Ajoutert_commande_client");
   int res = 0;
   Commande.Parameters.Add("ID_commande_client", SqlDbType.Int);
   Direction("ID_commande_client", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@ID_client", ID_client);
   Commande.Parameters.AddWithValue("@Date_vente", Date_vente);
   Commande.Parameters.AddWithValue("@Date_commande", Date_commande);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID_commande_client"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID_commande_client, int ID_client, DateTime Date_vente, DateTime Date_commande)
  {
   CreerCommande("Modifiert_commande_client");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_commande_client", ID_commande_client);
   Commande.Parameters.AddWithValue("@ID_client", ID_client);
   Commande.Parameters.AddWithValue("@Date_vente", Date_vente);
   Commande.Parameters.AddWithValue("@Date_commande", Date_commande);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_commande_client> Lire(string Index)
  {
   CreerCommande("Selectionnert_commande_client");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_commande_client> res = new List<C_t_commande_client>();
   while (dr.Read())
   {
    C_t_commande_client tmp = new C_t_commande_client();
    tmp.ID_commande_client = int.Parse(dr["ID_commande_client"].ToString());
    tmp.ID_client = int.Parse(dr["ID_client"].ToString());
    tmp.Date_vente = DateTime.Parse(dr["Date_vente"].ToString());
    tmp.Date_commande = DateTime.Parse(dr["Date_commande"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_commande_client Lire_ID(int ID_commande_client)
  {
   CreerCommande("Selectionnert_commande_client_ID");
   Commande.Parameters.AddWithValue("@ID_commande_client", ID_commande_client);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_commande_client res = new C_t_commande_client();
   while (dr.Read())
   {
    res.ID_commande_client = int.Parse(dr["ID_commande_client"].ToString());
    res.ID_client = int.Parse(dr["ID_client"].ToString());
    res.Date_vente = DateTime.Parse(dr["Date_vente"].ToString());
    res.Date_commande = DateTime.Parse(dr["Date_commande"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID_commande_client)
  {
   CreerCommande("Supprimert_commande_client");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID_commande_client", ID_commande_client);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
