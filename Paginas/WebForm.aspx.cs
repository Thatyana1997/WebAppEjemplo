using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEjemplo.Paginas
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        { // ctrl + k +d 
            string nombre = txtNombre.Text;
            int edad;

            if (int.TryParse(txtEdad.Text, out edad))
            {
                if (edad < 0)
                {
                    lblMensaje.Text = "Edad no valida. Ingrese una edad positiva";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    if (edad < 18)
                    {
                        lblMensaje.Text = "Todavia no cumples la mayoria de edad";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lblMensaje.Text = "Felicidades, tienes acceso";
                        lblMensaje.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                lblMensaje.Text = "Ingrese una edad valida";
            }

        }
    }
}