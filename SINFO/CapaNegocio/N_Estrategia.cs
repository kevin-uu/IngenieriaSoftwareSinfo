using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINFO.models;

namespace SINFO.CapaNegocio
{
    public class N_Estrategia
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
    }
}
