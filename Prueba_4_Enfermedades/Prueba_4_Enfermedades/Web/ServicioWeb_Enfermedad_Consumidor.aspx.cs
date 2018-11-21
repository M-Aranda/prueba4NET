using Prueba_4_Enfermedades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_4_Enfermedades.Web
{
    public partial class ServicioWeb_Enfermedad_Consumidor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            localhost.Productor ws = new localhost.Productor();
            int id = int.Parse(txtBuscar.Text);

            if (ws.BuscarPorId(id) == null)
            {
                lblResultado.Text = "No hay resultados";
            }else if(ws.BuscarPorId(id) != null)
            {
                lblResultado.Text = "Id= "+ws.BuscarPorId(id).id + ", Nombre= " + ws.BuscarPorId(id).nombre + ", Descripción= " + ws.BuscarPorId(id).descripcion + ", Año de descubrimiento= " + ws.BuscarPorId(id).anioDeDescubrimiento;
                //lblResultado.Text = ws.BuscarPorId(id).ToString(); //#esque no hice el ToString()

            }



        }
    }
}