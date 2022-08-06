
namespace Tarea2_NSB.Ejercicio1
{
    partial class NominaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SueldoTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.arsTextBox = new System.Windows.Forms.TextBox();
            this.irsTextBox = new System.Windows.Forms.TextBox();
            this.afpTextBox = new System.Windows.Forms.TextBox();
            this.descuentosTextBox = new System.Windows.Forms.TextBox();
            this.SueldoNetoTextBox = new System.Windows.Forms.TextBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de Nómina de Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo mensual";
            // 
            // SueldoTextBox
            // 
            this.SueldoTextBox.Location = new System.Drawing.Point(152, 71);
            this.SueldoTextBox.Name = "SueldoTextBox";
            this.SueldoTextBox.Size = new System.Drawing.Size(227, 20);
            this.SueldoTextBox.TabIndex = 2;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(385, 67);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(93, 29);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SueldoNetoTextBox);
            this.groupBox1.Controls.Add(this.descuentosTextBox);
            this.groupBox1.Controls.Add(this.afpTextBox);
            this.groupBox1.Controls.Add(this.irsTextBox);
            this.groupBox1.Controls.Add(this.arsTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nómina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto por ARS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto por IRS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto por AFP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total de Descuentos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sueldo Neto";
            // 
            // arsTextBox
            // 
            this.arsTextBox.Location = new System.Drawing.Point(180, 28);
            this.arsTextBox.Name = "arsTextBox";
            this.arsTextBox.ReadOnly = true;
            this.arsTextBox.Size = new System.Drawing.Size(268, 25);
            this.arsTextBox.TabIndex = 7;
            // 
            // irsTextBox
            // 
            this.irsTextBox.Location = new System.Drawing.Point(180, 58);
            this.irsTextBox.Name = "irsTextBox";
            this.irsTextBox.ReadOnly = true;
            this.irsTextBox.Size = new System.Drawing.Size(268, 25);
            this.irsTextBox.TabIndex = 8;
            // 
            // afpTextBox
            // 
            this.afpTextBox.Location = new System.Drawing.Point(180, 88);
            this.afpTextBox.Name = "afpTextBox";
            this.afpTextBox.ReadOnly = true;
            this.afpTextBox.Size = new System.Drawing.Size(268, 25);
            this.afpTextBox.TabIndex = 9;
            // 
            // descuentosTextBox
            // 
            this.descuentosTextBox.Location = new System.Drawing.Point(180, 118);
            this.descuentosTextBox.Name = "descuentosTextBox";
            this.descuentosTextBox.ReadOnly = true;
            this.descuentosTextBox.Size = new System.Drawing.Size(268, 25);
            this.descuentosTextBox.TabIndex = 10;
            // 
            // SueldoNetoTextBox
            // 
            this.SueldoNetoTextBox.Location = new System.Drawing.Point(180, 148);
            this.SueldoNetoTextBox.Name = "SueldoNetoTextBox";
            this.SueldoNetoTextBox.ReadOnly = true;
            this.SueldoNetoTextBox.Size = new System.Drawing.Size(268, 25);
            this.SueldoNetoTextBox.TabIndex = 11;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(385, 302);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(93, 29);
            this.LimpiarButton.TabIndex = 5;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // NominaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 340);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.SueldoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NominaForm";
            this.Text = "NominaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SueldoTextBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SueldoNetoTextBox;
        private System.Windows.Forms.TextBox descuentosTextBox;
        private System.Windows.Forms.TextBox afpTextBox;
        private System.Windows.Forms.TextBox irsTextBox;
        private System.Windows.Forms.TextBox arsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LimpiarButton;
    }
}