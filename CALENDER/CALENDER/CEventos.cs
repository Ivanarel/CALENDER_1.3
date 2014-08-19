using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CALENDER
{
    class CEventos
    {
        private int _IdEvento;
        private int _IdOrden;
        private DateTime _FechaInicio;
        private DateTime _FechaFin;
        private int _Numero;
        private int _IdTipo;

        public int IdEvento { get { return _IdEvento; } }
        public int IdOrden { get { return _IdOrden; } }
        public DateTime FechaInicio { get { return _FechaInicio; } }
        public DateTime FechaFin { get { return _FechaFin; } }
        public int Numero { get { return _Numero; } }
        public int Tipo { get { return _IdTipo; } }

        public CEventos(int IdOrden,int IdTipoEvento, DateTime FechaInicio, int Numero = 0)
        {
            _IdOrden = IdOrden;
            _IdTipo = IdTipoEvento;
            _FechaInicio = FechaInicio;
            _Numero = Numero;
            _FechaFin = new DateTime(1, 1, 1);  
        }

        public CEventos(int IdEvento)
        {
            DSEventos.DTEventosRow Evento = DSEventos.Evento(IdEvento);
            _IdOrden = Evento.IdOrden;
            _IdTipo = Evento.Tipo;
            _FechaInicio = Evento.FechaInicio;
            try {
                _FechaFin = Evento.FechaFin;
            }
            catch (Exception ex) 
            { _FechaFin = new DateTime(1, 1, 1); } 
            _Numero = Evento.Numero; 
        }

        public bool GuardaInicio()
        {
            CFunciones.Conexion.ElComm.CommandText = "GuardaEvento";  
            if (CFunciones.Conexion.ComienzaTransaccion())
            {
                CFunciones.Conexion.ElComm.Parameters.Clear();
                CFunciones.Conexion.AgregarParametro("@IdOrden", SqlDbType.Int, System.Data.ParameterDirection.Input, IdOrden);
                CFunciones.Conexion.AgregarParametro("@FechaInicio", SqlDbType.DateTime, System.Data.ParameterDirection.Input, DateTime.Now);
                CFunciones.Conexion.AgregarParametro("@Numero", SqlDbType.Int, System.Data.ParameterDirection.Input, Numero);
                CFunciones.Conexion.AgregarParametro("@Tipo", SqlDbType.Int, System.Data.ParameterDirection.Input, (int)_IdTipo);
                CFunciones.Conexion.AgregarParametro("@IdEventoNuevo", SqlDbType.Int, System.Data.ParameterDirection.Output);
                if (CFunciones.Conexion.EjecutaNonQuery() == 1)
                {
                    _IdEvento = (int)CFunciones.Conexion.ElComm.Parameters["@IdEventoNuevo"].Value;    
                    CFunciones.Conexion.TerminaTransaccion(true);
                    CFunciones.Conexion.Desconecta();
                    return true; 
                }                
            }
            CFunciones.Conexion.Desconecta();
            return false; 
        }

        public bool GuardaFin()
        {
            CFunciones.Conexion.ElComm.CommandText = "GuardaEvento";
            if (CFunciones.Conexion.ComienzaTransaccion())
            {
                CFunciones.Conexion.ElComm.Parameters.Clear();
                CFunciones.Conexion.AgregarParametro("@IdEvento", SqlDbType.Int, System.Data.ParameterDirection.Input, _IdEvento);
                CFunciones.Conexion.AgregarParametro("@FechaFin", SqlDbType.DateTime, System.Data.ParameterDirection.Input, DateTime.Now);
                if (CFunciones.Conexion.EjecutaNonQuery() == 1)
                {
                    CFunciones.Conexion.TerminaTransaccion(true);
                    CFunciones.Conexion.Desconecta();
                    return true;
                }
            }
            CFunciones.Conexion.Desconecta();
            return false; 
        }

        public bool Finaliza()
        {
            if (GuardaFin() == false)
                return false;
            _FechaFin = DateTime.Now;  
            return true;
        }

        public TimeSpan TiempoTrascurrrido()
        {
            TimeSpan dif;
            if (FechaFin != null)
                dif = FechaInicio.Subtract(FechaFin);
            else
                dif = FechaInicio.Subtract(FechaInicio);
            return dif;
        }

        //public static bool EventoTiempoPerdio(int IdTipoEvento)
        //{
        //    if (IdTipoEvento < (int)CFunciones.Evento.Tocador || IdTipoEvento > (int)CFunciones.Evento.SetUp)
        //        return false;
        //    else
        //        return true;
        //}

    }
}
