using Factura_2021.Modelos.DAO;
using Factura_2021.Modelos.Entidades;
using Factura_2021.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura_2021.Controladores
{
    public class LoginController
    {
        LoginView vista;

        public LoginController(LoginView view)
        {
            vista = view;
            vista.btn_Aceptar.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object sender, EventArgs e)
        {
            bool esValido = false;
            UsuarioDAO userDAO = new UsuarioDAO();

            Usuario user = new Usuario();
            user.Email = vista.txt_Email.Text;
            user.Clave = vista.txt_Contrasena.Text;

            esValido = userDAO.ValidarUsuario(user);
            if (esValido)
            {
                MessageBox.Show("Usuario Correcto");
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto, vuelva a intentarlo");

            }
        }
    }
}
