
namespace EjemploADO.NET
{
    partial class Form2
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
            this.dgvElemento = new System.Windows.Forms.DataGridView();
            this.btnCargarElemento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElemento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElemento
            // 
            this.dgvElemento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvElemento.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvElemento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElemento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvElemento.Location = new System.Drawing.Point(47, 12);
            this.dgvElemento.MultiSelect = false;
            this.dgvElemento.Name = "dgvElemento";
            this.dgvElemento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElemento.Size = new System.Drawing.Size(258, 283);
            this.dgvElemento.TabIndex = 0;
            // 
            // btnCargarElemento
            // 
            this.btnCargarElemento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCargarElemento.Location = new System.Drawing.Point(129, 329);
            this.btnCargarElemento.Name = "btnCargarElemento";
            this.btnCargarElemento.Size = new System.Drawing.Size(90, 36);
            this.btnCargarElemento.TabIndex = 1;
            this.btnCargarElemento.Text = "Agregar";
            this.btnCargarElemento.UseVisualStyleBackColor = false;
            this.btnCargarElemento.Click += new System.EventHandler(this.btnCargarElemento_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 390);
            this.Controls.Add(this.btnCargarElemento);
            this.Controls.Add(this.dgvElemento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELEMENTOS";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElemento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElemento;
        private System.Windows.Forms.Button btnCargarElemento;
    }
}