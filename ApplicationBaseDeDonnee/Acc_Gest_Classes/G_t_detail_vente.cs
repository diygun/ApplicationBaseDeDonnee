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
 public class G_t_detail_vente : G_Base
 {
  #region Constructeurs
  public G_t_detail_vente()
   : base()
  { }
  public G_t_detail_vente(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? ID_commande_client, int? ID_produit, int? Quantite, decimal? Prix_vente, double? TVA)
  { return new A_t_detail_vente(ChaineConnexion).Ajouter(ID_commande_client, ID_produit, Quantite, Prix_vente, TVA); }
  public int Modifier(int ID_detail_vente, int? ID_commande_client, int? ID_produit, int? Quantite, decimal? Prix_vente, double? TVA)
  { return new A_t_detail_vente(ChaineConnexion).Modifier(ID_detail_vente, ID_commande_client, ID_produit, Quantite, Prix_vente, TVA); }
  public List<C_t_detail_vente> Lire(string Index)
  { return new A_t_detail_vente(ChaineConnexion).Lire(Index); }
  public C_t_detail_vente Lire_ID(int ID_detail_vente)
  { return new A_t_detail_vente(ChaineConnexion).Lire_ID(ID_detail_vente); }
  public int Supprimer(int ID_detail_vente)
  { return new A_t_detail_vente(ChaineConnexion).Supprimer(ID_detail_vente); }
 }
}
