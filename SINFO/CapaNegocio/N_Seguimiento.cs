using SINFO.models;
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

        #region Editar Registro en tabla Seguimiento
        public void ActualizarActividad(seguimiento Nsegumiento) //recibimos 1 parametro de tipo persona osea una fila de registro y se modificara lo que este mandando
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                db.Entry(Nsegumiento).State = EntityState.Modified; //modifica el estado de la tabla, lo que recibe en Nsegumiento estado modificado
                db.SaveChanges();

                
            }
        }
        #endregion

        #region Eliminar 1 Registro de Seguimiento
        public void EliminarRegistroSeguimiento(int Sid) // recibe un parametro int y lo recibe del metodo
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                db.seguimiento.Remove(db.seguimiento.Single(s => s.idsegimiento == Sid)); //con esto decimos que va a remover el registro del idseguimiento
                db.SaveChanges();                                                        //y lo guarda en Sid y pasa al metodo donde se recibe el parametro
            }
        }
        #endregion

        #region Buscar en tabla seguimiento por Actividad o por cualquier campo que desee
        public List<seguimiento> BuscarInformacionSeguimientoE(int EId)  // por estrategia recibira el id que contiene el combo y filtrar por estrategia
        {
            using (sinfoEntities db = new sinfoEntities())
            {
                return db.seguimiento.Where(s => s.idestrategia1 == EId).ToList();
            }
        }
        #endregion
    }
}
