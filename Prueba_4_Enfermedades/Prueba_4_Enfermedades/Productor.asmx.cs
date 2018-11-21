using Prueba_4_Enfermedades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Prueba_4_Enfermedades
{
    /// <summary>
    /// Summary description for Productor
    /// </summary>
    [WebService(Namespace = "http://linq.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Productor : System.Web.Services.WebService
    {

        private EnfermedadesDeLaBDDataContext db= new EnfermedadesDeLaBDDataContext();

        [WebMethod]
        public Enfermedad BuscarPorId(int id)
        {
            Enfermedad enf = new Enfermedad();
            var en = db.Enfermedads.SingleOrDefault(e => e.id == id);
            enf = (Enfermedad)en;
            return enf;

        }


    }
}

