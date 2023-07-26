using SINFO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINFO.CapaNegocio
{
    public class N_InseminacionB
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

        #region Cargar Combobox Institucion
        public List<institucion> ObtenerCmbInstitucion()
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.institucion.ToList();
            }
        }
        #endregion

        #region Cargar Data Grid View Actualizar Inseminacion Bovina
        public List<ListarDatosInseminacionB2_Result> ObtenerDatosIB() //la lista tipo ListarDatosSeguimientos_Result corresponde al procedimiento almacenado creado
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.ListarDatosInseminacionB2().ToList();
            }
        }

        #endregion

        #region Guardar Registro en tabla Inseminacion Bovina
        public void GuardarNuevaInseminacionB(inseminacionBovina IBovina) //recibe 1 NBovina de tipo seguimiento osea un nuevo registro para la tabla seguimiento
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                db.inseminacionBovina.Add(IBovina);
                db.SaveChanges();
            }
        }
        #endregion

        #region Cargar Data Grid View Actualizar Inseminacion Bovina Partos
        public List<ListarDatosInseminacionB3_Result> ObtenerDatosIPparto() //la lista tipo ListarDatosSeguimientos_Result corresponde al procedimiento almacenado creado
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.ListarDatosInseminacionB3().ToList();
            }
        }

        #endregion
    }
}
