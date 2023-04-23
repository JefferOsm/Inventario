
namespace Inventario_Farmacia
{
    partial class Devolucion_Venta
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_fechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ndevolucion = new System.Windows.Forms.TextBox();
            this.gb_ag = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.db_medi = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_medicamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cantidadVendida = new System.Windows.Forms.TextBox();
            this.btn_medicamento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IDmedicamento = new System.Windows.Forms.TextBox();
            this.gb_prov = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_subt = new System.Windows.Forms.TextBox();
            this.btn_proveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_totalVenta = new System.Windows.Forms.TextBox();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gb_ag.SuspendLayout();
            this.db_medi.SuspendLayout();
            this.gb_prov.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(1227, 472);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(192, 51);
            this.btn_guardar.TabIndex = 148;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(1227, 542);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(192, 51);
            this.btn_salir.TabIndex = 147;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_fechaCompra
            // 
            this.txt_fechaCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fechaCompra.Location = new System.Drawing.Point(675, 56);
            this.txt_fechaCompra.Name = "txt_fechaCompra";
            this.txt_fechaCompra.Size = new System.Drawing.Size(167, 32);
            this.txt_fechaCompra.TabIndex = 139;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(565, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 138;
            this.label6.Text = "Fecha ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.TabIndex = 141;
            this.label2.Text = "N° Devolucion";
            // 
            // txt_Ndevolucion
            // 
            this.txt_Ndevolucion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ndevolucion.Location = new System.Drawing.Point(245, 52);
            this.txt_Ndevolucion.Name = "txt_Ndevolucion";
            this.txt_Ndevolucion.ReadOnly = true;
            this.txt_Ndevolucion.Size = new System.Drawing.Size(274, 36);
            this.txt_Ndevolucion.TabIndex = 140;
            // 
            // gb_ag
            // 
            this.gb_ag.Controls.Add(this.label12);
            this.gb_ag.Controls.Add(this.txt_importe);
            this.gb_ag.Controls.Add(this.label11);
            this.gb_ag.Controls.Add(this.txt_cantidad);
            this.gb_ag.Location = new System.Drawing.Point(31, 393);
            this.gb_ag.Name = "gb_ag";
            this.gb_ag.Size = new System.Drawing.Size(811, 104);
            this.gb_ag.TabIndex = 150;
            this.gb_ag.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(358, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 30);
            this.label12.TabIndex = 85;
            this.label12.Text = "Total a Devolver";
            // 
            // txt_importe
            // 
            this.txt_importe.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe.Location = new System.Drawing.Point(580, 37);
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
            // db_medi
            // 
            this.db_medi.Controls.Add(this.label8);
            this.db_medi.Controls.Add(this.txt_stock);
            this.db_medi.Controls.Add(this.label7);
            this.db_medi.Controls.Add(this.txt_medicamento);
            this.db_medi.Controls.Add(this.label5);
            this.db_medi.Controls.Add(this.txt_cantidadVendida);
            this.db_medi.Controls.Add(this.btn_medicamento);
            this.db_medi.Controls.Add(this.label3);
            this.db_medi.Controls.Add(this.txt_IDmedicamento);
            this.db_medi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_medi.ForeColor = System.Drawing.Color.White;
            this.db_medi.Location = new System.Drawing.Point(31, 113);
            this.db_medi.Name = "db_medi";
            this.db_medi.Size = new System.Drawing.Size(802, 274);
            this.db_medi.TabIndex = 151;
            this.db_medi.TabStop = false;
            this.db_medi.Text = "Datos del Medicamento a devolver";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(434, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 78;
            this.label8.Text = "Stock";
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(439, 74);
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
            this.label5.Location = new System.Drawing.Point(438, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 30);
            this.label5.TabIndex = 74;
            this.label5.Text = "Cantidad Vendida";
            // 
            // txt_cantidadVendida
            // 
            this.txt_cantidadVendida.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadVendida.Location = new System.Drawing.Point(443, 200);
            this.txt_cantidadVendida.Name = "txt_cantidadVendida";
            this.txt_cantidadVendida.ReadOnly = true;
            this.txt_cantidadVendida.Size = new System.Drawing.Size(238, 36);
            this.txt_cantidadVendida.TabIndex = 73;
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
            this.gb_prov.Controls.Add(this.label10);
            this.gb_prov.Controls.Add(this.txt_descuento);
            this.gb_prov.Controls.Add(this.label4);
            this.gb_prov.Controls.Add(this.txt_subt);
            this.gb_prov.Controls.Add(this.btn_proveedor);
            this.gb_prov.Controls.Add(this.label1);
            this.gb_prov.Controls.Add(this.txt_idVenta);
            this.gb_prov.Controls.Add(this.label9);
            this.gb_prov.Controls.Add(this.txt_totalVenta);
            this.gb_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_prov.ForeColor = System.Drawing.Color.White;
            this.gb_prov.Location = new System.Drawing.Point(860, 123);
            this.gb_prov.Name = "gb_prov";
            this.gb_prov.Size = new System.Drawing.Size(559, 264);
            this.gb_prov.TabIndex = 152;
            this.gb_prov.TabStop = false;
            this.gb_prov.Text = "Datos de la Venta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(286, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 30);
            this.label10.TabIndex = 71;
            this.label10.Text = "Descuento";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuento.Location = new System.Drawing.Point(291, 199);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.ReadOnly = true;
            this.txt_descuento.Size = new System.Drawing.Size(223, 36);
            this.txt_descuento.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 69;
            this.label4.Text = "SubTotal";
            // 
            // txt_subt
            // 
            this.txt_subt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subt.Location = new System.Drawing.Point(35, 199);
            this.txt_subt.Name = "txt_subt";
            this.txt_subt.ReadOnly = true;
            this.txt_subt.Size = new System.Drawing.Size(223, 36);
            this.txt_subt.TabIndex = 68;
            // 
            // btn_proveedor
            // 
            this.btn_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.btn_proveedor.FlatAppearance.BorderSize = 0;
            this.btn_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedor.ForeColor = System.Drawing.Color.White;
            this.btn_proveedor.Location = new System.Drawing.Point(146, 54);
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
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 66;
            this.label1.Text = "N Venta";
            // 
            // txt_idVenta
            // 
            this.txt_idVenta.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idVenta.Location = new System.Drawing.Point(35, 89);
            this.txt_idVenta.Name = "txt_idVenta";
            this.txt_idVenta.ReadOnly = true;
            this.txt_idVenta.Size = new System.Drawing.Size(205, 36);
            this.txt_idVenta.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(286, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 30);
            this.label9.TabIndex = 64;
            this.label9.Text = "Total";
            // 
            // txt_totalVenta
            // 
            this.txt_totalVenta.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalVenta.Location = new System.Drawing.Point(291, 89);
            this.txt_totalVenta.Name = "txt_totalVenta";
            this.txt_totalVenta.ReadOnly = true;
            this.txt_totalVenta.Size = new System.Drawing.Size(223, 36);
            this.txt_totalVenta.TabIndex = 63;
            // 
            // txt_motivo
            // 
            this.txt_motivo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_motivo.Location = new System.Drawing.Point(36, 558);
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(797, 140);
            this.txt_motivo.TabIndex = 79;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(31, 520);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 30);
            this.label13.TabIndex = 79;
            this.label13.Text = "Motivo Devolucion";
            // 
            // Devolucion_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1483, 737);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.gb_prov);
            this.Controls.Add(this.db_medi);
            this.Controls.Add(this.gb_ag);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_fechaCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ndevolucion);
            this.Name = "Devolucion_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Devolucion_Venta_FormClosing);
            this.Load += new System.EventHandler(this.Devolucion_Venta_Load);
            this.gb_ag.ResumeLayout(false);
            this.gb_ag.PerformLayout();
            this.db_medi.ResumeLayout(false);
            this.db_medi.PerformLayout();
            this.gb_prov.ResumeLayout(false);
            this.gb_prov.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DateTimePicker txt_fechaCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ndevolucion;
        private System.Windows.Forms.GroupBox gb_ag;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.GroupBox db_medi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_medicamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cantidadVendida;
        private System.Windows.Forms.Button btn_medicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IDmedicamento;
        private System.Windows.Forms.GroupBox gb_prov;
        private System.Windows.Forms.Button btn_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_totalVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_subt;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label label13;
    }
}