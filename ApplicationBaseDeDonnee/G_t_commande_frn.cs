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
 public class G_t_commande_frn : G_Base
 {
  #region Constructeurs
  public G_t_commande_frn()
   : base()
  { }
  public G_t_commande_frn(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int ID_commande_frn, int ID_frn, DateTime Date_commande)
  { return new A_t_commande_frn(ChaineConnexion).Ajouter(ID_commande_frn, ID_frn, Date_commande); }
  public int Modifier(int ID_commande_frn/*, int ID_commande_frn*/, int ID_frn, DateTime Date_commande)
  { return new A_t_commande_frn(ChaineConnexion).Modifier(ID_commande_frn, ID_frn, Date_commande); }
  public List<C_t_commande_frn> Lire(string Index)
  { return new A_t_commande_frn(ChaineConnexion).Lire(Index); }
  public C_t_commande_frn Lire_ID(int ID_commande_frn)
  { return new A_t_commande_frn(ChaineConnexion).Lire_ID(ID_commande_frn); }
  public int Supprimer(int ID_commande_frn)
  { return new A_t_commande_frn(ChaineConnexion).Supprimer(ID_commande_frn); }
 }
}
