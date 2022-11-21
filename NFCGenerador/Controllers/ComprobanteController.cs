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
                string strCommand = "SELECT * FROM comprobantes";
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

        public void crearComprobante(Comprobantes comprobante)
        {
            try
            {
              //  string strCommand = "insert * FROM comprobantes";
                String query = "INSERT INTO comprobantes (tipoid,numeracionactual,numeracionfinal) VALUES (@tipoid,@numeracionactual,@numeracionfinal)";

                SqlCommand command = new SqlCommand(query, conn);
                //command.Parameters.Add("@id", comprobante.id);
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
