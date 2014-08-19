using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CALENDER
{
    class CTipoEvento
    {
        private int _IdEvento;
        private string _Nombre;
        private bool _Tipo;

        public int IdEvento{get { return _IdEvento; } }
        public string Nombre { get { return _Nombre; } }
        public bool Tipo { get { return _Tipo; } }

        public CTipoEvento(string Nombre,bool TiempoPerdido,int IdEvento = 0)
        {
            _IdEvento = IdEvento;
            _Nombre = Nombre;
            _Tipo = !TiempoPerdido;
        }

        public bool Guarda()
        {
            CFunciones.Conexion.ElComm.CommandText = "GuardaTipoEvento";
            if (CFunciones.Conexion.ComienzaTransaccion())
            {
                CFunciones.Conexion.ElComm.Parameters.Clear();
                CFunciones.Conexion.AgregarParametro("@Nombre", SqlDbType.VarChar, System.Data.ParameterDirection.Input, _Nombre);
                CFunciones.Conexion.AgregarParametro("@Tipo", SqlDbType.Bit, System.Data.ParameterDirection.Input, _Tipo);
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

    }
}
