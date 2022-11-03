using SINFO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SINFO.CapaNegocio
{
    public class N_InseminacionP
    {
        #region Cargar Combobox Comunidad y Municipio, Comunidad Depende de Municipio

        public List<municipios> ObtenerCmbMunicipio()
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.municipios.ToList();
            }
        }
        public List<comunidad> ObtenerCmbComunidad(int idc) //recibimos 1 parametro 
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.comunidad.Where(m => m.idmunicipio2 == idc).ToList();
            }
        }

        #endregion

        #region Cargar Combobox Razas
        public List<razascerdos> ObtenerRazas()
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.razascerdos.ToList();
            }
        }
        #endregion

        #region Guardar Registro en tabla Inseminacion Porcina
        public void GuardarNuevaInseminacion(inseminacionporcina IPorcina) //recibe 1 Nseguimiento de tipo seguimiento osea un nuevo registro para la tabla seguimiento
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                db.inseminacionporcina.Add(IPorcina);
                db.SaveChanges();
            }
        }
        #endregion

        #region Cargar Data Grid View Actualizar Inseminacion Porcina
        public List<ListarDatosInseminacionPorcina_Result> ObtenerDatosIP() //la lista tipo ListarDatosSeguimientos_Result corresponde al procedimiento almacenado creado
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.ListarDatosInseminacionPorcina().ToList();
            }
        }

        #endregion

    }
}
