namespace NFCGenerador.View
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVDetalleComprobantes = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComprobanteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripsDbstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddTipo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescipcionTipo = new System.Windows.Forms.TextBox();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.idtipocomprobanteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoComprobanteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciontipocomprobanteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoTipoComprobanteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarTipo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddComprobantes = new System.Windows.Forms.Button();
            this.tbNumeracionFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvComprobante = new System.Windows.Forms.DataGridView();
            this.idComprobanteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeracionActualC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeracionFinalC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnEliminarComprobante = new System.Windows.Forms.Button();
            this.btnGenerarComprobante = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbComprobante = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalleComprobantes)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.DGVDetalleComprobantes);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comprobantes Generados";
            // 
            // DGVDetalleComprobantes
            // 
            this.DGVDetalleComprobantes.AllowUserToAddRows = false;
            this.DGVDetalleComprobantes.AllowUserToDeleteRows = false;
            this.DGVDetalleComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalleComprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.ComprobanteColumn,
            this.estadoColumn});
            this.DGVDetalleComprobantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDetalleComprobantes.Location = new System.Drawing.Point(3, 19);
            this.DGVDetalleComprobantes.Name = "DGVDetalleComprobantes";
            this.DGVDetalleComprobantes.ReadOnly = true;
            this.DGVDetalleComprobantes.RowHeadersVisible = false;
            this.DGVDetalleComprobantes.RowTemplate.Height = 25;
            this.DGVDetalleComprobantes.Size = new System.Drawing.Size(582, 456);
            this.DGVDetalleComprobantes.TabIndex = 0;
            this.DGVDetalleComprobantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetalleComprobantes_CellClick);
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idColumn.FillWeight = 15.22842F;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // ComprobanteColumn
            // 
            this.ComprobanteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComprobanteColumn.FillWeight = 205.6885F;
            this.ComprobanteColumn.HeaderText = "Comprobante";
            this.ComprobanteColumn.Name = "ComprobanteColumn";
            this.ComprobanteColumn.ReadOnly = true;
            // 
            // estadoColumn
            // 
            this.estadoColumn.FillWeight = 79.08304F;
            this.estadoColumn.HeaderText = "Estado";
            this.estadoColumn.Name = "estadoColumn";
            this.estadoColumn.ReadOnly = true;
            this.estadoColumn.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "NFC Generador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sistema básico de generación de comprobantes fiscales.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripsDbstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1174, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "Status DB: ";
            // 
            // toolStripsDbstatus
            // 
            this.toolStripsDbstatus.Name = "toolStripsDbstatus";
            this.toolStripsDbstatus.Size = new System.Drawing.Size(116, 17);
            this.toolStripsDbstatus.Text = "Coneted/no conecte";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddTipo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbDescipcionTipo);
            this.groupBox3.Controls.Add(this.tbTipo);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(603, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 228);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Comprobante";
            // 
            // btnAddTipo
            // 
            this.btnAddTipo.Location = new System.Drawing.Point(424, 37);
            this.btnAddTipo.Name = "btnAddTipo";
            this.btnAddTipo.Size = new System.Drawing.Size(129, 23);
            this.btnAddTipo.TabIndex = 0;
            this.btnAddTipo.Text = "Add tipo";
            this.btnAddTipo.UseVisualStyleBackColor = true;
            this.btnAddTipo.Click += new System.EventHandler(this.btnAddTipo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(108, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // tbDescipcionTipo
            // 
            this.tbDescipcionTipo.Location = new System.Drawing.Point(108, 37);
            this.tbDescipcionTipo.Name = "tbDescipcionTipo";
            this.tbDescipcionTipo.Size = new System.Drawing.Size(307, 23);
            this.tbDescipcionTipo.TabIndex = 1;
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(21, 37);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(81, 23);
            this.tbTipo.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvTipo);
            this.groupBox5.Location = new System.Drawing.Point(6, 64);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(412, 158);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos";
            // 
            // dgvTipo
            // 
            this.dgvTipo.AllowUserToAddRows = false;
            this.dgvTipo.AllowUserToDeleteRows = false;
            this.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtipocomprobanteC,
            this.tipoComprobanteC,
            this.descripciontipocomprobanteC,
            this.estadoTipoComprobanteC});
            this.dgvTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipo.Location = new System.Drawing.Point(3, 19);
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.ReadOnly = true;
            this.dgvTipo.RowHeadersVisible = false;
            this.dgvTipo.RowTemplate.Height = 25;
            this.dgvTipo.Size = new System.Drawing.Size(406, 136);
            this.dgvTipo.TabIndex = 0;
            // 
            // idtipocomprobanteC
            // 
            this.idtipocomprobanteC.HeaderText = "Id";
            this.idtipocomprobanteC.Name = "idtipocomprobanteC";
            this.idtipocomprobanteC.ReadOnly = true;
            this.idtipocomprobanteC.Width = 25;
            // 
            // tipoComprobanteC
            // 
            this.tipoComprobanteC.HeaderText = "Tipo";
            this.tipoComprobanteC.Name = "tipoComprobanteC";
            this.tipoComprobanteC.ReadOnly = true;
            this.tipoComprobanteC.Width = 65;
            // 
            // descripciontipocomprobanteC
            // 
            this.descripciontipocomprobanteC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripciontipocomprobanteC.HeaderText = "Descripción";
            this.descripciontipocomprobanteC.Name = "descripciontipocomprobanteC";
            this.descripciontipocomprobanteC.ReadOnly = true;
            // 
            // estadoTipoComprobanteC
            // 
            this.estadoTipoComprobanteC.HeaderText = "Estado";
            this.estadoTipoComprobanteC.Name = "estadoTipoComprobanteC";
            this.estadoTipoComprobanteC.ReadOnly = true;
            this.estadoTipoComprobanteC.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarTipo);
            this.groupBox2.Location = new System.Drawing.Point(424, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 158);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnEliminarTipo
            // 
            this.btnEliminarTipo.Location = new System.Drawing.Point(6, 22);
            this.btnEliminarTipo.Name = "btnEliminarTipo";
            this.btnEliminarTipo.Size = new System.Drawing.Size(117, 23);
            this.btnEliminarTipo.TabIndex = 0;
            this.btnEliminarTipo.Text = "Eliminar";
            this.btnEliminarTipo.UseVisualStyleBackColor = true;
            this.btnEliminarTipo.Click += new System.EventHandler(this.btnEliminarTipo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnAddComprobantes);
            this.groupBox4.Controls.Add(this.tbNumeracionFinal);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbTipoComprobante);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Location = new System.Drawing.Point(603, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 241);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comprobantes disponibles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(133, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Numeración Final";
            // 
            // btnAddComprobantes
            // 
            this.btnAddComprobantes.Location = new System.Drawing.Point(424, 38);
            this.btnAddComprobantes.Name = "btnAddComprobantes";
            this.btnAddComprobantes.Size = new System.Drawing.Size(129, 23);
            this.btnAddComprobantes.TabIndex = 3;
            this.btnAddComprobantes.Text = "Add comprobantes";
            this.btnAddComprobantes.UseVisualStyleBackColor = true;
            this.btnAddComprobantes.Click += new System.EventHandler(this.btnAddComprobantes_Click);
            // 
            // tbNumeracionFinal
            // 
            this.tbNumeracionFinal.Location = new System.Drawing.Point(133, 39);
            this.tbNumeracionFinal.Name = "tbNumeracionFinal";
            this.tbNumeracionFinal.Size = new System.Drawing.Size(282, 23);
            this.tbNumeracionFinal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo";
            // 
            // cbTipoComprobante
            // 
            this.cbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoComprobante.FormattingEnabled = true;
            this.cbTipoComprobante.Location = new System.Drawing.Point(15, 39);
            this.cbTipoComprobante.Name = "cbTipoComprobante";
            this.cbTipoComprobante.Size = new System.Drawing.Size(112, 23);
            this.cbTipoComprobante.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvComprobante);
            this.groupBox6.Location = new System.Drawing.Point(6, 68);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(412, 167);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datos";
            // 
            // dgvComprobante
            // 
            this.dgvComprobante.AllowUserToAddRows = false;
            this.dgvComprobante.AllowUserToDeleteRows = false;
            this.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComprobanteC,
            this.dataGridViewTextBoxColumn1,
            this.numeracionActualC,
            this.numeracionFinalC});
            this.dgvComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComprobante.Location = new System.Drawing.Point(3, 19);
            this.dgvComprobante.Name = "dgvComprobante";
            this.dgvComprobante.ReadOnly = true;
            this.dgvComprobante.RowHeadersVisible = false;
            this.dgvComprobante.RowTemplate.Height = 25;
            this.dgvComprobante.Size = new System.Drawing.Size(406, 145);
            this.dgvComprobante.TabIndex = 0;
            // 
            // idComprobanteC
            // 
            this.idComprobanteC.HeaderText = "Id";
            this.idComprobanteC.Name = "idComprobanteC";
            this.idComprobanteC.ReadOnly = true;
            this.idComprobanteC.Width = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numeracionActualC
            // 
            this.numeracionActualC.HeaderText = "No Actual";
            this.numeracionActualC.Name = "numeracionActualC";
            this.numeracionActualC.ReadOnly = true;
            // 
            // numeracionFinalC
            // 
            this.numeracionFinalC.HeaderText = "No. Final";
            this.numeracionFinalC.Name = "numeracionFinalC";
            this.numeracionFinalC.ReadOnly = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnEliminarComprobante);
            this.groupBox7.Location = new System.Drawing.Point(424, 68);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(129, 161);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Opciones";
            // 
            // btnEliminarComprobante
            // 
            this.btnEliminarComprobante.Enabled = false;
            this.btnEliminarComprobante.Location = new System.Drawing.Point(6, 22);
            this.btnEliminarComprobante.Name = "btnEliminarComprobante";
            this.btnEliminarComprobante.Size = new System.Drawing.Size(117, 23);
            this.btnEliminarComprobante.TabIndex = 0;
            this.btnEliminarComprobante.Text = "Eliminar";
            this.btnEliminarComprobante.UseVisualStyleBackColor = true;
            this.btnEliminarComprobante.Click += new System.EventHandler(this.btnEliminarComprobante_Click);
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarComprobante.Location = new System.Drawing.Point(1027, 12);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(135, 92);
            this.btnGenerarComprobante.TabIndex = 5;
            this.btnGenerarComprobante.Text = "Generar Comprobante ";
            this.btnGenerarComprobante.UseVisualStyleBackColor = true;
            this.btnGenerarComprobante.Click += new System.EventHandler(this.btnGenerarComprobante_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(830, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comprobante a generar";
            // 
            // cbComprobante
            // 
            this.cbComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComprobante.FormattingEnabled = true;
            this.cbComprobante.Location = new System.Drawing.Point(830, 81);
            this.cbComprobante.Name = "cbComprobante";
            this.cbComprobante.Size = new System.Drawing.Size(188, 23);
            this.cbComprobante.TabIndex = 6;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 613);
            this.Controls.Add(this.cbComprobante);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1190, 652);
            this.MinimumSize = new System.Drawing.Size(1190, 652);
            this.Name = "Inicio";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalleComprobantes)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView DGVDetalleComprobantes;
        private Label label2;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn ComprobanteColumn;
        private DataGridViewTextBoxColumn estadoColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripsDbstatus;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Button btnGenerarComprobante;
        private Button btnAddTipo;
        private Label label4;
        private Label label3;
        private TextBox tbDescipcionTipo;
        private TextBox tbTipo;
        private DataGridView dgvTipo;
        private Button btnEliminarTipo;
        private Label label7;
        private Button btnAddComprobantes;
        private TextBox tbNumeracionFinal;
        private Label label6;
        private ComboBox cbTipoComprobante;
        private DataGridView dgvComprobante;
        private Button btnEliminarComprobante;
        private Label label5;
        private ComboBox cbComprobante;
        private DataGridViewTextBoxColumn idtipocomprobanteC;
        private DataGridViewTextBoxColumn tipoComprobanteC;
        private DataGridViewTextBoxColumn descripciontipocomprobanteC;
        private DataGridViewTextBoxColumn estadoTipoComprobanteC;
        private DataGridViewTextBoxColumn idComprobanteC;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn numeracionActualC;
        private DataGridViewTextBoxColumn numeracionFinalC;
    }
}