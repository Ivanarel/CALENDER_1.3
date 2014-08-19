using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CALENDER
{
    public class CConexion
    {
        private SqlConnection _LaConn;
        private SqlCommand _ElComm;
        private SqlDataReader _ElDr;
        private SqlTransaction _Trans;
        private string ConexionString;

#region Acceso Propiedades

        public SqlConnection LaConn
        {
            get { return _LaConn; }
            set { _LaConn = value; }
        }
        public SqlCommand ElComm
        {
            get { return _ElComm; }
            set { _ElComm = value; }
        }
        public SqlDataReader ElDr
        {
            get { return _ElDr; }
            set { _ElDr = value; }
        }
        public SqlTransaction Trans
        {
            get { return _Trans; }
            set { _Trans = value; }
        }

#endregion

        public bool IniciaConexion(string IPServidor, string Usuario, string Password)
        {
            //ConexionString = "Data Source=" + IPServidor + ";Initial Catalog=CALENDER;User ID=" + Usuario +
            ConexionString = "Data Source=" + IPServidor + ";Initial Catalog=maosoftprogram;User ID=" + Usuario +
                ";Password=" + Password + ";Connection Timeout=5";
            LaConn = new SqlConnection(ConexionString);
            ElComm = new SqlCommand();
            ElComm.CommandType = CommandType.StoredProcedure;
            ElComm.Connection = _LaConn;
            try {LaConn.Open();}
            catch (Exception exc) {
                MessageBox.Show("Error en la conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                return false; 
            }
            return true; 
        }

        public void AgregarParametro(string NombreDelParametro, SqlDbType TipoDeDato, 
            ParameterDirection Direccion, object Valor = null)
        {
            SqlParameter NuevoParametro = new SqlParameter();
            NuevoParametro.ParameterName = NombreDelParametro;
            NuevoParametro.Direction = Direccion;
            NuevoParametro.SqlDbType = TipoDeDato;
            if ((Valor != null))
                NuevoParametro.Value = Valor;
            ElComm.Parameters.Add(NuevoParametro);
        }

        public bool Conecta()
        {
            try
            {
                if (LaConn.State != ConnectionState.Open)
                    LaConn.Open();
                return true;
            }
            catch (Exception ex) {return false; }                
        }

        public bool Conectado()
        {
            try
            {
                if (LaConn.State == ConnectionState.Open)
                    return true;
                else
                    return false;
            }
            catch (Exception ex) {return false; }                
        }

        public bool EjecutaReader()
        {
            try
            {
                if (!Conecta())
                    return false;
                if ((ElDr != null))
                {
                    if (!ElDr.IsClosed)
                        ElDr.Close();
                }
                ElDr = _ElComm.ExecuteReader();
                return true;
            }
            catch (Exception ex){return false;}
        }

        public int EjecutaNonQuery()
        {
            try
            {
                if (!Conecta())
                    return -1;
                return _ElComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public bool ComienzaTransaccion()
        {
            try
            {
                if (!Conecta())
                    return false;
                _Trans = _LaConn.BeginTransaction();
                ElComm.Transaction = Trans;
                return true;
            }
            catch (Exception ex){return false; }
        }

        public void TerminaTransaccion(bool AceptaLosCambios)
        {
            try
            {
                if (AceptaLosCambios)
                    Trans.Commit();
                else
                    Trans.Rollback();
            }
            catch (Exception ex){}
            Trans = null;
            ElComm.Transaction = null;
        }

        public void Desconecta()
        {
            if ((ElDr != null))
            {
                if (!ElDr.IsClosed)
                    ElDr.Close();
            }
            ElComm.Parameters.Clear();
            LaConn.Close();
        }

        public void ErrorDeConexion()
        {
            MessageBox.Show("Error en la conexión." + " Vuelva a intentar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

    }
}
