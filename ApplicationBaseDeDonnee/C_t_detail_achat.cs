#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_DB_ManagmentAPP.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_t_detail_achat
 {
  #region Données membres
  private int _ID_detail_achat;
  private int _ID_commande_frn;
  private int _ID_produit;
  private int _Quantite;
  private decimal _Prix_unitaire;
  private double _TVA;
  #endregion
  #region Constructeurs
  public C_t_detail_achat()
  { }
  public C_t_detail_achat(int ID_commande_frn_, int ID_produit_, int Quantite_, decimal Prix_unitaire_, double TVA_)
  {
   ID_commande_frn = ID_commande_frn_;
   ID_produit = ID_produit_;
   Quantite = Quantite_;
   Prix_unitaire = Prix_unitaire_;
   TVA = TVA_;
  }
  public C_t_detail_achat(int ID_detail_achat_, int ID_commande_frn_, int ID_produit_, int Quantite_, decimal Prix_unitaire_, double TVA_)
   : this(ID_commande_frn_, ID_produit_, Quantite_, Prix_unitaire_, TVA_)
  {
   ID_detail_achat = ID_detail_achat_;
  }
  #endregion
  #region Accesseurs
  public int ID_detail_achat
  {
   get { return _ID_detail_achat; }
   set { _ID_detail_achat = value; }
  }
  public int ID_commande_frn
  {
   get { return _ID_commande_frn; }
   set { _ID_commande_frn = value; }
  }
  public int ID_produit
  {
   get { return _ID_produit; }
   set { _ID_produit = value; }
  }
  public int Quantite
  {
   get { return _Quantite; }
   set { _Quantite = value; }
  }
  public decimal Prix_unitaire
  {
   get { return _Prix_unitaire; }
   set { _Prix_unitaire = value; }
  }
  public double TVA
  {
   get { return _TVA; }
   set { _TVA = value; }
  }
  #endregion
 }
}
