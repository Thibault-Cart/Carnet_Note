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
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cart_Thibault_Carnet_De_Notes
{
    public partial class FormAffichage : Form
    {
        frmAjouterModifier formajoutermodifier;
        Carnet leCarnet = new Carnet();



        public FormAffichage()
        {
            InitializeComponent();

            formajoutermodifier = new frmAjouterModifier();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UptdateView();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        

        public void UptdateView()
        {

            if (rbNom.Checked)
            {
                leCarnet.TrierParNom();
            }
            else
            {
                leCarnet.TrierParNote();
            }

            lbxAffichage.Items.Clear();
            
            foreach (Cours unCours in leCarnet.LstCours)
            {
                lbxAffichage.Items.Add(unCours);
            }
           

            lblNbNotes.Text = leCarnet.NombreNotes().ToString();
            lblNbNoteInsuffisante.Text = leCarnet.NombreNotesInsuffisantes().ToString();
            lblmoyenne.Text = leCarnet.Moyenne().ToString();
            bool etatpromotion = leCarnet.EstPromu();
            if (etatpromotion==true)
            {
                lblPromotion.Text = "Promue";
            }
            else
            {
                lblPromotion.Text = "non Promue";
            }



        }

        private void btnAjoutCours_Click(object sender, EventArgs e)
        {
            Cours CourAjouter;
           

            if (formajoutermodifier.ShowDialog() == DialogResult.OK)
            {
                CourAjouter = formajoutermodifier.Lenouveaucours;
                leCarnet.AjouterCours(CourAjouter);


            }

            UptdateView();
        }
        private void lbxAffichage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cours CouraModifier = (Cours)lbxAffichage.SelectedItem; ;
            formajoutermodifier.Nomcours = CouraModifier.Nom;
            formajoutermodifier.NoteCours = CouraModifier.Note;

            if (formajoutermodifier.ShowDialog() == DialogResult.OK)
            {
                CouraModifier = formajoutermodifier.Lenouveaucours;
                


            }

            UptdateView();
        }
        private void btnSupressionUnCours_Click(object sender, EventArgs e)
        {

            Cours leCoursAsupprimer = (Cours)lbxAffichage.SelectedItem;
            leCarnet.SupprimerCours(leCoursAsupprimer);
            UptdateView();
        }

        private void btnSupressionTousLesCours_Click(object sender, EventArgs e)
        {
            Cours leCoursAsupprimer = (Cours)lbxAffichage.SelectedItem;
            leCarnet.SupprimerTousLesCours();
            UptdateView();
        }

        private void rbNom_CheckedChanged(object sender, EventArgs e)
        {
            UptdateView();


        }

        private void rbNom_Click(object sender, EventArgs e)
        {
            UptdateView();
        }

        private void rbNote_CheckedChanged(object sender, EventArgs e)
        {
            UptdateView();
        }
    }
}
