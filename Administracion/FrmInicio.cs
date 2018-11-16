﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Administracion.ServicioWeb;

namespace Administracion
{
    public partial class FrmInicio : Form
    {
        internal Form f = null;

        public FrmInicio(Empleado em)
        {
            InitializeComponent();
            Empleado empLog = em;
            menuUsr.Text = em._NombreCompleto;
        }

        private void menuUsrSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuUsrCerrarS_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                f = new Login();
                f.Show();
            }
            catch (Exception ex)
            {
                Form f = new FormErrores(ex.Message);
                f.ShowDialog();
            }
        }

        private void menuEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
                f = new ABMEmpleado();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.WindowsDefaultLocation;
                f.Show();
            }
            catch (Exception ex)
            {
                Form f = new FormErrores(ex.Message);
                f.ShowDialog();
            }
        }

        private void menuTerm_Click(object sender, EventArgs e)
        {
            try
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
                f = new ABMTerminal();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.WindowsDefaultLocation;
                f.Show();
            }
            catch (Exception ex)
            {
                Form f = new FormErrores(ex.Message);
                f.ShowDialog();
            }
        }

    }
}
