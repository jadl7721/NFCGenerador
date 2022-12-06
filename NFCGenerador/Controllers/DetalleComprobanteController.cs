using Microsoft.Data.SqlClient;
using NFCGenerador.Class;
using NFCGenerador.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFCGenerador.Controllers
{
    internal class DetalleComprobanteController
    {
        SqlConnection conn = DBConnection.conn;
        public DataTable getAll()
        {
            try
            {
                string strCommand = "SELECT * FROM detallecomprobante";
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

        private DataTable Comprobantes(int tipoId)
        {
            try
            {
                string strCommand = "SELECT c.Id, tipo, numeracionactual, numeracionfinal FROM comprobantes c INNER JOIN tipocomprobante t ON c.tipoid = t.Id where c.tipoid = " + tipoId.ToString();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strCommand, conn);

                if (da == null)
                {
                    return null;
                }
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }

        public string crearDetalle(DetalleComprobante detalleComprobante)
        {


            try
            {
                DataTable dt = Comprobantes(Convert.ToInt16(detalleComprobante.comprobante));

                if (dt == null )
                {
                    MessageBox.Show("Error al generar comprobante");
                    return "";
                }

                string secuencia = "00000000";
                string numeracionActual =dt.Rows[0].ItemArray[2].ToString();
                string numeracionFinal = dt.Rows[0].ItemArray[3].ToString();
                string tipo = dt.Rows[0].ItemArray[1].ToString();
                string comprobante = ""+ tipo + secuencia.Substring(0, (secuencia.Length - numeracionActual.Length)) + "" + numeracionActual + "";


                string tipoComprobante = "" + dt.Rows[0].ItemArray[1];
                string query = "INSERT INTO detallecomprobante (comprobante,estado) " +
                    "VALUES (@comprobante,@estado)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@comprobante", SqlDbType.VarChar).Value = comprobante;
                command.Parameters.Add("@estado", SqlDbType.VarChar).Value = detalleComprobante.estado;

                command.ExecuteNonQuery();

                return "ok";
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "error";

            }
        }
        public string eliminar(int id)
        {
            try
            {
                String query = "DELETE FROM detallecomprobante WHERE id =" + id.ToString();

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
