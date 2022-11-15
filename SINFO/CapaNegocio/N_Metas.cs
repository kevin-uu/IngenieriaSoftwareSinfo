using SINFO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINFO.CapaNegocio
{
    public class N_Metas
    {
        #region Cargar Combobox Estrategia
        public List<estrategia> ObCEst()
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.estrategia.ToList();
            }
        }
        #endregion

        #region Cargar Combobox Tipo de Actividad, Depende de Estrategia
        public List<tipos_de_actividades> ObCtipoA(int ide)
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.tipos_de_actividades.Where(e => e.idestrategia2 == ide).ToList();
            }
        }
        #endregion

        #region Guardar Registro en tabla Metas
        public void GuardarNuevaActividadMestas(metas nMetas) //recibe 1 Nseguimiento de tipo seguimiento osea un nuevo registro para la tabla seguimiento
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                db.metas.Add(nMetas);
                db.SaveChanges();
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

        #region Cargar Data Grid View Actualizar Metas
        public List<ListarMetas_Result> ObtenerDatosMetas() //la lista tipo ListarDatosSeguimientos_Result corresponde al procedimiento almacenado creado
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.ListarMetas().ToList();
            }
        }

        #endregion
    }
}
