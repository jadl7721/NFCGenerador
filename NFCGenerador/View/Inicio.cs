using NFCGenerador.Class;
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
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            toolStripsDbstatus.Text = DBConn.ConnectToDatabase();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
