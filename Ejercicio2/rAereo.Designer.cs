﻿
namespace Tarea2_NSB.Ejercicio2
{
    partial class rAereo
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
            this.Velocidadtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAlastxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Velocidadtxt
            // 
            this.Velocidadtxt.Location = new System.Drawing.Point(200, 207);
            this.Velocidadtxt.Name = "Velocidadtxt";
            this.Velocidadtxt.Size = new System.Drawing.Size(268, 20);
            this.Velocidadtxt.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Velocidad";
            // 
            // numAlastxt
            // 
            this.numAlastxt.Location = new System.Drawing.Point(200, 169);
            this.numAlastxt.Name = "numAlastxt";
            this.numAlastxt.Size = new System.Drawing.Size(268, 20);
            this.numAlastxt.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Numero de Alas";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Rockwell", 10.25F, System.Drawing.FontStyle.Bold);
            this.GuardarButton.Location = new System.Drawing.Point(504, 119);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 33);
            this.GuardarButton.TabIndex = 31;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(273, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Helicopteros";
            // 
            // rAereo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 270);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.Velocidadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numAlastxt);
            this.Controls.Add(this.label1);
            this.Name = "rAereo";
            this.Text = "Registro de Vehiculos Aereos";
            this.Controls.SetChildIndex(this.marcaTextBox, 0);
            this.Controls.SetChildIndex(this.anioTextBox, 0);
            this.Controls.SetChildIndex(this.placaTextBox, 0);
            this.Controls.SetChildIndex(this.combustibleTextBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.numAlastxt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Velocidadtxt, 0);
            this.Controls.SetChildIndex(this.GuardarButton, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Velocidadtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numAlastxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label label8;
    }
}