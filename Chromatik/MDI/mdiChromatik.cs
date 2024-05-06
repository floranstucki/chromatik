﻿using Chromatik.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chromatik.MDI
{
    public partial class mdiChromatik : Form
    {
        frmLogin frm = new frmLogin();
        bool _isAdmin = true;
        public mdiChromatik()
        {
            InitializeComponent();
            checkAdmin();
            frm.ShowDialog();
            
        }

        private void tsmiOuvrirCommandes_Click(object sender, EventArgs e)
        {
            OuvrirFormulaireMDI<frmListCommandes>(); 
        }

        private void tsmiOuvrirFavoris_Click(object sender, EventArgs e)
        {
            OuvrirFormulaireMDI<frmFavoris>();
        }

       

        private void tsmiAjouterCommande_Click(object sender, EventArgs e)
        {
            OuvrirFormulaireMDI<frmCommande>();            
        }

        private void tsmiOuvrirPanier_Click(object sender, EventArgs e)
        {
            OuvrirFormulaireMDI<frmPanier>();

        }

        private void tsmiUtilisateurProfil_Click(object sender, EventArgs e)
        {
             OuvrirFormulaireMDI<frmProfil>();  
        }

        private void tsmiUtilisateurLogOut_Click(object sender, EventArgs e)
        {
            Properties.Resources.token = null;
            Application.Restart();
        }
        private void tsmiAjouterStock_Click(object sender, EventArgs e)
        {
            OuvrirFormulaireMDI<frmStock>();
        }

        private void tsmiAjouterFournisseur_Click(object sender, EventArgs e)
        {
            OuvrirFormulaireMDI<frmFournisseur>();
        }

        private void tsmiOuvrirFournitures_Click(object sender, EventArgs e)
        {
            OuvrirFormulaireMDI<frmFournitures>();
        }

        private void tsmiOuvrirAdministrateur_Click(object sender, EventArgs e)
        {
            OuvrirFormulaireMDI<frmAdministrateur>();
        }

        /// <summary>
        /// cette fonction permets d'ouvrir une fenêtre à l'intérieur du mdi afin de ne pas avoir plusieurs fois le meme code dans chaque fonction qui permet d'ouvrir les sous menu du menustrip
        /// </summary>
        /// <typeparam name="T">Type Générique qui est chaque Form du Projet</typeparam>
        private void OuvrirFormulaireMDI<T>() where T : Form, new() 
        {
            // Vérifiez si le formulaire est déjà ouvert
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm is T)
                {
                    childForm.Activate();
                    return;
                }
            }

            // Si le formulaire n'est pas ouvert, on crée une nouvelle instance de la form
            T newForm = new T();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void tsmiFenetreHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal); // permet de disposer les fenêtres en mode horizontal
        }
        private void tsmiFenetreVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);// permet de disposer les fenêtres en mode vertical
        }

        private void tsmiQuitterFermer_Click(object sender, EventArgs e)
        {
            Application.Exit(); // permet de fermer l'application
        }

        public void checkAdmin()
        {
            if (_isAdmin)
            {
                tsmiOuvrirAdministrateur.Visible = true;
                tsmiAjouterStock.Visible = true;
                tsmiAjouterFournisseur.Visible = true;
                tssAjouter.Visible = true;
                tssOuvrir.Visible = true;
            }
            else
            {
                tsmiOuvrirAdministrateur.Visible = false;
                tsmiAjouterStock.Visible = false;
                tsmiAjouterFournisseur.Visible = false;
                tssAjouter.Visible = false;
                tssOuvrir.Visible = false;
            }
        }
    }
}