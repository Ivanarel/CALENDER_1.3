using System;
using System.Data;
namespace CALENDER {
        
    public partial class DsOrdenes {

        public static DsOrdenes.DtOrdenesDataTable ListadoOrdenes(DateTime Fecha)
        {
            DsOrdenes.DtOrdenesDataTable DTOrdenes = new DtOrdenesDataTable();
            DsOrdenes.DtOrdenesRow DROrden; 
            try
            {
                CFunciones.Conexion.ElComm.CommandText = "MuestraOrdenes";
                CFunciones.Conexion.ElComm.Parameters.Clear();
                CFunciones.Conexion.AgregarParametro("@Fecha", SqlDbType.SmallDateTime, ParameterDirection.Input, Fecha);
                if (CFunciones.Conexion.EjecutaReader())
                {
                    while (CFunciones.Conexion.ElDr.Read())
                    {
                        DROrden = (DsOrdenes.DtOrdenesRow)DTOrdenes.NewRow();
                        DROrden.IdOrden = (int)CFunciones.Conexion.ElDr["IdOrden"];
                        DROrden.Nombre = (string)CFunciones.Conexion.ElDr["Nombre"];
                        DROrden.Pendiente  = (bool)CFunciones.Conexion.ElDr["Pendiente"];
                        DTOrdenes.Rows.Add(DROrden);  
                    }
                }
            }
            catch (Exception exc) { }
            CFunciones.Conexion.Desconecta();  
            return DTOrdenes; 
        }

        public static DsOrdenes.DtOrdenesRow Orden(int IdOrden)
        {
            DsOrdenes.DtOrdenesDataTable DTOrdenes = new DtOrdenesDataTable();
            DsOrdenes.DtOrdenesRow DROrden= (DsOrdenes.DtOrdenesRow)DTOrdenes.NewRow();
            try
            {
                CFunciones.Conexion.ElComm.CommandText = "MuestraOrdenes";
                CFunciones.Conexion.ElComm.Parameters.Clear();
                CFunciones.Conexion.AgregarParametro("@IdOrden", SqlDbType.Int, ParameterDirection.Input, IdOrden);
                if (CFunciones.Conexion.EjecutaReader())
                {
                    if (CFunciones.Conexion.ElDr.Read())
                    { 
                        DROrden.IdOrden = (int)CFunciones.Conexion.ElDr["IdOrden"];
                        DROrden.Nombre = (string)CFunciones.Conexion.ElDr["Nombre"];
                        DROrden.Pendiente = (bool)CFunciones.Conexion.ElDr["Pendiente"];
                    }
                }
            }
            catch (Exception exc) { }
            CFunciones.Conexion.Desconecta();
            return DROrden;
        }

        public static DsOrdenes.DtOrdenesRow Orden(string NombreOrden)
        {
            DsOrdenes.DtOrdenesDataTable DTOrdenes = ListadoOrdenes(DateTime.Now);
            DsOrdenes.DtOrdenesRow DROrden= (DsOrdenes.DtOrdenesRow)DTOrdenes.NewRow();
            try
            {
                DROrden = (DsOrdenes.DtOrdenesRow)DTOrdenes.Select("Nombre = '" + NombreOrden + "'")[0];
            }
            catch (Exception exc) {return null; }
            return DROrden;
        }

    }
}
