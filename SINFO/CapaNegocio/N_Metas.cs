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
    }
}
