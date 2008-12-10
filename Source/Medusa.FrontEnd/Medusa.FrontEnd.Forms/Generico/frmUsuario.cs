using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medusa.Generico.DTO;

namespace Medusa.FrontEnd.Forms
{
    public partial class frmUsuario : frmABMBase
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            RegistrarUsuario();
        }

        private void RegistrarUsuario()
        {
            UsuarioDTO oUsuario = new UsuarioDTO();

            oUsuario.Nombre = "gerardo";
            oUsuario.Password = "ggggg";
            oUsuario.Activo = true;
            oUsuario.ForzarExpiracion = true;
            oUsuario.CantidadDias = 30;
            oUsuario.ProximaFechaExpiracion = DateTime.Today;
            oUsuario.MSTS = DateTime.Today;

            oUsuario.Insertar();

        }
    }
}
