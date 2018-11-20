using Prueba_4_Enfermedades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_4_Enfermedades.Web
{
    public partial class Index : System.Web.UI.Page

    {
        private EnfermedadesDeLaBDDataContext db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new EnfermedadesDeLaBDDataContext();
            btnRegistrar.Visible = true;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            btnRegistrar.Visible = true;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;

            gridEnf.DataBind();
            
            txtNombre.Text = "";
            txtDescripcion.Text = "";

        }
    }
}