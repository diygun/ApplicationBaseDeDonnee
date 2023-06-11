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
 public class G_t_detail_achat : G_Base
 {
  #region Constructeurs
  public G_t_detail_achat()
   : base()
  { }
  public G_t_detail_achat(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int ID_commande_frn, int ID_produit, int Quantite, decimal Prix_unitaire, double TVA)
  { return new A_t_detail_achat(ChaineConnexion).Ajouter(ID_commande_frn, ID_produit, Quantite, Prix_unitaire, TVA); }
  public int Modifier(int ID_detail_achat, int ID_commande_frn, int ID_produit, int Quantite, decimal Prix_unitaire, double TVA)
  { return new A_t_detail_achat(ChaineConnexion).Modifier(ID_detail_achat, ID_commande_frn, ID_produit, Quantite, Prix_unitaire, TVA); }
  public List<C_t_detail_achat> Lire(string Index)
  { return new A_t_detail_achat(ChaineConnexion).Lire(Index); }
  public C_t_detail_achat Lire_ID(int ID_detail_achat)
  { return new A_t_detail_achat(ChaineConnexion).Lire_ID(ID_detail_achat); }
  public int Supprimer(int ID_detail_achat)
  { return new A_t_detail_achat(ChaineConnexion).Supprimer(ID_detail_achat); }
 }
}
