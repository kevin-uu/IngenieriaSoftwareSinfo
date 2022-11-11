using SINFO.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SINFO
{
    public partial class FormRpMetas : Form
    {
        public FormRpMetas()
        {
            InitializeComponent();
        }

        private void FormRpMetas_Load(object sender, EventArgs e)
        {
            Cargarcmbestrategia();
            // TODO: esta línea de código carga datos en la tabla 'DSMetas.DataTable2' Puede moverla o quitarla según sea necesario.

                        
                this.DataTable2TableAdapter.Fill(this.DSMetas.DataTable2);

                this.reportViewer1.RefreshReport();
            
            
        }

        #region carga de combo Estrategia y combo Tipos de Actividades
        private void Cargarcmbestrategia()
        {
            N_Metas objMetas= new N_Metas();
            var lst = objMetas.ObCEst();
            if (lst.Count > 0)
            {
                cmbEstrategia.DisplayMember = "nombreestrategia"; //lo que se muestra
                cmbEstrategia.ValueMember = "idestrategia"; //lo que almacena
                cmbEstrategia.DataSource = lst; //muestra lo que he cargado en lst
            }
        }
        //metodo para cargar el como comunidad
        private void Cargarcmbtiposdeactividades()
        {
            N_Metas objMetas = new N_Metas();
            var id = (int)cmbEstrategia.SelectedValue;  // almaceno lo que se selecciona en municipio y un type cast para que sea entero
            var lst = objMetas.ObCtipoA(id); // obtengo los datos y pide un parametro id tipo int que se envia al where del metodo obtener
            if (lst.Count > 0)
            {
                cmbTipodeActividad.DisplayMember = "nombreactividad"; //lo que se muestra
                cmbTipodeActividad.ValueMember = "idtiposactividad"; //lo que almacena
                cmbTipodeActividad.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        private void cmbEstrategia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbTipodeActividad.SelectedIndex != -1) { }//osea si hay alguna informacion cargada
            Cargarcmbtiposdeactividades();//que ejecute la el metodo
        }

        #endregion

        #region Cargar Informe con el parametro de CmbTipodeActividad
        private void btnInforme_Click(object sender, EventArgs e)
        {
            
                ReportParameter p = new ReportParameter("Actividad", cmbTipodeActividad.Text);
                reportViewer1.LocalReport.SetParameters(p);
                reportViewer1.RefreshReport();
            
                       
        }
        #endregion

    }
}
