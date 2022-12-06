using Microsoft.Data.SqlClient;
using NFCGenerador.Class;
using NFCGenerador.Models;
using System.Data;

namespace NFCGenerador.Controllers
{
    internal class TipoComprobanteController
    {
        SqlConnection conn = DBConnection.conn;
        public DataTable getAll()
        {
            try
            {
                string strCommand = "SELECT * FROM tipocomprobante";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strCommand, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }

        public string crearTipo(TipoComprobante tipoComprobante)
        {
            try
            {

                DataTable dt = existeTipoComprobante(tipoComprobante.tipo);
                if (dt != null)
                {
                   
                    MessageBox.Show("Ya existe este tipo de comprobante " + tipoComprobante.tipo);
                    return "";

                }

                String query = "INSERT INTO tipocomprobante (tipo,descripcion,estado) " +
                    "VALUES (@tipo,@descripcion,@estado)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipoComprobante.tipo;
                command.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = tipoComprobante.descripcion;
                command.Parameters.Add("@estado", SqlDbType.VarChar).Value = tipoComprobante.estado;

                command.ExecuteNonQuery();

                return "ok";
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "error";

            }
        }

        private DataTable existeTipoComprobante(string? tipo)
        {
            try
            {
                string strCommand = @"SELECT * FROM tipocomprobante where tipo LIKE '" + tipo.ToString()+"'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strCommand, conn);
                da.Fill(dt);

                if (dt.Rows.Count < 1 || dt == null)
                {
                    return null;
                }
                return dt;

            }
            catch (Exception)
            {
                return null;

            }
        }

        public string eliminar (int id)
        {
            try
            {
                String query = "DELETE FROM tipocomprobante WHERE id ="+ id.ToString();

                SqlCommand command = new SqlCommand(query, conn);

                command.ExecuteNonQuery();

                return "ok";
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "error";

            }
        }
    }
}
