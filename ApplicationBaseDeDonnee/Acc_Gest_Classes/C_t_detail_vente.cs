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
 public class C_t_detail_vente
 {
  #region Données membres
  private int _ID_detail_vente;
  private int? _ID_commande_client;
  private int? _ID_produit;
  private int? _Quantite;
  private decimal? _Prix_vente;
  private double? _TVA;
  #endregion
  #region Constructeurs
  public C_t_detail_vente()
  { }
  public C_t_detail_vente(int? ID_commande_client_, int? ID_produit_, int? Quantite_, decimal? Prix_vente_, double? TVA_)
  {
   ID_commande_client = ID_commande_client_;
   ID_produit = ID_produit_;
   Quantite = Quantite_;
   Prix_vente = Prix_vente_;
   TVA = TVA_;
  }
  public C_t_detail_vente(int ID_detail_vente_, int? ID_commande_client_, int? ID_produit_, int? Quantite_, decimal? Prix_vente_, double? TVA_)
   : this(ID_commande_client_, ID_produit_, Quantite_, Prix_vente_, TVA_)
  {
   ID_detail_vente = ID_detail_vente_;
  }
  #endregion
  #region Accesseurs
  public int ID_detail_vente
  {
   get { return _ID_detail_vente; }
   set { _ID_detail_vente = value; }
  }
  public int? ID_commande_client
  {
   get { return _ID_commande_client; }
   set { _ID_commande_client = value; }
  }
  public int? ID_produit
  {
   get { return _ID_produit; }
   set { _ID_produit = value; }
  }
  public int? Quantite
  {
   get { return _Quantite; }
   set { _Quantite = value; }
  }
  public decimal? Prix_vente
  {
   get { return _Prix_vente; }
   set { _Prix_vente = value; }
  }
  public double? TVA
  {
   get { return _TVA; }
   set { _TVA = value; }
  }
  #endregion
 }
}
