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
    class Carnet
    {
        // Constantes
        private const double MOYENNE = 3.95;
        private const int NOTES_INSUFFISANTES_MAX = 3;

        //Champs
        private List<Cours> _lstCours;

        //Propriétés
        internal List<Cours> LstCours { get => _lstCours; set => _lstCours = value; }

        // Constructeurs


        public Carnet()
        {

            this.LstCours = new List<Cours>();

            // Données de tests
            this.AjouterCours(new Cours("Math", 5.5));
            this.AjouterCours(new Cours("Francais", 4.5));
            this.AjouterCours(new Cours("Physique", 5));
            this.AjouterCours(new Cours("Chimie", 3));

        }

        public void TrierParNom()
        {
            
            
            LstCours = this.LstCours.OrderBy(cours => cours.Nom).ToList();

        }
        public void TrierParNote()
        {

            LstCours = this.LstCours.OrderByDescending(cours => cours.Note).ToList();
        }

        //Méthodes

        public void AjouterCours(Cours unCours)
        {
            LstCours.Add(unCours);
        }
        public void SupprimerCours(Cours unCours)
        {
            LstCours.Remove(unCours);

        }

        public void SupprimerTousLesCours()
        {
            LstCours.Clear();
        }

        public override string ToString()
        {
            // Initialisation
            string chaineCarnet = string.Empty;

            // Traitement...
            foreach (Cours cours in this.LstCours)
            {
                chaineCarnet += cours.ToString() + Environment.NewLine;
            }

            // Sortie
            return chaineCarnet;
        }

        public bool EstPromu()
        {
            int nbnteinsuffisante = NombreNotesInsuffisantes();
            double lamoyenne = Moyenne();
            bool Estpromu = false;
            if (nbnteinsuffisante <= NOTES_INSUFFISANTES_MAX && lamoyenne >= MOYENNE)
            {
                Estpromu = true;
            }
            return Estpromu;
        }
        public double Moyenne()
        {
            double nbnote = NombreNotes();
            double SommeNote = SommeTotalNotes();
            double laMoyenne = SommeNote / nbnote;
            return laMoyenne;
        }
        public int NombreNotes()
        {

            return LstCours.Count;
        }
        public int NombreNotesInsuffisantes()
        {
            int nbNoteInfuffisante = 0;
            foreach (Cours c in LstCours)
            {
                if (c.Note < MOYENNE)
                {
                    nbNoteInfuffisante++;
                }
            }
            return nbNoteInfuffisante;
        }




        public double SommeTotalNotes()
        {
            double laSommeDesNotes = 0;
            foreach (Cours unCours in this.LstCours)
            {
                laSommeDesNotes += unCours.Note;
            }

            return laSommeDesNotes;
        }

    }
}
