using System;
namespace CALENDER {
    
    
    public partial class DSTipoEventos {

        public static DSTipoEventos.DTTipoEventosDataTable Listado()
        {
            DSTipoEventos.DTTipoEventosDataTable DTTipoEventos = new DTTipoEventosDataTable();
            DSTipoEventos.DTTipoEventosRow DRTipoEvento;
            try
            {
                CFunciones.Conexion.ElComm.CommandText = "MuestraTipoEventos";
                CFunciones.Conexion.ElComm.Parameters.Clear();
                if (CFunciones.Conexion.EjecutaReader())
                {
                    while (CFunciones.Conexion.ElDr.Read())
                    {
                        DRTipoEvento = (DSTipoEventos.DTTipoEventosRow)DTTipoEventos.NewRow();
                        DRTipoEvento.IdTipoEvento = (int)CFunciones.Conexion.ElDr["IdTipoEvento"];
                        DRTipoEvento.Nombre = (string)CFunciones.Conexion.ElDr["Nombre"];
                        DRTipoEvento.Tipo = (bool)CFunciones.Conexion.ElDr["Tipo"];
                        DTTipoEventos.Rows.Add(DRTipoEvento);
                    }
                }
            }
            catch (Exception exc) { }
            CFunciones.Conexion.Desconecta();
            return DTTipoEventos;
        }

    }
}
