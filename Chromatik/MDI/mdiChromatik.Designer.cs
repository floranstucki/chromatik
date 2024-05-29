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
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenCart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tssOpen = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenAdminPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddInCart = new System.Windows.Forms.ToolStripMenuItem();
            this.tssAdd = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMDI
            // 
            this.mnsMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiUser,
            this.tsmiAdd,
            this.tsmiWindow,
            this.tsmiExit});
            this.mnsMDI.Location = new System.Drawing.Point(0, 0);
            this.mnsMDI.Name = "mnsMDI";
            this.mnsMDI.Size = new System.Drawing.Size(800, 24);
            this.mnsMDI.TabIndex = 1;
            this.mnsMDI.Text = "menuStrip1";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenFavorites,
            this.tsmiOpenCart,
            this.tsmiOpenOrders,
            this.tsmiOpenStock,
            this.tssOpen,
            this.tsmiOpenAdminPanel});
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(51, 20);
            this.tsmiOpen.Text = " &Open";
            // 
            // tsmiOpenFavorites
            // 
            this.tsmiOpenFavorites.Name = "tsmiOpenFavorites";
            this.tsmiOpenFavorites.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiOpenFavorites.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpenFavorites.Text = "Fa&vorites";
            this.tsmiOpenFavorites.Click += new System.EventHandler(this.tsmiOuvrirFavoris_Click);
            // 
            // tsmiOpenCart
            // 
            this.tsmiOpenCart.Name = "tsmiOpenCart";
            this.tsmiOpenCart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiOpenCart.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpenCart.Text = "&Cart";
            this.tsmiOpenCart.Click += new System.EventHandler(this.tsmiOuvrirPanier_Click);
            // 
            // tsmiOpenOrders
            // 
            this.tsmiOpenOrders.Name = "tsmiOpenOrders";
            this.tsmiOpenOrders.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiOpenOrders.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpenOrders.Text = "O&rders";
            this.tsmiOpenOrders.Click += new System.EventHandler(this.tsmiOuvrirCommandes_Click);
            // 
            // tsmiOpenStock
            // 
            this.tsmiOpenStock.Name = "tsmiOpenStock";
            this.tsmiOpenStock.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpenStock.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpenStock.Text = "&Stocks";
            this.tsmiOpenStock.Click += new System.EventHandler(this.tsmiOuvrirFournitures_Click);
            // 
            // tssOpen
            // 
            this.tssOpen.Name = "tssOpen";
            this.tssOpen.Size = new System.Drawing.Size(177, 6);
            this.tssOpen.Visible = false;
            // 
            // tsmiOpenAdminPanel
            // 
            this.tsmiOpenAdminPanel.Name = "tsmiOpenAdminPanel";
            this.tsmiOpenAdminPanel.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpenAdminPanel.Text = "A&dmin Panel";
            this.tsmiOpenAdminPanel.Visible = false;
            this.tsmiOpenAdminPanel.Click += new System.EventHandler(this.tsmiOuvrirAdministrateur_Click);
            // 
            // tsmiUser
            // 
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserProfile,
            this.tsmiUserLogOut});
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(42, 20);
            this.tsmiUser.Text = "&User";
            // 
            // tsmiUserProfile
            // 
            this.tsmiUserProfile.Name = "tsmiUserProfile";
            this.tsmiUserProfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmiUserProfile.Size = new System.Drawing.Size(180, 22);
            this.tsmiUserProfile.Text = "&Profile";
            this.tsmiUserProfile.Click += new System.EventHandler(this.tsmiUtilisateurProfil_Click);
            // 
            // tsmiUserLogOut
            // 
            this.tsmiUserLogOut.Name = "tsmiUserLogOut";
            this.tsmiUserLogOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiUserLogOut.Size = new System.Drawing.Size(180, 22);
            this.tsmiUserLogOut.Text = "Lo&g Out";
            this.tsmiUserLogOut.Click += new System.EventHandler(this.tsmiUtilisateurLogOut_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddInCart,
            this.tssAdd,
            this.tsmiAddStock,
            this.tsmiAddSupplier});
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(41, 20);
            this.tsmiAdd.Text = "&Add";
            // 
            // tsmiAddInCart
            // 
            this.tsmiAddInCart.Name = "tsmiAddInCart";
            this.tsmiAddInCart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiAddInCart.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddInCart.Text = "I&n Cart";
            this.tsmiAddInCart.Click += new System.EventHandler(this.tsmiAjouterCommande_Click);
            // 
            // tssAdd
            // 
            this.tssAdd.Name = "tssAdd";
            this.tssAdd.Size = new System.Drawing.Size(177, 6);
            this.tssAdd.Visible = false;
            // 
            // tsmiAddStock
            // 
            this.tsmiAddStock.Name = "tsmiAddStock";
            this.tsmiAddStock.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddStock.Text = "Stoc&k";
            this.tsmiAddStock.Visible = false;
            this.tsmiAddStock.Click += new System.EventHandler(this.tsmiAjouterStock_Click);
            // 
            // tsmiAddSupplier
            // 
            this.tsmiAddSupplier.Name = "tsmiAddSupplier";
            this.tsmiAddSupplier.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddSupplier.Text = "Supp&lier";
            this.tsmiAddSupplier.Visible = false;
            this.tsmiAddSupplier.Click += new System.EventHandler(this.tsmiAjouterFournisseur_Click);
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWindowHorizontal,
            this.tsmiWindowVertical});
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.Size = new System.Drawing.Size(63, 20);
            this.tsmiWindow.Text = "&Window";
            // 
            // tsmiWindowHorizontal
            // 
            this.tsmiWindowHorizontal.Name = "tsmiWindowHorizontal";
            this.tsmiWindowHorizontal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.tsmiWindowHorizontal.Size = new System.Drawing.Size(168, 22);
            this.tsmiWindowHorizontal.Text = "&Horizontal";
            this.tsmiWindowHorizontal.Click += new System.EventHandler(this.tsmiFenetreHorizontal_Click);
            // 
            // tsmiWindowVertical
            // 
            this.tsmiWindowVertical.Name = "tsmiWindowVertical";
            this.tsmiWindowVertical.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.tsmiWindowVertical.Size = new System.Drawing.Size(168, 22);
            this.tsmiWindowVertical.Text = "Vert&ical";
            this.tsmiWindowVertical.Click += new System.EventHandler(this.tsmiFenetreVertical_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExitClose});
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(38, 20);
            this.tsmiExit.Text = "&Exit";
            // 
            // tsmiExitClose
            // 
            this.tsmiExitClose.Name = "tsmiExitClose";
            this.tsmiExitClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiExitClose.Size = new System.Drawing.Size(227, 22);
            this.tsmiExitClose.Text = "Close &the application";
            this.tsmiExitClose.Click += new System.EventHandler(this.tsmiQuitterFermer_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenOrders;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFavorites;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenCart;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserLogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddInCart;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenAdminPanel;
        private System.Windows.Forms.ToolStripSeparator tssOpen;
        private System.Windows.Forms.ToolStripSeparator tssAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStock;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSupplier;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindowHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindowVertical;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenStock;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitClose;
    }
}