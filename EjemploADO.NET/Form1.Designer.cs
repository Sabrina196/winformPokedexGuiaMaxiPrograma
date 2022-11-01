
namespace EjemploADO.NET
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarF = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TlsElementos = new System.Windows.Forms.ToolStripLabel();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblMensajeCampo = new System.Windows.Forms.Label();
            this.lblMensajeCriterio = new System.Windows.Forms.Label();
            this.lblMensajeFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemon.Location = new System.Drawing.Point(25, 78);
            this.dgvPokemon.MultiSelect = false;
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemon.Size = new System.Drawing.Size(556, 285);
            this.dgvPokemon.TabIndex = 0;
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // pbPokemon
            // 
            this.pbPokemon.Location = new System.Drawing.Point(607, 78);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(288, 285);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPokemon.TabIndex = 1;
            this.pbPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(25, 396);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 38);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(164, 396);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 38);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarF
            // 
            this.btnEliminarF.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarF.Location = new System.Drawing.Point(428, 396);
            this.btnEliminarF.Name = "btnEliminarF";
            this.btnEliminarF.Size = new System.Drawing.Size(153, 38);
            this.btnEliminarF.TabIndex = 5;
            this.btnEliminarF.Text = "Eliminacion Física";
            this.btnEliminarF.UseVisualStyleBackColor = false;
            this.btnEliminarF.Click += new System.EventHandler(this.btnEliminarF_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminarLogico.Location = new System.Drawing.Point(300, 396);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(98, 38);
            this.btnEliminarLogico.TabIndex = 6;
            this.btnEliminarLogico.Text = "Eliminar Lógico";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlsElementos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(921, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TlsElementos
            // 
            this.TlsElementos.Name = "TlsElementos";
            this.TlsElementos.Size = new System.Drawing.Size(71, 22);
            this.TlsElementos.Text = "ELEMENTOS";
            this.TlsElementos.Click += new System.EventHandler(this.TlsElementos_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(22, 42);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(35, 13);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(63, 39);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(199, 20);
            this.txtFiltro.TabIndex = 9;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.Location = new System.Drawing.Point(607, 478);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(82, 34);
            this.btnFiltro.TabIndex = 10;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(22, 489);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 11;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(205, 488);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(398, 489);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(32, 13);
            this.lblFiltroAvanzado.TabIndex = 13;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(66, 486);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(129, 21);
            this.cboCampo.TabIndex = 14;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(253, 485);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(129, 21);
            this.cboCriterio.TabIndex = 15;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(436, 486);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(145, 20);
            this.txtFiltroAvanzado.TabIndex = 16;
            this.txtFiltroAvanzado.TextChanged += new System.EventHandler(this.txtFiltroAvanzado_TextChanged);
            // 
            // lblMensajeCampo
            // 
            this.lblMensajeCampo.AutoSize = true;
            this.lblMensajeCampo.Location = new System.Drawing.Point(63, 519);
            this.lblMensajeCampo.Name = "lblMensajeCampo";
            this.lblMensajeCampo.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeCampo.TabIndex = 17;
            // 
            // lblMensajeCriterio
            // 
            this.lblMensajeCriterio.AutoSize = true;
            this.lblMensajeCriterio.Location = new System.Drawing.Point(253, 518);
            this.lblMensajeCriterio.Name = "lblMensajeCriterio";
            this.lblMensajeCriterio.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeCriterio.TabIndex = 18;
            // 
            // lblMensajeFiltro
            // 
            this.lblMensajeFiltro.AutoSize = true;
            this.lblMensajeFiltro.Location = new System.Drawing.Point(436, 519);
            this.lblMensajeFiltro.Name = "lblMensajeFiltro";
            this.lblMensajeFiltro.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeFiltro.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 565);
            this.Controls.Add(this.lblMensajeFiltro);
            this.Controls.Add(this.lblMensajeCriterio);
            this.Controls.Add(this.lblMensajeCampo);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminarF);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.dgvPokemon);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POKEMONS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarF;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.ToolStripLabel TlsElementos;
        private System.Windows.Forms.Label lblMensajeCampo;
        private System.Windows.Forms.Label lblMensajeCriterio;
        private System.Windows.Forms.Label lblMensajeFiltro;
    }
}

