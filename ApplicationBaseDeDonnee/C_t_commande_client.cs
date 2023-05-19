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
 public class C_t_commande_client
 {
  #region Données membres
  private int _ID_commande_client;
  private int _ID_client;
  private DateTime _Date_vente;
  private DateTime _Date_commande;
  #endregion
  #region Constructeurs
  public C_t_commande_client()
  { }
  public C_t_commande_client(int ID_client_, DateTime Date_vente_, DateTime Date_commande_)
  {
   ID_client = ID_client_;
   Date_vente = Date_vente_;
   Date_commande = Date_commande_;
  }
  public C_t_commande_client(int ID_commande_client_, int ID_client_, DateTime Date_vente_, DateTime Date_commande_)
   : this(ID_client_, Date_vente_, Date_commande_)
  {
   ID_commande_client = ID_commande_client_;
  }
  #endregion
  #region Accesseurs
  public int ID_commande_client
  {
   get { return _ID_commande_client; }
   set { _ID_commande_client = value; }
  }
  public int ID_client
  {
   get { return _ID_client; }
   set { _ID_client = value; }
  }
  public DateTime Date_vente
  {
   get { return _Date_vente; }
   set { _Date_vente = value; }
  }
  public DateTime Date_commande
  {
   get { return _Date_commande; }
   set { _Date_commande = value; }
  }
  #endregion
 }
}
