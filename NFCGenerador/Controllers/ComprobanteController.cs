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
    internal class ComprobanteController
    {
        SqlConnection conn = DBConnection.conn;

       
        public DataTable getAllgComprobantes()
        {
            try
            {
                string strCommand = "SELECT c.Id, tipo, numeracionactual, numeracionfinal FROM comprobantes c INNER JOIN tipocomprobante t ON c.tipoid = t.Id";
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

        public DataTable existeComprobante(int? id)
        {
            try
            {
                string strCommand = "SELECT * FROM comprobantes where tipoid = " + id.ToString();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strCommand, conn);
                da.Fill(dt);

                if (dt.Rows.Count <1 || dt ==null)
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

        public void crearComprobante(Comprobantes comprobante)
        {
            try
            {
                string query;
                SqlCommand command;
                DataTable dt = existeComprobante(comprobante.tipoid);
                if (dt != null) 
                {
                    query = @"UPDATE comprobantes set [numeracionfinal] = @numeracionfinal WHERE [Id] = @id " ;
                    command = new SqlCommand(query, conn);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = dt.Rows[0].ItemArray[0];
                    command.Parameters.Add("@numeracionfinal", SqlDbType.Int).Value = comprobante.numeracionfinal;
                    command.ExecuteNonQuery();
                    return;

                }
                query = "INSERT INTO comprobantes (tipoid,numeracionactual,numeracionfinal) " +
                    "VALUES (@tipoid,@numeracionactual,@numeracionfinal)";

                command = new SqlCommand(query, conn);
                //command.CommandText = 
               // command.Parameters.Add("@id", comprobante.id);
                command.Parameters.Add("@tipoid", SqlDbType.Int).Value = comprobante.tipoid;
                command.Parameters.Add("@numeracionactual", SqlDbType.Int).Value = comprobante.numeracionactual;
                command.Parameters.Add("@numeracionfinal", SqlDbType.Int).Value = comprobante.numeracionfinal;

                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
               
                
            }
        }

    }
}
