/*
 * 
 * Auteur: Thibault Cart
 * Date:04/11/2019 et 11/11/2019
 * Description: Il s’agit de réaliser une application qui simule le fonctionnement (simplifié) d’un carnet de notes.
 * Version: 2.0
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Thibault_Carnet_De_Notes
{
    public class Cours
    {

        // Champs
        private string _nom;
        private double _note;

        // propriétés
        public string Nom { get => _nom; set => _nom = value; }
        public double Note{ get => _note; set => _note = value; }
        
        //Constructeurs
        public Cours(string leNom, double laNote)
        {
            Nom = leNom;
            Note = laNote;
        }

        public Cours() : this("Cours sans nom", 1.0)
        {
        }

        // Methodes
        public override string ToString()
        {
            return this.Nom + " : " + this.Note.ToString();
        }
    }
}
