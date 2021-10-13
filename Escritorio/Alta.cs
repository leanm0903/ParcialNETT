using Montenegro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Montenegro.Escritorio
{
    public partial class Alta : Form
    {
        public Negocio.Usuario UsuarioNegocio { get; set; }
        public Entidades.Usuario UsuarioActual { get; set; }
        public string msjError { get; set; }
        public Alta()
        {
            InitializeComponent();
            UsuarioNegocio = new Negocio.Usuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if  (!this.validForm())
            {
                MessageBox.Show(msjError);

            }
           

            else
            {
                var TipoUsu = Convert.ToInt32(this.txtTipoUsu.Text);
                Negocio.Usuario.Agregar(new Usuario(this.txtClave.Text, this.txtEmail.Text, this.txtNomUsu.Text, TipoUsu));
                this.msjError = "se genero correctamente";
                MessageBox.Show(msjError);

                this.Hide();

            }

        }
        public bool validForm()
        {
            bool valid = true;
            if (!Negocio.Validaciones.isEmailValid(this.txtEmail.Text))
            {
                valid = false;
                msjError = msjError+ "Email Invalido\n";
            }
              if (String.IsNullOrEmpty(txtClave.Text))
            {
                valid = false;
                msjError = msjError + "Clave vacio\n";

            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                valid = false;
                msjError = msjError + "Email vacio\n";
            }
            if (String.IsNullOrEmpty(txtNomUsu.Text))
            {
                valid = false;
                msjError = msjError + "Nombre de Usuario vacio\n";
            }
            if (String.IsNullOrEmpty(txtTipoUsu.Text))
            {
                valid = false;
                msjError = msjError + "TipoUsuario vacio\n";
            }
            return valid;

        }

    }
}
