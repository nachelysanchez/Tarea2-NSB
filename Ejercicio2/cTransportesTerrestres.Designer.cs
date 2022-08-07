
namespace Tarea2_NSB.Ejercicio2
{
    partial class cTransportesTerrestres
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
            this.terrestresGrid = new System.Windows.Forms.DataGridView();
            this.MarcaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CombustibleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRuedasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPuertasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.terrestresGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // terrestresGrid
            // 
            this.terrestresGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.terrestresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terrestresGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarcaColumn,
            this.AnioColumn,
            this.PlacaColumn,
            this.CombustibleColumn,
            this.NumRuedasColumn,
            this.NumPuertasColumn,
            this.ReservadoColumn});
            this.terrestresGrid.Location = new System.Drawing.Point(31, 70);
            this.terrestresGrid.Name = "terrestresGrid";
            this.terrestresGrid.Size = new System.Drawing.Size(741, 150);
            this.terrestresGrid.TabIndex = 0;
            // 
            // MarcaColumn
            // 
            this.MarcaColumn.HeaderText = "Marca";
            this.MarcaColumn.Name = "MarcaColumn";
            this.MarcaColumn.ReadOnly = true;
            // 
            // AnioColumn
            // 
            this.AnioColumn.HeaderText = "Año";
            this.AnioColumn.Name = "AnioColumn";
            this.AnioColumn.ReadOnly = true;
            // 
            // PlacaColumn
            // 
            this.PlacaColumn.HeaderText = "Placa";
            this.PlacaColumn.Name = "PlacaColumn";
            this.PlacaColumn.ReadOnly = true;
            // 
            // CombustibleColumn
            // 
            this.CombustibleColumn.HeaderText = "Combustible";
            this.CombustibleColumn.Name = "CombustibleColumn";
            this.CombustibleColumn.ReadOnly = true;
            // 
            // NumRuedasColumn
            // 
            this.NumRuedasColumn.HeaderText = "Número de Ruedas";
            this.NumRuedasColumn.Name = "NumRuedasColumn";
            this.NumRuedasColumn.ReadOnly = true;
            // 
            // NumPuertasColumn
            // 
            this.NumPuertasColumn.HeaderText = "Número de Puertas";
            this.NumPuertasColumn.Name = "NumPuertasColumn";
            this.NumPuertasColumn.ReadOnly = true;
            // 
            // ReservadoColumn
            // 
            this.ReservadoColumn.HeaderText = "Reservado";
            this.ReservadoColumn.Name = "ReservadoColumn";
            this.ReservadoColumn.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(297, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Vehiculos Terrestres";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(687, 41);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 34;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // cTransportesTerrestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 245);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.terrestresGrid);
            this.Name = "cTransportesTerrestres";
            this.Text = "Vehiculos Terrestres";
            this.Load += new System.EventHandler(this.cTransportesTerrestres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terrestresGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView terrestresGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CombustibleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRuedasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPuertasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservadoColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BuscarButton;
    }
}