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
    public class C_t_commande_frn
    {
        #region Données membres
        private int _ID_commande_frn;
        private int _ID_frn;
        private DateTime _Date_commande;
        #endregion
        #region Constructeurs
        public C_t_commande_frn()
        { }
        public C_t_commande_frn(int ID_frn_, DateTime Date_commande_)
        {
            ID_frn = ID_frn_;
            Date_commande = Date_commande_;
        }
        public C_t_commande_frn(int ID_commande_frn_, int ID_frn_, DateTime Date_commande_)
         : this(ID_frn_, Date_commande_)
        {
            ID_commande_frn = ID_commande_frn_;

        }
        #endregion
        #region Accesseurs
        public int ID_commande_frn
        {
            get { return _ID_commande_frn; }
            set { _ID_commande_frn = value; }
        }
        public int ID_frn
        {
            get { return _ID_frn; }
            set { _ID_frn = value; }
        }
        public DateTime Date_commande
        {
            get { return _Date_commande; }
            set { _Date_commande = value; }
        }
        #endregion
    }
}
