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
 public class C_t_client
 {
  #region Données membres
  private int _ID_client;
  private string _Nom;
  private string _Adresse;
  private string _Email;
  private string _GSM;
  #endregion
  #region Constructeurs
  public C_t_client()
  { }
  public C_t_client(string Nom_, string Adresse_, string Email_, string GSM_)
  {
   Nom = Nom_;
   Adresse = Adresse_;
   Email = Email_;
   GSM = GSM_;
  }
  public C_t_client(int ID_client_, string Nom_, string Adresse_, string Email_, string GSM_)
   : this(Nom_, Adresse_, Email_, GSM_)
  {
   ID_client = ID_client_;
  }
  #endregion
  #region Accesseurs
  public int ID_client
  {
   get { return _ID_client; }
   set { _ID_client = value; }
  }
  public string Nom
  {
   get { return _Nom; }
   set { _Nom = value; }
  }
  public string Adresse
  {
   get { return _Adresse; }
   set { _Adresse = value; }
  }
  public string Email
  {
   get { return _Email; }
   set { _Email = value; }
  }
  public string GSM
  {
   get { return _GSM; }
   set { _GSM = value; }
  }
  #endregion
 }
}
