
namespace Inventario_Farmacia
{
    partial class Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_totalPago = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_compraProductos = new System.Windows.Forms.DataGridView();
            this.txt_ISV = new System.Windows.Forms.TextBox();
            this.gb_ag = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_subTotal = new System.Windows.Forms.TextBox();
            this.gb_medi = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_medicamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_concentracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tipoMedicamento = new System.Windows.Forms.TextBox();
            this.btn_medicamento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IDmedicamento = new System.Windows.Forms.TextBox();
            this.gb_prov = new System.Windows.Forms.GroupBox();
            this.btn_proveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idProveedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.txt_fechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ncompra = new System.Windows.Forms.TextBox();
            this.txt_tipoPago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compraProductos)).BeginInit();
            this.gb_ag.SuspendLayout();
            this.gb_medi.SuspendLayout();
            this.gb_prov.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Location = new System.Drawing.Point(1247, 276);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(213, 80);
            this.btn_nuevo.TabIndex = 118;
            this.btn_nuevo.Text = "Nueva Compra";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(1247, 383);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(213, 80);
            this.btn_guardar.TabIndex = 106;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(946, 863);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 30);
            this.label16.TabIndex = 116;
            this.label16.Text = "Forma de Pago";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(658, 862);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 30);
            this.label15.TabIndex = 114;
            this.label15.Text = "Total";
            // 
            // txt_totalPago
            // 
            this.txt_totalPago.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPago.Location = new System.Drawing.Point(729, 860);
            this.txt_totalPago.Name = "txt_totalPago";
            this.txt_totalPago.ReadOnly = true;
            this.txt_totalPago.Size = new System.Drawing.Size(186, 36);
            this.txt_totalPago.TabIndex = 113;
            this.txt_totalPago.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(376, 860);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 30);
            this.label13.TabIndex = 112;
            this.label13.Text = "I.S.V";
            // 
            // dgv_compraProductos
            // 
            this.dgv_compraProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_compraProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_compraProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_compraProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_compraProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_compraProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_compraProductos.Location = new System.Drawing.Point(38, 581);
            this.dgv_compraProductos.Name = "dgv_compraProductos";
            this.dgv_compraProductos.ReadOnly = true;
            this.dgv_compraProductos.RowHeadersVisible = false;
            this.dgv_compraProductos.RowHeadersWidth = 51;
            this.dgv_compraProductos.RowTemplate.Height = 24;
            this.dgv_compraProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_compraProductos.Size = new System.Drawing.Size(1146, 252);
            this.dgv_compraProductos.TabIndex = 110;
            this.dgv_compraProductos.Click += new System.EventHandler(this.dgv_compraProductos_Click);
            // 
            // txt_ISV
            // 
            this.txt_ISV.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ISV.Location = new System.Drawing.Point(447, 860);
            this.txt_ISV.Name = "txt_ISV";
            this.txt_ISV.Size = new System.Drawing.Size(186, 36);
            this.txt_ISV.TabIndex = 111;
            this.txt_ISV.Text = "0";
            this.txt_ISV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ISV_KeyPress);
            // 
            // gb_ag
            // 
            this.gb_ag.Controls.Add(this.btn_eliminar);
            this.gb_ag.Controls.Add(this.btn_agregar);
            this.gb_ag.Controls.Add(this.label12);
            this.gb_ag.Controls.Add(this.txt_importe);
            this.gb_ag.Controls.Add(this.label11);
            this.gb_ag.Controls.Add(this.txt_cantidad);
            this.gb_ag.Location = new System.Drawing.Point(36, 469);
            this.gb_ag.Name = "gb_ag";
            this.gb_ag.Size = new System.Drawing.Size(994, 104);
            this.gb_ag.TabIndex = 108;
            this.gb_ag.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(829, 25);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(129, 54);
            this.btn_eliminar.TabIndex = 88;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(669, 25);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(133, 54);
            this.btn_agregar.TabIndex = 86;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(358, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 30);
            this.label12.TabIndex = 85;
            this.label12.Text = "Total";
            // 
            // txt_importe
            // 
            this.txt_importe.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe.Location = new System.Drawing.Point(443, 37);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.ReadOnly = true;
            this.txt_importe.Size = new System.Drawing.Size(186, 36);
            this.txt_importe.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(29, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 30);
            this.label11.TabIndex = 83;
            this.label11.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(161, 34);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(170, 36);
            this.txt_cantidad.TabIndex = 82;
            this.txt_cantidad.Text = "0";
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(47, 860);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 30);
            this.label14.TabIndex = 109;
            this.label14.Text = "Sub Total";
            // 
            // btn_salir
            // 
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(1247, 498);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(213, 80);
            this.btn_salir.TabIndex = 105;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_subTotal
            // 
            this.txt_subTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subTotal.Location = new System.Drawing.Point(179, 859);
            this.txt_subTotal.Name = "txt_subTotal";
            this.txt_subTotal.ReadOnly = true;
            this.txt_subTotal.Size = new System.Drawing.Size(170, 36);
            this.txt_subTotal.TabIndex = 107;
            this.txt_subTotal.Text = "0";
            // 
            // gb_medi
            // 
            this.gb_medi.Controls.Add(this.label10);
            this.gb_medi.Controls.Add(this.txt_costo);
            this.gb_medi.Controls.Add(this.label8);
            this.gb_medi.Controls.Add(this.txt_stock);
            this.gb_medi.Controls.Add(this.label7);
            this.gb_medi.Controls.Add(this.txt_medicamento);
            this.gb_medi.Controls.Add(this.label5);
            this.gb_medi.Controls.Add(this.txt_concentracion);
            this.gb_medi.Controls.Add(this.label4);
            this.gb_medi.Controls.Add(this.txt_tipoMedicamento);
            this.gb_medi.Controls.Add(this.btn_medicamento);
            this.gb_medi.Controls.Add(this.label3);
            this.gb_medi.Controls.Add(this.txt_IDmedicamento);
            this.gb_medi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_medi.ForeColor = System.Drawing.Color.White;
            this.gb_medi.Location = new System.Drawing.Point(36, 189);
            this.gb_medi.Name = "gb_medi";
            this.gb_medi.Size = new System.Drawing.Size(994, 274);
            this.gb_medi.TabIndex = 104;
            this.gb_medi.TabStop = false;
            this.gb_medi.Text = "Datos del Medicamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(728, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 30);
            this.label10.TabIndex = 80;
            this.label10.Text = "Costo c/u";
            // 
            // txt_costo
            // 
            this.txt_costo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo.Location = new System.Drawing.Point(733, 198);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.ReadOnly = true;
            this.txt_costo.Size = new System.Drawing.Size(238, 36);
            this.txt_costo.TabIndex = 79;
            this.txt_costo.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(459, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 78;
            this.label8.Text = "Stock";
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(464, 198);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(238, 36);
            this.txt_stock.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 30);
            this.label7.TabIndex = 76;
            this.label7.Text = "Medicamento";
            // 
            // txt_medicamento
            // 
            this.txt_medicamento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medicamento.Location = new System.Drawing.Point(33, 198);
            this.txt_medicamento.Name = "txt_medicamento";
            this.txt_medicamento.ReadOnly = true;
            this.txt_medicamento.Size = new System.Drawing.Size(351, 36);
            this.txt_medicamento.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(728, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 30);
            this.label5.TabIndex = 74;
            this.label5.Text = "Concentracion";
            // 
            // txt_concentracion
            // 
            this.txt_concentracion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_concentracion.Location = new System.Drawing.Point(733, 73);
            this.txt_concentracion.Name = "txt_concentracion";
            this.txt_concentracion.ReadOnly = true;
            this.txt_concentracion.Size = new System.Drawing.Size(238, 36);
            this.txt_concentracion.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(459, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 30);
            this.label4.TabIndex = 72;
            this.label4.Text = "Tipo Medicamento";
            // 
            // txt_tipoMedicamento
            // 
            this.txt_tipoMedicamento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoMedicamento.Location = new System.Drawing.Point(464, 73);
            this.txt_tipoMedicamento.Name = "txt_tipoMedicamento";
            this.txt_tipoMedicamento.ReadOnly = true;
            this.txt_tipoMedicamento.Size = new System.Drawing.Size(238, 36);
            this.txt_tipoMedicamento.TabIndex = 71;
            // 
            // btn_medicamento
            // 
            this.btn_medicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.btn_medicamento.FlatAppearance.BorderSize = 0;
            this.btn_medicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicamento.ForeColor = System.Drawing.Color.White;
            this.btn_medicamento.Location = new System.Drawing.Point(290, 80);
            this.btn_medicamento.Name = "btn_medicamento";
            this.btn_medicamento.Size = new System.Drawing.Size(94, 29);
            this.btn_medicamento.TabIndex = 68;
            this.btn_medicamento.Text = "Search";
            this.btn_medicamento.UseVisualStyleBackColor = false;
            this.btn_medicamento.Click += new System.EventHandler(this.btn_medicamento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 69;
            this.label3.Text = "Codigo";
            // 
            // txt_IDmedicamento
            // 
            this.txt_IDmedicamento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDmedicamento.Location = new System.Drawing.Point(33, 73);
            this.txt_IDmedicamento.Name = "txt_IDmedicamento";
            this.txt_IDmedicamento.ReadOnly = true;
            this.txt_IDmedicamento.Size = new System.Drawing.Size(238, 36);
            this.txt_IDmedicamento.TabIndex = 68;
            // 
            // gb_prov
            // 
            this.gb_prov.Controls.Add(this.btn_proveedor);
            this.gb_prov.Controls.Add(this.label1);
            this.gb_prov.Controls.Add(this.txt_idProveedor);
            this.gb_prov.Controls.Add(this.label9);
            this.gb_prov.Controls.Add(this.txt_proveedor);
            this.gb_prov.Controls.Add(this.txt_fechaCompra);
            this.gb_prov.Controls.Add(this.label6);
            this.gb_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_prov.ForeColor = System.Drawing.Color.White;
            this.gb_prov.Location = new System.Drawing.Point(36, 27);
            this.gb_prov.Name = "gb_prov";
            this.gb_prov.Size = new System.Drawing.Size(944, 154);
            this.gb_prov.TabIndex = 102;
            this.gb_prov.TabStop = false;
            this.gb_prov.Text = "Datos de la Compra";
            // 
            // btn_proveedor
            // 
            this.btn_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.btn_proveedor.FlatAppearance.BorderSize = 0;
            this.btn_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedor.ForeColor = System.Drawing.Color.White;
            this.btn_proveedor.Location = new System.Drawing.Point(580, 101);
            this.btn_proveedor.Name = "btn_proveedor";
            this.btn_proveedor.Size = new System.Drawing.Size(94, 29);
            this.btn_proveedor.TabIndex = 67;
            this.btn_proveedor.Text = "Search";
            this.btn_proveedor.UseVisualStyleBackColor = false;
            this.btn_proveedor.Click += new System.EventHandler(this.btn_proveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 66;
            this.label1.Text = "Id Proveedor";
            // 
            // txt_idProveedor
            // 
            this.txt_idProveedor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idProveedor.Location = new System.Drawing.Point(363, 94);
            this.txt_idProveedor.Name = "txt_idProveedor";
            this.txt_idProveedor.ReadOnly = true;
            this.txt_idProveedor.Size = new System.Drawing.Size(198, 36);
            this.txt_idProveedor.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 30);
            this.label9.TabIndex = 64;
            this.label9.Text = "Proveedor";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proveedor.Location = new System.Drawing.Point(34, 94);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.ReadOnly = true;
            this.txt_proveedor.Size = new System.Drawing.Size(291, 36);
            this.txt_proveedor.TabIndex = 63;
            // 
            // txt_fechaCompra
            // 
            this.txt_fechaCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fechaCompra.Location = new System.Drawing.Point(734, 98);
            this.txt_fechaCompra.Name = "txt_fechaCompra";
            this.txt_fechaCompra.Size = new System.Drawing.Size(167, 32);
            this.txt_fechaCompra.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(729, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 61;
            this.label6.Text = "Fecha ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1099, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 101;
            this.label2.Text = "N° Compra";
            // 
            // txt_Ncompra
            // 
            this.txt_Ncompra.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ncompra.Location = new System.Drawing.Point(1104, 145);
            this.txt_Ncompra.Name = "txt_Ncompra";
            this.txt_Ncompra.ReadOnly = true;
            this.txt_Ncompra.Size = new System.Drawing.Size(274, 36);
            this.txt_Ncompra.TabIndex = 100;
            // 
            // txt_tipoPago
            // 
            this.txt_tipoPago.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoPago.FormattingEnabled = true;
            this.txt_tipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.txt_tipoPago.Location = new System.Drawing.Point(1148, 860);
            this.txt_tipoPago.Name = "txt_tipoPago";
            this.txt_tipoPago.Size = new System.Drawing.Size(187, 35);
            this.txt_tipoPago.TabIndex = 139;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1497, 939);
            this.Controls.Add(this.txt_tipoPago);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_totalPago);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgv_compraProductos);
            this.Controls.Add(this.txt_ISV);
            this.Controls.Add(this.gb_ag);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_subTotal);
            this.Controls.Add(this.gb_medi);
            this.Controls.Add(this.gb_prov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ncompra);
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Compras_FormClosing);
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compraProductos)).EndInit();
            this.gb_ag.ResumeLayout(false);
            this.gb_ag.PerformLayout();
            this.gb_medi.ResumeLayout(false);
            this.gb_medi.PerformLayout();
            this.gb_prov.ResumeLayout(false);
            this.gb_prov.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_totalPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv_compraProductos;
        private System.Windows.Forms.TextBox txt_ISV;
        private System.Windows.Forms.GroupBox gb_ag;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_subTotal;
        private System.Windows.Forms.GroupBox gb_medi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_medicamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_concentracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tipoMedicamento;
        private System.Windows.Forms.Button btn_medicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IDmedicamento;
        private System.Windows.Forms.GroupBox gb_prov;
        private System.Windows.Forms.Button btn_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.DateTimePicker txt_fechaCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ncompra;
        private System.Windows.Forms.ComboBox txt_tipoPago;
    }
}