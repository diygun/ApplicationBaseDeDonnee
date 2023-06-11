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
 public class G_t_client : G_Base
 {
  #region Constructeurs
  public G_t_client()
   : base()
  { }
  public G_t_client(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, string Adresse, string Email, string GSM)
  { return new A_t_client(ChaineConnexion).Ajouter(Nom, Adresse, Email, GSM); }
  public int Modifier(int ID_client, string Nom, string Adresse, string Email, string GSM)
  { return new A_t_client(ChaineConnexion).Modifier(ID_client, Nom, Adresse, Email, GSM); }
  public List<C_t_client> Lire(string Index)
  { return new A_t_client(ChaineConnexion).Lire(Index); }
  public C_t_client Lire_ID(int ID_client)
  { return new A_t_client(ChaineConnexion).Lire_ID(ID_client); }
  public int Supprimer(int ID_client)
  { return new A_t_client(ChaineConnexion).Supprimer(ID_client); }
 }
}
