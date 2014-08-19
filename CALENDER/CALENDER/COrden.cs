using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CALENDER
{
    class COrden
    {
        private int _IdOrden;
        private string _Nombre;
        private bool _Pendiente;
        private List<CEventos> Eventos;
        private CEventos _Evento;
        private DateTime _FechaInicio;
        private DSTipoEventos.DTTipoEventosDataTable DTTiposEventos;
        private TimeSpan _TiempoTotal;

        public int IdOrden { get { return _IdOrden; } }
        public string Nombre { get { return _Nombre; } }
        public bool Pendiente { get { return _Pendiente; } set { _Pendiente = value; } }
        public CEventos Evento { get { return _Evento; }}
        public DateTime FechaInicio { get { return _FechaInicio; } }
        public CEventos EventoIndex(int Index)
        {
            try { return Eventos[Index]; }
            catch (Exception exc) { return null; }             
        }
        public TimeSpan TiempoTotal { get { return _TiempoTotal; } }
        public int CountEventos() { return Eventos.Count; }

        public COrden(string Nombre)
        {
            DTTiposEventos = DSTipoEventos.Listado();
            _Nombre = Nombre;
            Pendiente = false;
            Eventos = new List<CEventos>();            
        }

        public COrden(int IdOrden)
        {
            DTTiposEventos = DSTipoEventos.Listado();
            DsOrdenes.DtOrdenesRow DROrden = DsOrdenes.Orden(IdOrden);   
            _IdOrden = DROrden.IdOrden; 
            _Nombre = DROrden.Nombre;
            Pendiente = DROrden.Pendiente;
            Eventos = new List<CEventos>();
            RecuperaEventos();
            _Evento = Eventos[Eventos.Count - 1];
        }

        private void RecuperaEventos()
        {
            DSEventos.DTEventosDataTable DTEventos;
            DTEventos = DSEventos.ListadoEventos(IdOrden);
            foreach (DSEventos.DTEventosRow DREvento in DTEventos)
                Eventos.Add(new CEventos(DREvento.IdEvento));
            CalculaTiempoTranscurrido();
            RecuperaFechaInicio();
        }

        private void RecuperaFechaInicio()
        {
            _FechaInicio = Eventos[0].FechaInicio;
        }

        public bool ComienzaNuevoEvento(int IdTipoEvento,int Numero = 0)
        {
            if (_Evento != null && _Evento.FechaFin.Year == 1 )
                if (_Evento.Finaliza() == false) return false; 
            _Evento = new CEventos(IdOrden,IdTipoEvento, DateTime.Now,Numero);
            if (_Evento.GuardaInicio() == false )return false;
            Eventos.Add(_Evento);
            CalculaTiempoTranscurrido();
            return true; 
        }

        public void Pausa()
        {
            _Evento.Finaliza();
            _Evento = null;
        }

        public void Finaliza()
        {
            if (_Evento != null)
                _Evento.Finaliza();
        }

        public bool IniciaOrden()
        {
            _IdOrden = GuardaOrden(); 
            if (IdOrden != 0)
            {
                ComienzaNuevoEvento((int)CFunciones.Evento.Iniciado);
                _FechaInicio = Eventos[0].FechaInicio;  
                if (_Evento == null) return false;                
                Pendiente = false; 
            }
            return true; 
        }

        /// <summary>
        /// Guarda una nueva orden o actualiza una existente
        /// </summary>
        /// <returns>-1 : Error al guardar, <>-1 regresa el Id de la Orden si es nueva</returns>
        private int GuardaOrden()
        {
            int res = -1; 
            CFunciones.Conexion.ElComm.CommandText = "GuardaOrden";
            if (CFunciones.Conexion.ComienzaTransaccion())
            {
                CFunciones.Conexion.ElComm.Parameters.Clear();
                CFunciones.Conexion.AgregarParametro("@IdOrden", SqlDbType.Int, System.Data.ParameterDirection.Input, IdOrden);
                CFunciones.Conexion.AgregarParametro("@Nombre", SqlDbType.VarChar, System.Data.ParameterDirection.Input, Nombre);
                CFunciones.Conexion.AgregarParametro("@Pendiente", SqlDbType.Bit, System.Data.ParameterDirection.Input, Pendiente);
                CFunciones.Conexion.AgregarParametro("@IdOrdenNuevo", SqlDbType.Int, System.Data.ParameterDirection.Output);
                res = CFunciones.Conexion.EjecutaNonQuery();
                if (res == 1)
                {
                    res = (int)CFunciones.Conexion.ElComm.Parameters["@IdOrdenNuevo"].Value;
                    CFunciones.Conexion.TerminaTransaccion(true);
                    CFunciones.Conexion.Desconecta();
                }
            }
            CFunciones.Conexion.Desconecta();
            return res;
        }

        public DateTime FechaFin()
        {
            CEventos EventoAux;
            DateTime Fecha = new DateTime();
            if (Eventos.Count > 0)
            {
                EventoAux = Eventos[Eventos.Count - 1];
                if(EventoAux.Tipo == (int)CFunciones.Evento.Fin)
                    Fecha = EventoAux.FechaFin;
            }
                
            return Fecha; 
        }

        public bool Terminada()
        {
            try
            {
                if (Evento.Tipo == (int)CFunciones.Evento.Fin)
                    return true;
            }
            catch (Exception exc) { }
            return false; 
        }

        private void CalculaTiempoTranscurrido()
        {
            TimeSpan TiempoTrasnAux = new TimeSpan(0,0,0);
            foreach (CEventos Ev in Eventos)
            {
                if (Ev.FechaFin.Year != 1 && Ev.Tipo != (int)CFunciones.Evento.Iniciado &&
                    TiempoPerdido(Ev.Tipo) == false)
                    TiempoTrasnAux = TiempoTrasnAux.Add(Ev.FechaFin.Subtract(Ev.FechaInicio));;
            }
            _TiempoTotal = TiempoTrasnAux;
        }

        private bool TiempoPerdido(int IdTipoEvento)
        {
            bool band = false;
            if (IdTipoEvento < (int)CFunciones.Evento.SetUp && IdTipoEvento >= (int)CFunciones.Evento.Tocador)
                band = true;
            else
            {
                try
                { band = (bool)DTTiposEventos.Select("IdTipoEvento = " + IdTipoEvento.ToString())[0]["Tipo"]; }
                catch (Exception exc) { }
            }
            return band;
        }

    }
}
