using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace CALENDER
{
    public static class CFunciones
    {
        public static CConexion Conexion;

        public enum AccionMensaje
        {
            Pausar = 1,
            Finalizar = 2,
            Cancelar = 3,
        }

        public enum Evento
        {
            Nada = 0,
            Iniciado = 1,
            Fin = 2,
            C1 = 3,
            C2 = 4,
            D = 5,
            Placas = 6,
            Cortes = 7,
            Tocador = 8,
            Comida = 9,
            Otro = 10,
            SetUp = 11,
        }

        public static string  LeeArchivoDeTexto(string Path)
        {
            string Elementos = null;
            System.IO.StreamReader objReader = default(System.IO.StreamReader);
            if (!System.IO.File.Exists(Path))
                System.IO.File.Create(Path);
            try
            {
                objReader = new System.IO.StreamReader(Path);
                Elementos = objReader.ReadToEnd();
                objReader.Close();
                return Elementos;
            }
            catch (Exception Ex){}
            return Elementos; 
        }

        public static void IniciaConexion()
        {
            string[] ConfigDatosConexion = CFunciones.LeeArchivoDeTexto(System.IO.Directory.GetParent(
                System.Windows.Forms.Application.ExecutablePath).ToString() + "\\config.dat").Split(new char[] { ';' });
            CFunciones.Conexion = new CConexion();
            CFunciones.Conexion.IniciaConexion(ConfigDatosConexion[0], ConfigDatosConexion[1], "Comesque321@");
            //CFunciones.Conexion.IniciaConexion(ConfigDatosConexion[0], ConfigDatosConexion[1], "dev2");
        }

        public static string FomatoCorto(TimeSpan Tiempo)
        {
            string TiempoF = "";
            TiempoF = decimal.Parse(((int)Tiempo.Hours).ToString()).ToString("00") +
                ":" + decimal.Parse(((int)Tiempo.Minutes).ToString()).ToString("00") +
                ":" + decimal.Parse(((int)Tiempo.Seconds).ToString()).ToString("00");
            return TiempoF;
        }


    }
}
