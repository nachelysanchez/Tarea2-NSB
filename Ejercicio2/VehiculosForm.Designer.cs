
namespace Tarea2_NSB.Ejercicio2
{
    partial class VehiculosForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lanchasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helicopterosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTransportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarUnVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosToolStripMenuItem,
            this.transportesToolStripMenuItem,
            this.reservacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrosToolStripMenuItem,
            this.lanchasToolStripMenuItem,
            this.helicopterosToolStripMenuItem});
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // carrosToolStripMenuItem
            // 
            this.carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            this.carrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carrosToolStripMenuItem.Text = "Carros";
            this.carrosToolStripMenuItem.Click += new System.EventHandler(this.carrosToolStripMenuItem_Click);
            // 
            // lanchasToolStripMenuItem
            // 
            this.lanchasToolStripMenuItem.Name = "lanchasToolStripMenuItem";
            this.lanchasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lanchasToolStripMenuItem.Text = "Lanchas";
            // 
            // helicopterosToolStripMenuItem
            // 
            this.helicopterosToolStripMenuItem.Name = "helicopterosToolStripMenuItem";
            this.helicopterosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helicopterosToolStripMenuItem.Text = "Helicopteros";
            // 
            // transportesToolStripMenuItem
            // 
            this.transportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTransportesToolStripMenuItem});
            this.transportesToolStripMenuItem.Name = "transportesToolStripMenuItem";
            this.transportesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.transportesToolStripMenuItem.Text = "Transportes";
            // 
            // verTransportesToolStripMenuItem
            // 
            this.verTransportesToolStripMenuItem.Name = "verTransportesToolStripMenuItem";
            this.verTransportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verTransportesToolStripMenuItem.Text = "Ver Transportes";
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservarUnVehiculoToolStripMenuItem});
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // reservarUnVehiculoToolStripMenuItem
            // 
            this.reservarUnVehiculoToolStripMenuItem.Name = "reservarUnVehiculoToolStripMenuItem";
            this.reservarUnVehiculoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.reservarUnVehiculoToolStripMenuItem.Text = "Reservar un vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(156, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compañia Turistica";
            // 
            // VehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VehiculosForm";
            this.Text = "VehiculosForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lanchasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helicopterosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTransportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarUnVehiculoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}