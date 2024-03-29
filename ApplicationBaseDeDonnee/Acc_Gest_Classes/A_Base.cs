#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
#endregion

namespace Projet_DB_ManagmentAPP.Acces
{
 public class ADBase
  {
  #region Données membres
  protected SqlCommand _commande;
  #endregion
  #region Constructeurs (étendus)
  /// <summary>
  /// Constructeur par défaut
  /// </summary>
  /// <remarks>La chaîne de connexion est récupérée en argument</remarks>
  public ADBase(string sChaineConnexion)
  {
   _commande = new SqlCommand();
   _commande.Connection = new SqlConnection(sChaineConnexion);
  }
  /// <summary>
  /// Méthode assignant une procédure stockée
  /// </summary>
  /// <param name="sCommande">Nom de la procédure stockée</param>
  public void CreerCommande(string sCommande)
  {
   _commande.CommandType = CommandType.StoredProcedure;
   _commande.CommandText = sCommande;
  }
  /// <summary>
  /// Méthode assignant une procédure stockée ET une chaîne de connexion
  /// </summary>
  /// <param name="sCommande">Nom de la procédure stockée</param>
  /// <param name="sConnexion">Chaîne de connexion à utiliser</param>
  public void CreerCommande(string sCommande, string sConnexion)
  {
   _commande.Connection = new SqlConnection(sConnexion);
   _commande.CommandType = CommandType.StoredProcedure;
   _commande.CommandText = sCommande;
  }
  /// <summary>
  /// Méthode assignant une procédure stockée et le type de requête
  /// </summary>
  /// <param name="sCommande">Nom de la procédure stockée</param>
  /// <param name="bTypeProcedures">Type de requête (Vrai=stockée, Faux=Texte)</param>
  public void CreerCommande(string sCommande, bool bTypeRequete)
  {
   if (bTypeRequete)	_commande.CommandType = CommandType.StoredProcedure;
   else	_commande.CommandType = CommandType.Text;
   _commande.CommandText = sCommande;
  }
  /// <summary>
  /// Méthode assignant une procédure stockée, une chaîne de connexion et le type de requête
  /// </summary>
  /// <param name="sCommande">Nom de la procédure stockée</param>
  /// <param name="sConnexion">Chaîne de connexion à utiliser</param>
  /// <param name="bTypeProcedures">Type de requête (Vrai=stockée, Faux=Texte)</param>
  public void CreerCommande(string sCommande, bool bTypeRequete, string sConnexion)
  {
   _commande.Connection = new SqlConnection(sConnexion);
   if (bTypeRequete)	_commande.CommandType = CommandType.StoredProcedure;
   else	_commande.CommandType = CommandType.Text;
   _commande.CommandText = sCommande;
  }
  #endregion
  #region Accesseurs
  public SqlCommand Commande
  {
   get { return _commande; }
   set { _commande = value; }
  }
  #endregion
  #region Utilitaires
  public void Direction(string sParam, ParameterDirection dParam)
  {	Commande.Parameters[sParam].Direction = dParam;	}
  public string LireParametre(string sParam)
  {	return Commande.Parameters[sParam].Value.ToString();	}
  #endregion
 }
}
