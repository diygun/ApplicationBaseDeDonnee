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
 public class G_t_frn : G_Base
 {
  #region Constructeurs
  public G_t_frn()
   : base()
  { }
  public G_t_frn(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, string Adresse, string Email, string GSM, string N_compte)
  { return new A_t_frn(ChaineConnexion).Ajouter(Nom, Adresse, Email, GSM, N_compte); }
  public int Modifier(int ID_frn, string Nom, string Adresse, string Email, string GSM, string N_compte)
  { return new A_t_frn(ChaineConnexion).Modifier(ID_frn, Nom, Adresse, Email, GSM, N_compte); }
  public List<C_t_frn> Lire(string Index)
  { return new A_t_frn(ChaineConnexion).Lire(Index); }
  public C_t_frn Lire_ID(int ID_frn)
  { return new A_t_frn(ChaineConnexion).Lire_ID(ID_frn); }
  public int Supprimer(int ID_frn)
  { return new A_t_frn(ChaineConnexion).Supprimer(ID_frn); }
 }
}
