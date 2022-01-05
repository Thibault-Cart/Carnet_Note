
/*
 * 
 * Auteur: Thibault Cart
 * Date:04/11/2019 et 11/11/2019
 * Description: Il s’agit de réaliser une application qui simule le fonctionnement (simplifié) d’un carnet de notes.
 * Version: 2.0
 * 
 */using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cart_Thibault_Carnet_De_Notes
{
    public partial class frmAjouterModifier : Form
    {
        //Champs
        private string _nomcours = "";
        private double _noteCours = 0;
         Cours lenouveaucours;
        // Constructeurs

        public frmAjouterModifier()
        {
            InitializeComponent();
        }

        // Propriétés
        public double NoteCours { get => _noteCours; set => _noteCours = value; }
        public string Nomcours { get => _nomcours; set => _nomcours = value; }
        internal Cours Lenouveaucours { get => lenouveaucours; set => lenouveaucours = value; }

        //Méthodes

        public Cours GetCours()
        {
            return new Cours();
        }

        public void SetCours(Cours unCours)
        {

        }

        private void frmAjouterModifier_Load(object sender, EventArgs e)
        {
            if (NoteCours !=0&&Nomcours!= "")
            {
                txbNomCours.Text = Nomcours;
                nudNote.Value = (decimal)NoteCours;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Nomcours = txbNomCours.Text;
            NoteCours = Convert.ToDouble(nudNote.Value);

            Lenouveaucours = new Cours(Nomcours,NoteCours);

            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbNomCours_TextChanged(object sender, EventArgs e)
        {
            if (txbNomCours.Text != null && nudNote!= null)
            {
                Nomcours = txbNomCours.Text;
                NoteCours = Convert.ToDouble(nudNote.Value);
            }

        }
        private void txbNote_TextChanged(object sender, EventArgs e)
        {
            if (txbNomCours.Text != null && nudNote != null)
            {
                Nomcours = txbNomCours.Text;
                NoteCours = Convert.ToDouble(nudNote);
            }
        }
    }
}
