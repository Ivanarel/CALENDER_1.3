using System;
using System.Data;

namespace CALENDER {
    
    
    public partial class DSEventos {

        public static DSEventos.DTEventosDataTable ListadoEventos(int IdOrden)
        {
            DSEventos.DTEventosDataTable DTEventos = new DTEventosDataTable();
            DSEventos.DTEventosRow DROrden;
            try
            {
                CFunciones.Conexion.ElComm.CommandText = "MuestraEventos";
                CFunciones.Conexion.ElComm.Parameters.Clear();
                CFunciones.Conexion.AgregarParametro("@IdOrden", SqlDbType.Int, ParameterDirection.Input, IdOrden);    
                if (CFunciones.Conexion.EjecutaReader())
                {
                    while (CFunciones.Conexion.ElDr.Read())
                    {
                        DROrden = (DSEventos.DTEventosRow)DTEventos.NewRow();
                        DROrden.IdEvento = (int)CFunciones.Conexion.ElDr["IdEventos"];
                        DROrden.IdOrden = (int)CFunciones.Conexion.ElDr["IdOrden"];
                        DROrden.FechaInicio = (DateTime)CFunciones.Conexion.ElDr["FechaInicio"];
                        try {DROrden.FechaFin = (DateTime)CFunciones.Conexion.ElDr["FechaFin"];  }
                        catch (Exception exc) {}                         
                        DROrden.Numero = (int)CFunciones.Conexion.ElDr["Numero"];
                        DROrden.Tipo = (int)CFunciones.Conexion.ElDr["Tipo"];
                        DTEventos.Rows.Add(DROrden);
                    }
                }
            }
            catch (Exception exc) { }
            CFunciones.Conexion.Desconecta();
            return DTEventos;
        }

        public static DSEventos.DTEventosRow Evento(int IdEvento)
        {
            DSEventos.DTEventosDataTable DTEventos = new DTEventosDataTable();
            DSEventos.DTEventosRow DROrden = (DSEventos.DTEventosRow)DTEventos.NewRow();
            try
            {
                CFunciones.Conexion.ElComm.CommandText = "MuestraEventos";
                CFunciones.Conexion.ElComm.Parameters.Clear();
                CFunciones.Conexion.AgregarParametro("@IdEvento", SqlDbType.Int, ParameterDirection.Input, IdEvento);
                if (CFunciones.Conexion.EjecutaReader())
                {
                    if (CFunciones.Conexion.ElDr.Read())
                    {
                        DROrden.IdEvento = (int)CFunciones.Conexion.ElDr["IdEventos"];
                        DROrden.IdOrden = (int)CFunciones.Conexion.ElDr["IdOrden"];
                        DROrden.FechaInicio = (DateTime)CFunciones.Conexion.ElDr["FechaInicio"];
                        try
                        {DROrden.FechaFin = (DateTime)CFunciones.Conexion.ElDr["FechaFin"];}
                        catch (Exception exc) { }
                        DROrden.Numero = (int)CFunciones.Conexion.ElDr["Numero"];
                        DROrden.Tipo = (int)CFunciones.Conexion.ElDr["Tipo"];
                    }
                }
            }
            catch (Exception exc) { }
            CFunciones.Conexion.Desconecta();
            return DROrden;
        }

        public static DSEventos.DTEventosRptDataTable ListadoEventosReporte(DateTime Fecha)
        {
            DSEventos.DTEventosRptDataTable DTEventos = new DTEventosRptDataTable();
            DSEventos.DTEventosRptRow DROrden;
            try
            {
                CFunciones.Conexion.ElComm.CommandText = "MuestraEventosReporte";
                CFunciones.Conexion.ElComm.Parameters.Clear();
                CFunciones.Conexion.AgregarParametro("@Fecha", SqlDbType.SmallDateTime, ParameterDirection.Input, Fecha);
                if (CFunciones.Conexion.EjecutaReader())
                {
                    while (CFunciones.Conexion.ElDr.Read())
                    {
                        DROrden = (DSEventos.DTEventosRptRow)DTEventos.NewRow();
                        DROrden.Tipo = (int)CFunciones.Conexion.ElDr["Tipo"];
                        DROrden.IdOrden = (int)CFunciones.Conexion.ElDr["IdOrden"];
                        DROrden.NombreOrden = (string)CFunciones.Conexion.ElDr["Nombre"];
                        if (DROrden.Tipo == (int)CFunciones.Evento.D)
                            DROrden.NombreEvento = ((CFunciones.Evento)(int)CFunciones.Conexion.ElDr["Tipo"]).ToString() + 
                                CFunciones.Conexion.ElDr["Numero"].ToString();
                        else
                            DROrden.NombreEvento = ((CFunciones.Evento)(int)CFunciones.Conexion.ElDr["Tipo"]).ToString();
                        DROrden.IdEvento = (int)CFunciones.Conexion.ElDr["IdEventos"];
                        if (DROrden.Tipo == (int)CFunciones.Evento.Iniciado)
                        {
                             try
                             { DROrden.FechaInicio = ((DateTime)CFunciones.Conexion.ElDr["FechaInicio"]).ToString(); }
                             catch (Exception exc) { }
                        }
                        else if (DROrden.Tipo == (int)CFunciones.Evento.Fin)
                        {
                            try
                            { DROrden.FechaFin = ((DateTime)CFunciones.Conexion.ElDr["FechaFin"]).ToString(); }
                            catch (Exception exc) { }
                        }
                        else
                        {
                            try
                            { DROrden.FechaInicio = ((DateTime)CFunciones.Conexion.ElDr["FechaInicio"]).ToShortTimeString(); }
                            catch (Exception exc) { }
                            try
                            { DROrden.FechaFin = ((DateTime)CFunciones.Conexion.ElDr["FechaFin"]).ToShortTimeString(); }
                            catch (Exception exc) { }
                        }
                        DTEventos.Rows.Add(DROrden);
                    }
                }
            }
            catch (Exception exc) { }
            CFunciones.Conexion.Desconecta();
            return DTEventos;
        }

    }
}
