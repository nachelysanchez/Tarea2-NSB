
namespace Tarea2_NSB.Ejercicio2
{
    partial class VehiculoGeneralFrm
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
            this.combustibleTextBox = new System.Windows.Forms.TextBox();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combustibleTextBox
            // 
            this.combustibleTextBox.Location = new System.Drawing.Point(200, 132);
            this.combustibleTextBox.Name = "combustibleTextBox";
            this.combustibleTextBox.Size = new System.Drawing.Size(268, 20);
            this.combustibleTextBox.TabIndex = 20;
            // 
            // placaTextBox
            // 
            this.placaTextBox.Location = new System.Drawing.Point(200, 102);
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(268, 20);
            this.placaTextBox.TabIndex = 19;
            this.placaTextBox.TextChanged += new System.EventHandler(this.placaTextBox_TextChanged);
            // 
            // anioTextBox
            // 
            this.anioTextBox.Location = new System.Drawing.Point(200, 72);
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(268, 20);
            this.anioTextBox.TabIndex = 18;
            this.anioTextBox.TextChanged += new System.EventHandler(this.anioTextBox_TextChanged);
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Location = new System.Drawing.Point(200, 42);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(268, 20);
            this.marcaTextBox.TabIndex = 17;
            this.marcaTextBox.TextChanged += new System.EventHandler(this.marcaTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Combustible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca";
            // 
            // SalirButton
            // 
            this.SalirButton.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.Location = new System.Drawing.Point(504, 168);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 30);
            this.SalirButton.TabIndex = 22;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // VehiculoGeneralFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 240);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.combustibleTextBox);
            this.Controls.Add(this.placaTextBox);
            this.Controls.Add(this.anioTextBox);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "VehiculoGeneralFrm";
            this.Load += new System.EventHandler(this.VehiculoGeneralFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SalirButton;
        protected System.Windows.Forms.TextBox combustibleTextBox;
        protected System.Windows.Forms.TextBox placaTextBox;
        protected System.Windows.Forms.TextBox anioTextBox;
        protected System.Windows.Forms.TextBox marcaTextBox;
    }
}