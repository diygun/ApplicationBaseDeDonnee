#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_DB_ManagmentAPP.Classes;
using Projet_DB_ManagmentAPP.Acces;
#endregion

namespace Projet_DB_ManagmentAPP.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_t_commande_client : G_Base
 {
  #region Constructeurs
  public G_t_commande_client()
   : base()
  { }
  public G_t_commande_client(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int ID_client, DateTime Date_vente, DateTime Date_commande)
  { return new A_t_commande_client(ChaineConnexion).Ajouter(ID_client, Date_vente, Date_commande); }
  public int Modifier(int ID_commande_client, int ID_client, DateTime Date_vente, DateTime Date_commande)
  { return new A_t_commande_client(ChaineConnexion).Modifier(ID_commande_client, ID_client, Date_vente, Date_commande); }
  public List<C_t_commande_client> Lire(string Index)
  { return new A_t_commande_client(ChaineConnexion).Lire(Index); }
  public C_t_commande_client Lire_ID(int ID_commande_client)
  { return new A_t_commande_client(ChaineConnexion).Lire_ID(ID_commande_client); }
  public int Supprimer(int ID_commande_client)
  { return new A_t_commande_client(ChaineConnexion).Supprimer(ID_commande_client); }
 }
}
