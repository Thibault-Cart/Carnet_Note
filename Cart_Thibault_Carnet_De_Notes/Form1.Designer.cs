namespace Cart_Thibault_Carnet_De_Notes
{
    partial class FormAffichage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAffichage));
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAffichage = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPromotion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblmoyenne = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNbNotes = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblNbNoteInsuffisante = new System.Windows.Forms.Label();
            this.btnAjoutCours = new System.Windows.Forms.Button();
            this.btnSupressionUnCours = new System.Windows.Forms.Button();
            this.btnSupressionTousLesCours = new System.Windows.Forms.Button();
            this.rbNom = new System.Windows.Forms.RadioButton();
            this.rbNote = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des Cours...";
            // 
            // lbxAffichage
            // 
            this.lbxAffichage.FormattingEnabled = true;
            this.lbxAffichage.Location = new System.Drawing.Point(16, 38);
            this.lbxAffichage.Name = "lbxAffichage";
            this.lbxAffichage.Size = new System.Drawing.Size(257, 199);
            this.lbxAffichage.TabIndex = 0;
            this.lbxAffichage.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbxAffichage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxAffichage_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPromotion);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 43);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promotion";
            // 
            // lblPromotion
            // 
            this.lblPromotion.AutoSize = true;
            this.lblPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromotion.ForeColor = System.Drawing.Color.Blue;
            this.lblPromotion.Location = new System.Drawing.Point(110, 16);
            this.lblPromotion.Name = "lblPromotion";
            this.lblPromotion.Size = new System.Drawing.Size(41, 13);
            this.lblPromotion.TabIndex = 0;
            this.lblPromotion.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblmoyenne);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 43);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moyenne";
            // 
            // lblmoyenne
            // 
            this.lblmoyenne.AutoSize = true;
            this.lblmoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoyenne.ForeColor = System.Drawing.Color.Blue;
            this.lblmoyenne.Location = new System.Drawing.Point(39, 16);
            this.lblmoyenne.Name = "lblmoyenne";
            this.lblmoyenne.Size = new System.Drawing.Size(41, 13);
            this.lblmoyenne.TabIndex = 0;
            this.lblmoyenne.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNbNotes);
            this.groupBox3.Location = new System.Drawing.Point(157, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 43);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nombre de notes";
            // 
            // lblNbNotes
            // 
            this.lblNbNotes.AutoSize = true;
            this.lblNbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbNotes.ForeColor = System.Drawing.Color.Blue;
            this.lblNbNotes.Location = new System.Drawing.Point(39, 16);
            this.lblNbNotes.Name = "lblNbNotes";
            this.lblNbNotes.Size = new System.Drawing.Size(41, 13);
            this.lblNbNotes.TabIndex = 0;
            this.lblNbNotes.Text = "label2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblNbNoteInsuffisante);
            this.groupBox4.Location = new System.Drawing.Point(16, 341);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 43);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nombre de notes insuffisantes";
            // 
            // lblNbNoteInsuffisante
            // 
            this.lblNbNoteInsuffisante.AutoSize = true;
            this.lblNbNoteInsuffisante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbNoteInsuffisante.ForeColor = System.Drawing.Color.Blue;
            this.lblNbNoteInsuffisante.Location = new System.Drawing.Point(98, 16);
            this.lblNbNoteInsuffisante.Name = "lblNbNoteInsuffisante";
            this.lblNbNoteInsuffisante.Size = new System.Drawing.Size(41, 13);
            this.lblNbNoteInsuffisante.TabIndex = 0;
            this.lblNbNoteInsuffisante.Text = "label2";
            // 
            // btnAjoutCours
            // 
            this.btnAjoutCours.Location = new System.Drawing.Point(16, 394);
            this.btnAjoutCours.Name = "btnAjoutCours";
            this.btnAjoutCours.Size = new System.Drawing.Size(118, 37);
            this.btnAjoutCours.TabIndex = 1;
            this.btnAjoutCours.Text = "Ajouter un cours";
            this.btnAjoutCours.UseVisualStyleBackColor = true;
            this.btnAjoutCours.Click += new System.EventHandler(this.btnAjoutCours_Click);
            // 
            // btnSupressionUnCours
            // 
            this.btnSupressionUnCours.Location = new System.Drawing.Point(155, 394);
            this.btnSupressionUnCours.Name = "btnSupressionUnCours";
            this.btnSupressionUnCours.Size = new System.Drawing.Size(118, 37);
            this.btnSupressionUnCours.TabIndex = 2;
            this.btnSupressionUnCours.Text = "Supprimer un cours";
            this.btnSupressionUnCours.UseVisualStyleBackColor = true;
            this.btnSupressionUnCours.Click += new System.EventHandler(this.btnSupressionUnCours_Click);
            // 
            // btnSupressionTousLesCours
            // 
            this.btnSupressionTousLesCours.Location = new System.Drawing.Point(16, 450);
            this.btnSupressionTousLesCours.Name = "btnSupressionTousLesCours";
            this.btnSupressionTousLesCours.Size = new System.Drawing.Size(257, 37);
            this.btnSupressionTousLesCours.TabIndex = 3;
            this.btnSupressionTousLesCours.Text = "Tout Supprimer";
            this.btnSupressionTousLesCours.UseVisualStyleBackColor = true;
            this.btnSupressionTousLesCours.Click += new System.EventHandler(this.btnSupressionTousLesCours_Click);
            // 
            // rbNom
            // 
            this.rbNom.AutoSize = true;
            this.rbNom.Location = new System.Drawing.Point(114, 15);
            this.rbNom.Name = "rbNom";
            this.rbNom.Size = new System.Drawing.Size(89, 17);
            this.rbNom.TabIndex = 5;
            this.rbNom.TabStop = true;
            this.rbNom.Text = "Trier pas nom";
            this.rbNom.UseVisualStyleBackColor = true;
            this.rbNom.CheckedChanged += new System.EventHandler(this.rbNom_CheckedChanged);
            this.rbNom.Click += new System.EventHandler(this.rbNom_Click);
            // 
            // rbNote
            // 
            this.rbNote.AutoSize = true;
            this.rbNote.Location = new System.Drawing.Point(209, 15);
            this.rbNote.Name = "rbNote";
            this.rbNote.Size = new System.Drawing.Size(88, 17);
            this.rbNote.TabIndex = 6;
            this.rbNote.TabStop = true;
            this.rbNote.Text = "Trier par note";
            this.rbNote.UseVisualStyleBackColor = true;
            this.rbNote.CheckedChanged += new System.EventHandler(this.rbNote_CheckedChanged);
            this.rbNote.Click += new System.EventHandler(this.rbNom_Click);
            // 
            // FormAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 510);
            this.Controls.Add(this.rbNote);
            this.Controls.Add(this.rbNom);
            this.Controls.Add(this.btnSupressionTousLesCours);
            this.Controls.Add(this.btnSupressionUnCours);
            this.Controls.Add(this.btnAjoutCours);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxAffichage);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(322, 549);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(322, 549);
            this.Name = "FormAffichage";
            this.Text = " Carnets de notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxAffichage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPromotion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblmoyenne;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNbNotes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblNbNoteInsuffisante;
        private System.Windows.Forms.Button btnAjoutCours;
        private System.Windows.Forms.Button btnSupressionUnCours;
        private System.Windows.Forms.Button btnSupressionTousLesCours;
        private System.Windows.Forms.RadioButton rbNom;
        private System.Windows.Forms.RadioButton rbNote;
    }
}

