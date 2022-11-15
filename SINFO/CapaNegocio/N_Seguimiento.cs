﻿using SINFO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CapaNegocio
{
    public class N_Seguimiento
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

        #region Cargar Data Grid View Actualizar
        public List<ListarDatosSeguimientoss_Result> ObtenerDatosSeguimient() //la lista tipo ListarDatosSeguimientos_Result corresponde al procedimiento almacenado creado
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.ListarDatosSeguimientoss().ToList();
            }
        }

        #endregion

        #region Guardar Registro en tabla Seguimiento
        public void GuardarNuevaActividad(seguimiento Nsegumiento) //recibe 1 Nseguimiento de tipo seguimiento osea un nuevo registro para la tabla seguimiento
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                db.seguimiento.Add(Nsegumiento);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
