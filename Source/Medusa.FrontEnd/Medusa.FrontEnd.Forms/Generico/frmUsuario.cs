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

            oUsuario.Nombre = "Juan";
            oUsuario.Password = "Perez";
            oUsuario.Activo = true;
            oUsuario.ForzarExpiracion = true;
            oUsuario.CantidadDias = 30;
            oUsuario.ProximaFechaExpiracion = DateTime.Today;
            oUsuario.MSTS = DateTime.Today;

            oUsuario.Insertar();

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void EliminarUsuario()
        {
            UsuarioDTO oUsuario = new UsuarioDTO();

            oUsuario.ID = 1;

            oUsuario.Eliminar();
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }

        private void ActualizarUsuario()
        {
            UsuarioDTO oUsuario = new UsuarioDTO();

            oUsuario.ID = 2;
            oUsuario.Nombre = "pepepe";
            oUsuario.Password = "popopo";
            oUsuario.Activo = true;
            oUsuario.ForzarExpiracion = true;
            oUsuario.CantidadDias = 30;
            oUsuario.ProximaFechaExpiracion = DateTime.Today;
            oUsuario.MSTS = DateTime.Today;

            oUsuario.Modificar();
        }

        private void btnBuscarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        private void BuscarUsuarios()
        {
            UsuarioDTO oUsuario = new UsuarioDTO();

            dgvUsuarios.DataSource = oUsuario.GetAll();
        }
    }
}
