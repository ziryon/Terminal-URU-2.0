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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sweb = new ServicioTURU();
                string ci = txtUsr.Text;
                string pass = txtPass.Text;

                Empleado emp = Sweb.Logueo(ci, pass);

                if (emp == null)
                    throw new Exception("Usuario o contraseña invalidos");                
                else
                {
                    this.Hide();
                    Form f = new FrmInicio(emp);
                    f.Show();
                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblError.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
