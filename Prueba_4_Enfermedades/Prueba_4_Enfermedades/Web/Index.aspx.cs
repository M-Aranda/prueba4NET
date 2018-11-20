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

            gridEnfermedades.DataBind();
            gridEnfermedades.SelectedIndex = -1;
            
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtAnio.Text = "";
            txtId.Text = "";

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Enfermedad enf = new Enfermedad();
            enf.nombre = txtNombre.Text;
            enf.descripcion = txtDescripcion.Text;
            try  {
                enf.anioDeDescubrimiento = int.Parse(txtAnio.Text);
            } catch (Exception){
                enf.anioDeDescubrimiento = 0;
            }

            db.Enfermedads.InsertOnSubmit(enf);
            db.SubmitChanges();

            gridEnfermedades.DataBind();

            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtAnio.Text = "";
        }


        protected void cambiar (object sender, EventArgs e)
        {
            btnRegistrar.Visible = false;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;

            String id = gridEnfermedades.SelectedRow.Cells[1].Text;
            Enfermedad enf = db.Enfermedads.Where(en=>en.id==int.Parse(id)).FirstOrDefault();

            txtNombre.Text = enf.nombre;
            txtDescripcion.Text = enf.descripcion;
            txtAnio.Text = enf.anioDeDescubrimiento.ToString();

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            String id = "" + gridEnfermedades.SelectedRow.Cells[1].Text;
            Enfermedad enf = db.Enfermedads.Where(pa => pa.id == int.Parse(id)).FirstOrDefault();

            enf.nombre = txtNombre.Text;
            enf.descripcion = txtDescripcion.Text;
            try {
                enf.anioDeDescubrimiento = int.Parse(txtAnio.Text);
            } catch (Exception) {
                enf.anioDeDescubrimiento = 0;
            }

            db.SubmitChanges();

            gridEnfermedades.DataBind();
            gridEnfermedades.SelectedIndex = -1;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtAnio.Text = "";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            String id = gridEnfermedades.SelectedRow.Cells[1].Text;

            Enfermedad enf = db.Enfermedads.Where(pa => pa.id == int.Parse(id)).FirstOrDefault();

            db.Enfermedads.DeleteOnSubmit(enf);
            db.SubmitChanges();

            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnRegistrar.Visible = true;

            gridEnfermedades.DataBind();
            gridEnfermedades.SelectedIndex = -1;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtAnio.Text = "";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            EnfermedadesDeLaBD.SelectCommand = "SELECT * FROM Enfermedad " +
                "WHERE id="+id+" ";

        }
    }
}