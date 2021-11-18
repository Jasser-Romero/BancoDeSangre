
namespace BancoDeSangre.Formularios
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            this.dtgListaDonantes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmbBusquedas = new System.Windows.Forms.ComboBox();
            this.pnlTextbox = new System.Windows.Forms.Panel();
            this.pnlCombobox = new System.Windows.Forms.Panel();
            this.cmbGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDonantes)).BeginInit();
            this.pnlTextbox.SuspendLayout();
            this.pnlCombobox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgListaDonantes
            // 
            this.dtgListaDonantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaDonantes.Location = new System.Drawing.Point(12, 111);
            this.dtgListaDonantes.Name = "dtgListaDonantes";
            this.dtgListaDonantes.Size = new System.Drawing.Size(904, 306);
            this.dtgListaDonantes.TabIndex = 0;
            this.dtgListaDonantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaDonantes_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(0, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(151, 22);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            // 
            // cmbBusquedas
            // 
            this.cmbBusquedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusquedas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cmbBusquedas.FormattingEnabled = true;
            this.cmbBusquedas.Location = new System.Drawing.Point(85, 64);
            this.cmbBusquedas.Name = "cmbBusquedas";
            this.cmbBusquedas.Size = new System.Drawing.Size(139, 25);
            this.cmbBusquedas.TabIndex = 8;
            this.cmbBusquedas.SelectedIndexChanged += new System.EventHandler(this.cmbBusquedas_SelectedIndexChanged);
            // 
            // pnlTextbox
            // 
            this.pnlTextbox.Controls.Add(this.txtBusqueda);
            this.pnlTextbox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.pnlTextbox.Location = new System.Drawing.Point(230, 64);
            this.pnlTextbox.Name = "pnlTextbox";
            this.pnlTextbox.Size = new System.Drawing.Size(151, 23);
            this.pnlTextbox.TabIndex = 10;
            this.pnlTextbox.Visible = false;
            // 
            // pnlCombobox
            // 
            this.pnlCombobox.Controls.Add(this.cmbGrupoSanguineo);
            this.pnlCombobox.Location = new System.Drawing.Point(230, 64);
            this.pnlCombobox.Name = "pnlCombobox";
            this.pnlCombobox.Size = new System.Drawing.Size(151, 23);
            this.pnlCombobox.TabIndex = 11;
            this.pnlCombobox.Visible = false;
            // 
            // cmbGrupoSanguineo
            // 
            this.cmbGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoSanguineo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cmbGrupoSanguineo.FormattingEnabled = true;
            this.cmbGrupoSanguineo.Location = new System.Drawing.Point(0, 1);
            this.cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            this.cmbGrupoSanguineo.Size = new System.Drawing.Size(151, 25);
            this.cmbGrupoSanguineo.TabIndex = 12;
            this.cmbGrupoSanguineo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGrupoSanguineo_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(395, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 23);
            this.label14.TabIndex = 14;
            this.label14.Text = "CONSULTAR DONANTE";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.LightGray;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnGenerar.Image = global::BancoDeSangre.Properties.Resources.icons8_health_report_30;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(762, 49);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(145, 53);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::BancoDeSangre.Properties.Resources.icons8_cancelar_30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(476, 452);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightGray;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnBorrar.Image = global::BancoDeSangre.Properties.Resources.icons8_dustpan_30;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(736, 450);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 36);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightGray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnActualizar.Image = global::BancoDeSangre.Properties.Resources.icons8_actualizar_30;
            this.btnActualizar.Location = new System.Drawing.Point(606, 450);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 597);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.pnlCombobox);
            this.Controls.Add(this.pnlTextbox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbBusquedas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtgListaDonantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultar";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDonantes)).EndInit();
            this.pnlTextbox.ResumeLayout(false);
            this.pnlTextbox.PerformLayout();
            this.pnlCombobox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaDonantes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cmbBusquedas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlTextbox;
        private System.Windows.Forms.Panel pnlCombobox;
        private System.Windows.Forms.ComboBox cmbGrupoSanguineo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label14;
    }
}