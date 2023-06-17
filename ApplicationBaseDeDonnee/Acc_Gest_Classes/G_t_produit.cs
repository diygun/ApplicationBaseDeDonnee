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
 public class G_t_produit : G_Base
 {
  #region Constructeurs
  public G_t_produit()
   : base()
  { }
  public G_t_produit(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, decimal Prix_vente, decimal Prix_achat, int Quantite_stock, double TVA, int Seuil_stock, DateTime DateSortie)
  { return new A_t_produit(ChaineConnexion).Ajouter(Nom, Prix_vente, Prix_achat, Quantite_stock, TVA, Seuil_stock, DateSortie); }
  public int Modifier(int ID_produit, string Nom, decimal Prix_vente, decimal Prix_achat, int Quantite_stock, double TVA, int Seuil_stock, DateTime DateSortie)
  { return new A_t_produit(ChaineConnexion).Modifier(ID_produit, Nom, Prix_vente, Prix_achat, Quantite_stock, TVA, Seuil_stock, DateSortie); }
  public List<C_t_produit> Lire(string Index)
  { return new A_t_produit(ChaineConnexion).Lire(Index); }
  public C_t_produit Lire_ID(int ID_produit)
  { return new A_t_produit(ChaineConnexion).Lire_ID(ID_produit); }
  public int Supprimer(int ID_produit)
  { return new A_t_produit(ChaineConnexion).Supprimer(ID_produit); }
 }
}
