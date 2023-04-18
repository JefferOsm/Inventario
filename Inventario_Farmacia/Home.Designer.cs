
namespace Inventario_Farmacia
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_compras = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.menu_home = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_medicamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_laboratorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_compra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_venta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_devC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_devV = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menu_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_ventas);
            this.panel1.Controls.Add(this.btn_compras);
            this.panel1.Controls.Add(this.btn_Inventario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 100);
            this.panel1.TabIndex = 4;
            // 
            // btn_ventas
            // 
            this.btn_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(108)))));
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.ForeColor = System.Drawing.Color.White;
            this.btn_ventas.Location = new System.Drawing.Point(458, 25);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(187, 57);
            this.btn_ventas.TabIndex = 2;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_compras
            // 
            this.btn_compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(108)))));
            this.btn_compras.FlatAppearance.BorderSize = 0;
            this.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compras.ForeColor = System.Drawing.Color.White;
            this.btn_compras.Location = new System.Drawing.Point(245, 25);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(183, 57);
            this.btn_compras.TabIndex = 1;
            this.btn_compras.Text = "Compras";
            this.btn_compras.UseVisualStyleBackColor = false;
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(108)))));
            this.btn_Inventario.FlatAppearance.BorderSize = 0;
            this.btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventario.ForeColor = System.Drawing.Color.White;
            this.btn_Inventario.Location = new System.Drawing.Point(22, 25);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(183, 57);
            this.btn_Inventario.TabIndex = 0;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.UseVisualStyleBackColor = false;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // menu_home
            // 
            this.menu_home.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_home.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem1,
            this.movimientoToolStripMenuItem});
            this.menu_home.Location = new System.Drawing.Point(0, 0);
            this.menu_home.Name = "menu_home";
            this.menu_home.Size = new System.Drawing.Size(1428, 40);
            this.menu_home.TabIndex = 3;
            this.menu_home.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem1
            // 
            this.registroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_medicamentos,
            this.tsm_proveedores,
            this.tsm_laboratorios,
            this.tsm_categorias});
            this.registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            this.registroToolStripMenuItem1.Size = new System.Drawing.Size(115, 36);
            this.registroToolStripMenuItem1.Text = "Registro";
            // 
            // tsm_medicamentos
            // 
            this.tsm_medicamentos.Name = "tsm_medicamentos";
            this.tsm_medicamentos.Size = new System.Drawing.Size(340, 36);
            this.tsm_medicamentos.Text = "Medicamentos";
            this.tsm_medicamentos.Click += new System.EventHandler(this.tsm_medicamentos_Click_1);
            // 
            // tsm_proveedores
            // 
            this.tsm_proveedores.Name = "tsm_proveedores";
            this.tsm_proveedores.Size = new System.Drawing.Size(340, 36);
            this.tsm_proveedores.Text = "Proveedores";
            this.tsm_proveedores.Click += new System.EventHandler(this.tsm_proveedores_Click);
            // 
            // tsm_laboratorios
            // 
            this.tsm_laboratorios.Name = "tsm_laboratorios";
            this.tsm_laboratorios.Size = new System.Drawing.Size(340, 36);
            this.tsm_laboratorios.Text = "Laboratorios";
            this.tsm_laboratorios.Click += new System.EventHandler(this.tsm_laboratorios_Click);
            // 
            // tsm_categorias
            // 
            this.tsm_categorias.Name = "tsm_categorias";
            this.tsm_categorias.Size = new System.Drawing.Size(340, 36);
            this.tsm_categorias.Text = "Tipo de Medicamento";
            this.tsm_categorias.Click += new System.EventHandler(this.tsm_categorias_Click);
            // 
            // movimientoToolStripMenuItem
            // 
            this.movimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_compra,
            this.tsm_venta,
            this.tsm_devC,
            this.tsm_devV});
            this.movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem";
            this.movimientoToolStripMenuItem.Size = new System.Drawing.Size(159, 36);
            this.movimientoToolStripMenuItem.Text = "Movimiento";
            // 
            // tsm_compra
            // 
            this.tsm_compra.Name = "tsm_compra";
            this.tsm_compra.Size = new System.Drawing.Size(350, 36);
            this.tsm_compra.Text = "Compras";
            this.tsm_compra.Click += new System.EventHandler(this.tsm_compra_Click);
            // 
            // tsm_venta
            // 
            this.tsm_venta.Name = "tsm_venta";
            this.tsm_venta.Size = new System.Drawing.Size(350, 36);
            this.tsm_venta.Text = "Ventas";
            this.tsm_venta.Click += new System.EventHandler(this.tsm_venta_Click);
            // 
            // tsm_devC
            // 
            this.tsm_devC.Name = "tsm_devC";
            this.tsm_devC.Size = new System.Drawing.Size(350, 36);
            this.tsm_devC.Text = "Devolucion de Compra";
            // 
            // tsm_devV
            // 
            this.tsm_devV.Name = "tsm_devV";
            this.tsm_devV.Size = new System.Drawing.Size(350, 36);
            this.tsm_devV.Text = "Devolucion de Venta";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1428, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_home);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.menu_home.ResumeLayout(false);
            this.menu_home.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.MenuStrip menu_home;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsm_medicamentos;
        private System.Windows.Forms.ToolStripMenuItem tsm_proveedores;
        private System.Windows.Forms.ToolStripMenuItem tsm_laboratorios;
        private System.Windows.Forms.ToolStripMenuItem tsm_categorias;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_compra;
        private System.Windows.Forms.ToolStripMenuItem tsm_venta;
        private System.Windows.Forms.ToolStripMenuItem tsm_devC;
        private System.Windows.Forms.ToolStripMenuItem tsm_devV;
    }
}