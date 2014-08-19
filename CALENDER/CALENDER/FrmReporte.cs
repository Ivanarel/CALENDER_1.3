using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace CALENDER
{
    public partial class FrmReporte : Form
    {
        private DateTime Fecha;
        public FrmReporte(DateTime Fecha)
        {
            InitializeComponent();
            this.Fecha = Fecha; 
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.rptv.RefreshReport();
            MuestraReporte();
        }

        private void MuestraReporte()
        {
            DSEventos.DTEventosRptDataTable dt;
            dt = DSEventos.ListadoEventosReporte(Fecha);
            rptv.LocalReport.DataSources.Clear();
            rptv.Reset();
            rptv.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DTEventosRpt", (DataTable)dt));
            rptv.LocalReport.ReportEmbeddedResource = "CALENDER.rptOrdenes.rdlc";
            rptv.LocalReport.DisplayName = "Bitacora Ordenes";
            Microsoft.Reporting.WinForms.ReportParameter parametro = default(Microsoft.Reporting.WinForms.ReportParameter);
            parametro = new Microsoft.Reporting.WinForms.ReportParameter("pDescSemana", DescripcionFecha());
            rptv.LocalReport.SetParameters(parametro);
            rptv.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rptv.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            rptv.RefreshReport();
        }

        private string DescripcionFecha()
        {
            DateTime FechaAux = Fecha;
            string Desc = "";
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            Desc = "Mes : " + dtinfo.GetMonthName(Fecha.Month).ToUpper() + " De " + Fecha.Year.ToString();
            return Desc; 
            //DateTime FechaAux = Fecha;
            //string Desc = "";
            //while (FechaAux.DayOfWeek != DayOfWeek.Monday)
            //    FechaAux = FechaAux.AddDays(-1);   
            //Desc = "De " + FechaAux.ToShortDateString();
            //FechaAux = FechaAux.AddDays(7);
            //Desc += " A " + FechaAux.ToShortDateString();
            //return Desc; 
        }
    }
}
