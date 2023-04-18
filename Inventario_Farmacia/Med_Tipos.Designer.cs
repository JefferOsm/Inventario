
namespace Inventario_Farmacia
{
    partial class Med_Tipos
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_tipo_medicamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_medicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(517, 629);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(192, 51);
            this.btn_agregar.TabIndex = 115;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_tipo_medicamento
            // 
            this.dgv_tipo_medicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipo_medicamento.Location = new System.Drawing.Point(66, 39);
            this.dgv_tipo_medicamento.Name = "dgv_tipo_medicamento";
            this.dgv_tipo_medicamento.ReadOnly = true;
            this.dgv_tipo_medicamento.RowHeadersVisible = false;
            this.dgv_tipo_medicamento.RowHeadersWidth = 51;
            this.dgv_tipo_medicamento.RowTemplate.Height = 24;
            this.dgv_tipo_medicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tipo_medicamento.Size = new System.Drawing.Size(1039, 569);
            this.dgv_tipo_medicamento.TabIndex = 114;
            this.dgv_tipo_medicamento.Click += new System.EventHandler(this.dgv_tipo_medicamento_Click);
            // 
            // Med_Tipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1170, 719);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dgv_tipo_medicamento);
            this.Name = "Med_Tipos";
            this.Text = "Tipo de Medicamentos";
            this.Load += new System.EventHandler(this.Med_Tipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_medicamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_tipo_medicamento;
    }
}