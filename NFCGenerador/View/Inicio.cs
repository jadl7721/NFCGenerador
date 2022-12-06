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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NFCGenerador.View
{
    public partial class Inicio : Form
    {
        private DBConnection DBConn = new DBConnection();
        ComprobanteController comprobanteCtlr = new ComprobanteController();
        TipoComprobanteController tipoComprobanteCtrl = new TipoComprobanteController();
        DetalleComprobanteController detalleComprobanteCtlr = new DetalleComprobanteController();

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            CargarDatos();
            toolStripsDbstatus.Text = DBConn.ConnectToDatabase();
            //Comprobantes comprobante = new Comprobantes(1, 1, 1, 33);
           // comprobanteCtlr.crearComprobante(comprobante);
           
            // addTipocomprobante(dt);
           // Console.WriteLine(comprobanteCtlr.getAllgComprobantes().Rows);
        }

        private void CargarDatos()
        {
            DataTable dt = tipoComprobanteCtrl.getAll();
            addTipocomprobante(dt);
            dt = comprobanteCtlr.getAllgComprobantes();
            addComprobante(dt);

            dt = detalleComprobanteCtlr.getAll();

            addDetalleComprobante(dt);
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)

        {
            DBConn.Disconnect();
        }

        private void DGVDetalleComprobantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addTipocomprobante(DataTable data)
        {
            cbComprobante.Items.Clear();
            cbTipoComprobante.Items.Clear();
            dgvTipo.Rows.Clear();

         

            cbTipoComprobante.DisplayMember = "Text";
            cbTipoComprobante.ValueMember = "Value";
            cbComprobante.DisplayMember = "Text";
            cbComprobante.ValueMember = "Value";



            //(comboBox.SelectedItem as dynamic).Value

            foreach (DataRow item in data.Rows)
            {
                
                 cbTipoComprobante.Items.Add(new { Text = item[1].ToString(), Value = item[0].ToString() });
                cbComprobante.Items.Add(new { Text = item[2].ToString(), Value = item[0].ToString() });
          
                dgvTipo.Rows.Add(item[0], item[1], item[2], item[3]);
            }

        }

        private void addComprobante(DataTable data)
        {
            //DataTable dt = comprobanteCtlr.getAllgComprobantes();
            dgvComprobante.Rows.Clear();
            foreach (DataRow item in data.Rows)
            {
                dgvComprobante.Rows.Add(item[0], item[1], item[2], item[3]);
            }
        }
        private void addDetalleComprobante(DataTable data)
        {
          
            DGVDetalleComprobantes.Rows.Clear();

            foreach (DataRow item in data.Rows)
            {
                DGVDetalleComprobantes.Rows.Add(item[0], item[1], item[2]);
            }

        }

        private void btnAddTipo_Click(object sender, EventArgs e)
        {

            if (tbTipo.Text.Trim() == "" || tbDescipcionTipo.Text.Trim() == "")
            {
                MessageBox.Show("No hay datos que agregar en tipo Comprueba");
                return;
            }
            TipoComprobante tipoC = new TipoComprobante(1, tbTipo.Text.Trim().ToUpper(), tbDescipcionTipo.Text.Trim().ToUpper(), "Activo");
            tipoComprobanteCtrl.crearTipo(tipoC);
            tbTipo.Text = "";
            tbDescipcionTipo.Text = "";

            DataTable dt =  tipoComprobanteCtrl.getAll();
            addTipocomprobante(dt);
        }
        

        private void btnEliminarTipo_Click(object sender, EventArgs e)
        {

            if (dgvTipo.Rows.Count < 1)
            {
                MessageBox.Show("No hay nada para eliminar");
                return;
            }
            int id =  Convert.ToInt16( dgvTipo.CurrentRow.Cells[0].Value);
            //string id = dgvTipo.CurrentRow.Cells[0].Value.ToString();

            tipoComprobanteCtrl.eliminar(id);
            CargarDatos();
        }

        private void btnAddComprobantes_Click(object sender, EventArgs e)
        {

            if (cbTipoComprobante.SelectedItem == null || tbNumeracionFinal.Text.Trim() == "" )
            {
                MessageBox.Show("No hay nada que agregar");
                return;
            }
            MessageBox.Show((cbTipoComprobante.SelectedItem as dynamic).Value);

            Comprobantes comprobantes = new Comprobantes(0, Convert.ToInt32((cbTipoComprobante.SelectedItem as dynamic).Value), 1, Convert.ToInt32(tbNumeracionFinal.Text.Trim()) );


            Console.WriteLine((cbTipoComprobante.SelectedItem as dynamic).Value);  
            comprobanteCtlr.crearComprobante(comprobantes);
            CargarDatos();
        }

        private void btnEliminarComprobante_Click(object sender, EventArgs e)
        {
         
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {


            //  string secuencia = "00000000";

            //  string total = "10991245";
            ////  MessageBox.Show(total.Length.ToString());

            //  secuencia = "B01" +secuencia.Substring(0, (secuencia.Length - total.Length) ) + ""+total+"";

            //  MessageBox.Show(secuencia);



            if (cbComprobante.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un comprobante");
                return;
            }

            DetalleComprobante detalleComprobante = new DetalleComprobante(0, (cbComprobante.SelectedItem as dynamic).Value, "activo");
            detalleComprobanteCtlr.crearDetalle(detalleComprobante);

            CargarDatos();

        }
    }

}
