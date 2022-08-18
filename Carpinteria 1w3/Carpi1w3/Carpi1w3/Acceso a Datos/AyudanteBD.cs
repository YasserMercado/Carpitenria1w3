using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Carpi1w3.Acceso_a_Datos
{
    internal class AyudanteBD
    {
        private SqlConnection cnn;
        public AyudanteBD()
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = Properties.Resources.CadenaConexion;
        }
        public DataTable EjecutarSPConsulta(string nombreSP)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
    }
}
