
namespace EjemploADO.NET
{
    partial class Form4
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
            this.lblElemento = new System.Windows.Forms.Label();
            this.btnAceptarEleNuevo = new System.Windows.Forms.Button();
            this.btnCancelarEleNuevo = new System.Windows.Forms.Button();
            this.txtElementoNuevo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(56, 37);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(54, 13);
            this.lblElemento.TabIndex = 0;
            this.lblElemento.Text = "Elemento:";
            // 
            // btnAceptarEleNuevo
            // 
            this.btnAceptarEleNuevo.Location = new System.Drawing.Point(47, 97);
            this.btnAceptarEleNuevo.Name = "btnAceptarEleNuevo";
            this.btnAceptarEleNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarEleNuevo.TabIndex = 1;
            this.btnAceptarEleNuevo.Text = "Aceptar";
            this.btnAceptarEleNuevo.UseVisualStyleBackColor = true;
            this.btnAceptarEleNuevo.Click += new System.EventHandler(this.btnAceptarEleNuevo_Click);
            // 
            // btnCancelarEleNuevo
            // 
            this.btnCancelarEleNuevo.Location = new System.Drawing.Point(190, 97);
            this.btnCancelarEleNuevo.Name = "btnCancelarEleNuevo";
            this.btnCancelarEleNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEleNuevo.TabIndex = 2;
            this.btnCancelarEleNuevo.Text = "Cancelar";
            this.btnCancelarEleNuevo.UseVisualStyleBackColor = true;
            this.btnCancelarEleNuevo.Click += new System.EventHandler(this.btnCancelarEleNuevo_Click);
            // 
            // txtElementoNuevo
            // 
            this.txtElementoNuevo.Location = new System.Drawing.Point(128, 34);
            this.txtElementoNuevo.Name = "txtElementoNuevo";
            this.txtElementoNuevo.Size = new System.Drawing.Size(125, 20);
            this.txtElementoNuevo.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 145);
            this.Controls.Add(this.txtElementoNuevo);
            this.Controls.Add(this.btnCancelarEleNuevo);
            this.Controls.Add(this.btnAceptarEleNuevo);
            this.Controls.Add(this.lblElemento);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Button btnAceptarEleNuevo;
        private System.Windows.Forms.Button btnCancelarEleNuevo;
        private System.Windows.Forms.TextBox txtElementoNuevo;
    }
}