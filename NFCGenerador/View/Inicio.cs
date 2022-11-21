using NFCGenerador.Class;
using NFCGenerador.Controllers;
using NFCGenerador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFCGenerador.View
{
    public partial class Inicio : Form
    {
        private DBConnection DBConn = new DBConnection();
        ComprobanteController comprobanteCtlr = new ComprobanteController();

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            toolStripsDbstatus.Text = DBConn.ConnectToDatabase();
            Comprobantes comprobante = new Comprobantes(1, 1,1,33);
            comprobanteCtlr.crearComprobante(comprobante);
            DataTable dt = comprobanteCtlr.getAllgComprobantes();

            foreach (DataRow item in dt.Rows)
            {
                DGVDetalleComprobantes.Rows.Add(item[0], item[1], item[2]);
            }

            Console.WriteLine( comprobanteCtlr.getAllgComprobantes().Rows);
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)

        {
            DBConn.Disconnect();
        }

        private void DGVDetalleComprobantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
