
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
            this.rbId = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDonantes)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(545, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 32);
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
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Location = new System.Drawing.Point(89, 67);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(34, 17);
            this.rbId.TabIndex = 5;
            this.rbId.TabStop = true;
            this.rbId.Text = "Id";
            this.rbId.UseVisualStyleBackColor = true;
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Location = new System.Drawing.Point(145, 67);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(58, 17);
            this.rbCedula.TabIndex = 6;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula";
            this.rbCedula.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(226, 66);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(151, 20);
            this.txtBusqueda.TabIndex = 7;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.rbCedula);
            this.Controls.Add(this.rbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgListaDonantes);
            this.Name = "FrmConsultar";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDonantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaDonantes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}