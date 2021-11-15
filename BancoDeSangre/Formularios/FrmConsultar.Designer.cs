
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
            this.dtgListaDonantes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmbBusquedas = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTextbox = new System.Windows.Forms.Panel();
            this.pnlCombobox = new System.Windows.Forms.Panel();
            this.cmbGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDonantes)).BeginInit();
            this.pnlTextbox.SuspendLayout();
            this.pnlCombobox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgListaDonantes
            // 
            this.dtgListaDonantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaDonantes.Location = new System.Drawing.Point(15, 99);
            this.dtgListaDonantes.Name = "dtgListaDonantes";
            this.dtgListaDonantes.Size = new System.Drawing.Size(761, 303);
            this.dtgListaDonantes.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar Donantes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(0, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(151, 20);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            // 
            // cmbBusquedas
            // 
            this.cmbBusquedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusquedas.FormattingEnabled = true;
            this.cmbBusquedas.Location = new System.Drawing.Point(76, 66);
            this.cmbBusquedas.Name = "cmbBusquedas";
            this.cmbBusquedas.Size = new System.Drawing.Size(139, 21);
            this.cmbBusquedas.TabIndex = 8;
            this.cmbBusquedas.SelectedIndexChanged += new System.EventHandler(this.cmbBusquedas_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(492, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlTextbox
            // 
            this.pnlTextbox.Controls.Add(this.txtBusqueda);
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
            this.cmbGrupoSanguineo.FormattingEnabled = true;
            this.cmbGrupoSanguineo.Location = new System.Drawing.Point(0, 1);
            this.cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            this.cmbGrupoSanguineo.Size = new System.Drawing.Size(151, 21);
            this.cmbGrupoSanguineo.TabIndex = 12;
            this.cmbGrupoSanguineo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGrupoSanguineo_KeyDown);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(675, 54);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(86, 34);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.pnlCombobox);
            this.Controls.Add(this.pnlTextbox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbBusquedas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgListaDonantes);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cmbBusquedas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlTextbox;
        private System.Windows.Forms.Panel pnlCombobox;
        private System.Windows.Forms.ComboBox cmbGrupoSanguineo;
        private System.Windows.Forms.Button btnGenerar;
    }
}