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
    public class C_t_produit
    {
        #region Données membres
        private int _ID_produit;
        private string _Nom;
        private decimal _Prix_vente;
        private decimal _Prix_achat;
        private int _Quantite_stock;
        private double _TVA;
        private int _Seuil_stock;
        private DateTime? _DateSortie;

        #endregion
        #region Constructeurs
        public C_t_produit()
        { }
        public C_t_produit(string Nom_, decimal Prix_vente_, decimal Prix_achat_, int Quantite_stock_, double TVA_, int Seuil_stock_, DateTime DateSortie_)
        {
            Nom = Nom_;
            Prix_vente = Prix_vente_;
            Prix_achat = Prix_achat_;
            Quantite_stock = Quantite_stock_;
            TVA = TVA_;
            Seuil_stock = Seuil_stock_;
            DateSortie = DateSortie_;
        }
        public C_t_produit(int ID_produit_, string Nom_, decimal Prix_vente_, decimal Prix_achat_, int Quantite_stock_, double TVA_, int Seuil_stock_, DateTime Date_commande_)
         : this(Nom_, Prix_vente_, Prix_achat_, Quantite_stock_, TVA_, Seuil_stock_, Date_commande_)
        {
            ID_produit = ID_produit_;
        }
        #endregion
        #region Accesseurs
        public int ID_produit
        {
            get { return _ID_produit; }
            set { _ID_produit = value; }
        }
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
        public decimal Prix_vente
        {
            get { return _Prix_vente; }
            set { _Prix_vente = value; }
        }
        public decimal Prix_achat
        {
            get { return _Prix_achat; }
            set { _Prix_achat = value; }
        }
        public int Quantite_stock
        {
            get { return _Quantite_stock; }
            set { _Quantite_stock = value; }
        }
        public double TVA
        {
            get { return _TVA; }
            set { _TVA = value; }
        }
        public int Seuil_stock
        {
            get { return _Seuil_stock; }
            set { _Seuil_stock = value; }
        }
        public DateTime? DateSortie
        {
            get { return _DateSortie; }
            set { _DateSortie = value; }
        }
        #endregion
    }
}
