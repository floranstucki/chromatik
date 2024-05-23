namespace Chromatik.MDI
{
    partial class mdiChromatik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsMDI = new System.Windows.Forms.MenuStrip();
            this.tsmiOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrirFavoris = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrirPanier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrirCommandes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrirFournitures = new System.Windows.Forms.ToolStripMenuItem();
            this.tssOuvrir = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOuvrirAdministrateur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUtilisateurProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUtilisateurLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjouterCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.tssAjouter = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAjouterStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjouterFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFenetre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFenetreHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFenetreVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuitterFermer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMDI
            // 
            this.mnsMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOuvrir,
            this.tsmiUtilisateur,
            this.tsmiAjouter,
            this.tsmiFenetre,
            this.tsmiQuitter});
            this.mnsMDI.Location = new System.Drawing.Point(0, 0);
            this.mnsMDI.Name = "mnsMDI";
            this.mnsMDI.Size = new System.Drawing.Size(800, 24);
            this.mnsMDI.TabIndex = 1;
            this.mnsMDI.Text = "menuStrip1";
            // 
            // tsmiOuvrir
            // 
            this.tsmiOuvrir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOuvrirFavoris,
            this.tsmiOuvrirPanier,
            this.tsmiOuvrirCommandes,
            this.tsmiOuvrirFournitures,
            this.tssOuvrir,
            this.tsmiOuvrirAdministrateur});
            this.tsmiOuvrir.Name = "tsmiOuvrir";
            this.tsmiOuvrir.Size = new System.Drawing.Size(52, 20);
            this.tsmiOuvrir.Text = "&Ouvrir";
            // 
            // tsmiOuvrirFavoris
            // 
            this.tsmiOuvrirFavoris.Name = "tsmiOuvrirFavoris";
            this.tsmiOuvrirFavoris.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiOuvrirFavoris.Size = new System.Drawing.Size(184, 22);
            this.tsmiOuvrirFavoris.Text = "Fa&voris";
            this.tsmiOuvrirFavoris.Click += new System.EventHandler(this.tsmiOuvrirFavoris_Click);
            // 
            // tsmiOuvrirPanier
            // 
            this.tsmiOuvrirPanier.Name = "tsmiOuvrirPanier";
            this.tsmiOuvrirPanier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiOuvrirPanier.Size = new System.Drawing.Size(184, 22);
            this.tsmiOuvrirPanier.Text = "&Panier";
            this.tsmiOuvrirPanier.Click += new System.EventHandler(this.tsmiOuvrirPanier_Click);
            // 
            // tsmiOuvrirCommandes
            // 
            this.tsmiOuvrirCommandes.Name = "tsmiOuvrirCommandes";
            this.tsmiOuvrirCommandes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiOuvrirCommandes.Size = new System.Drawing.Size(184, 22);
            this.tsmiOuvrirCommandes.Text = "&Commandes";
            this.tsmiOuvrirCommandes.Click += new System.EventHandler(this.tsmiOuvrirCommandes_Click);
            // 
            // tsmiOuvrirFournitures
            // 
            this.tsmiOuvrirFournitures.Name = "tsmiOuvrirFournitures";
            this.tsmiOuvrirFournitures.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOuvrirFournitures.Size = new System.Drawing.Size(184, 22);
            this.tsmiOuvrirFournitures.Text = "Fou&rnitures";
            this.tsmiOuvrirFournitures.Click += new System.EventHandler(this.tsmiOuvrirFournitures_Click);
            // 
            // tssOuvrir
            // 
            this.tssOuvrir.Name = "tssOuvrir";
            this.tssOuvrir.Size = new System.Drawing.Size(181, 6);
            // 
            // tsmiOuvrirAdministrateur
            // 
            this.tsmiOuvrirAdministrateur.Name = "tsmiOuvrirAdministrateur";
            this.tsmiOuvrirAdministrateur.Size = new System.Drawing.Size(184, 22);
            this.tsmiOuvrirAdministrateur.Text = "A&dministrateur";
            this.tsmiOuvrirAdministrateur.Click += new System.EventHandler(this.tsmiOuvrirAdministrateur_Click);
            // 
            // tsmiUtilisateur
            // 
            this.tsmiUtilisateur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUtilisateurProfil,
            this.tsmiUtilisateurLogOut});
            this.tsmiUtilisateur.Name = "tsmiUtilisateur";
            this.tsmiUtilisateur.Size = new System.Drawing.Size(72, 20);
            this.tsmiUtilisateur.Text = "&Utilisateur";
            // 
            // tsmiUtilisateurProfil
            // 
            this.tsmiUtilisateurProfil.Name = "tsmiUtilisateurProfil";
            this.tsmiUtilisateurProfil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmiUtilisateurProfil.Size = new System.Drawing.Size(195, 22);
            this.tsmiUtilisateurProfil.Text = "Prof&il";
            this.tsmiUtilisateurProfil.Click += new System.EventHandler(this.tsmiUtilisateurProfil_Click);
            // 
            // tsmiUtilisateurLogOut
            // 
            this.tsmiUtilisateurLogOut.Name = "tsmiUtilisateurLogOut";
            this.tsmiUtilisateurLogOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiUtilisateurLogOut.Size = new System.Drawing.Size(195, 22);
            this.tsmiUtilisateurLogOut.Text = "Se déconnec&ter";
            this.tsmiUtilisateurLogOut.Click += new System.EventHandler(this.tsmiUtilisateurLogOut_Click);
            // 
            // tsmiAjouter
            // 
            this.tsmiAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAjouterCommande,
            this.tssAjouter,
            this.tsmiAjouterStock,
            this.tsmiAjouterFournisseur});
            this.tsmiAjouter.Name = "tsmiAjouter";
            this.tsmiAjouter.Size = new System.Drawing.Size(58, 20);
            this.tsmiAjouter.Text = "&Ajouter";
            // 
            // tsmiAjouterCommande
            // 
            this.tsmiAjouterCommande.Name = "tsmiAjouterCommande";
            this.tsmiAjouterCommande.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiAjouterCommande.Size = new System.Drawing.Size(180, 22);
            this.tsmiAjouterCommande.Text = "Co&mmande";
            this.tsmiAjouterCommande.Click += new System.EventHandler(this.tsmiAjouterCommande_Click);
            // 
            // tssAjouter
            // 
            this.tssAjouter.Name = "tssAjouter";
            this.tssAjouter.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiAjouterStock
            // 
            this.tsmiAjouterStock.Name = "tsmiAjouterStock";
            this.tsmiAjouterStock.Size = new System.Drawing.Size(180, 22);
            this.tsmiAjouterStock.Text = "Stoc&k";
            this.tsmiAjouterStock.Click += new System.EventHandler(this.tsmiAjouterStock_Click);
            // 
            // tsmiAjouterFournisseur
            // 
            this.tsmiAjouterFournisseur.Name = "tsmiAjouterFournisseur";
            this.tsmiAjouterFournisseur.Size = new System.Drawing.Size(180, 22);
            this.tsmiAjouterFournisseur.Text = "Fourni&sseur";
            this.tsmiAjouterFournisseur.Click += new System.EventHandler(this.tsmiAjouterFournisseur_Click);
            // 
            // tsmiFenetre
            // 
            this.tsmiFenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFenetreHorizontal,
            this.tsmiFenetreVertical});
            this.tsmiFenetre.Name = "tsmiFenetre";
            this.tsmiFenetre.Size = new System.Drawing.Size(58, 20);
            this.tsmiFenetre.Text = "&Fenêtre";
            // 
            // tsmiFenetreHorizontal
            // 
            this.tsmiFenetreHorizontal.Name = "tsmiFenetreHorizontal";
            this.tsmiFenetreHorizontal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.tsmiFenetreHorizontal.Size = new System.Drawing.Size(168, 22);
            this.tsmiFenetreHorizontal.Text = "Hori&zontal";
            this.tsmiFenetreHorizontal.Click += new System.EventHandler(this.tsmiFenetreHorizontal_Click);
            // 
            // tsmiFenetreVertical
            // 
            this.tsmiFenetreVertical.Name = "tsmiFenetreVertical";
            this.tsmiFenetreVertical.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.tsmiFenetreVertical.Size = new System.Drawing.Size(168, 22);
            this.tsmiFenetreVertical.Text = "&Vertical";
            this.tsmiFenetreVertical.Click += new System.EventHandler(this.tsmiFenetreVertical_Click);
            // 
            // tsmiQuitter
            // 
            this.tsmiQuitter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQuitterFermer});
            this.tsmiQuitter.Name = "tsmiQuitter";
            this.tsmiQuitter.Size = new System.Drawing.Size(56, 20);
            this.tsmiQuitter.Text = "&Quitter";
            // 
            // tsmiQuitterFermer
            // 
            this.tsmiQuitterFermer.Name = "tsmiQuitterFermer";
            this.tsmiQuitterFermer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiQuitterFermer.Size = new System.Drawing.Size(221, 22);
            this.tsmiQuitterFermer.Text = "Fermer l\'app&lication";
            this.tsmiQuitterFermer.Click += new System.EventHandler(this.tsmiQuitterFermer_Click);
            // 
            // mdiChromatik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsMDI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMDI;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdiChromatik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface Utilisateur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.mdiChromatik_Activated);
            this.mnsMDI.ResumeLayout(false);
            this.mnsMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrir;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrirCommandes;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrirFavoris;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrirPanier;
        private System.Windows.Forms.ToolStripMenuItem tsmiUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem tsmiUtilisateurProfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiUtilisateurLogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouter;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouterCommande;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrirAdministrateur;
        private System.Windows.Forms.ToolStripSeparator tssOuvrir;
        private System.Windows.Forms.ToolStripSeparator tssAjouter;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouterStock;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouterFournisseur;
        private System.Windows.Forms.ToolStripMenuItem tsmiFenetre;
        private System.Windows.Forms.ToolStripMenuItem tsmiFenetreHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmiFenetreVertical;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrirFournitures;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuitter;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuitterFermer;
    }
}