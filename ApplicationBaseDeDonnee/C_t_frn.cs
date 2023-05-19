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
 public class C_t_frn
 {
  #region Données membres
  private int _ID_frn;
  private string _Nom;
  private string _Adresse;
  private string _Email;
  private string _GSM;
  private string _N_compte;
  #endregion
  #region Constructeurs
  public C_t_frn()
  { }
  public C_t_frn(string Nom_, string Adresse_, string Email_, string GSM_, string N_compte_)
  {
   Nom = Nom_;
   Adresse = Adresse_;
   Email = Email_;
   GSM = GSM_;
   N_compte = N_compte_;
  }
  public C_t_frn(int ID_frn_, string Nom_, string Adresse_, string Email_, string GSM_, string N_compte_)
   : this(Nom_, Adresse_, Email_, GSM_, N_compte_)
  {
   ID_frn = ID_frn_;
  }
  #endregion
  #region Accesseurs
  public int ID_frn
  {
   get { return _ID_frn; }
   set { _ID_frn = value; }
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
  public string N_compte
  {
   get { return _N_compte; }
   set { _N_compte = value; }
  }
  #endregion
 }
}
