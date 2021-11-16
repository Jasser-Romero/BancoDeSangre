
namespace BancoDeSangre.Formularios
{
    partial class FrmDonaciones
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
            this.nudCantidadDonada = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMostrarDonantes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactorRH = new System.Windows.Forms.TextBox();
            this.txtGrupoSanguineo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDonar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDonada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDonantes)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCantidadDonada
            // 
            this.nudCantidadDonada.Location = new System.Drawing.Point(346, 114);
            this.nudCantidadDonada.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCantidadDonada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadDonada.Name = "nudCantidadDonada";
            this.nudCantidadDonada.Size = new System.Drawing.Size(139, 20);
            this.nudCantidadDonada.TabIndex = 32;
            this.nudCantidadDonada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Cantidad a donar:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(458, 24);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(148, 20);
            this.txtApellidos.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Factor RH:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Grupo Sanguíneo:";
            // 
            // dgvMostrarDonantes
            // 
            this.dgvMostrarDonantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDonantes.Location = new System.Drawing.Point(12, 173);
            this.dgvMostrarDonantes.Name = "dgvMostrarDonantes";
            this.dgvMostrarDonantes.Size = new System.Drawing.Size(776, 265);
            this.dgvMostrarDonantes.TabIndex = 41;
            this.dgvMostrarDonantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarDonantes_CellClick);
            this.dgvMostrarDonantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarDonantes_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Seleccione quien donará:";
            // 
            // txtFactorRH
            // 
            this.txtFactorRH.Location = new System.Drawing.Point(153, 69);
            this.txtFactorRH.Name = "txtFactorRH";
            this.txtFactorRH.ReadOnly = true;
            this.txtFactorRH.Size = new System.Drawing.Size(148, 20);
            this.txtFactorRH.TabIndex = 43;
            // 
            // txtGrupoSanguineo
            // 
            this.txtGrupoSanguineo.Location = new System.Drawing.Point(468, 69);
            this.txtGrupoSanguineo.Name = "txtGrupoSanguineo";
            this.txtGrupoSanguineo.ReadOnly = true;
            this.txtGrupoSanguineo.Size = new System.Drawing.Size(148, 20);
            this.txtGrupoSanguineo.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mililitros";
            // 
            // btnDonar
            // 
            this.btnDonar.Location = new System.Drawing.Point(346, 141);
            this.btnDonar.Name = "btnDonar";
            this.btnDonar.Size = new System.Drawing.Size(77, 26);
            this.btnDonar.TabIndex = 46;
            this.btnDonar.Text = "Donar";
            this.btnDonar.UseVisualStyleBackColor = true;
            this.btnDonar.Click += new System.EventHandler(this.btnDonar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(714, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 36);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmDonaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDonar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGrupoSanguineo);
            this.Controls.Add(this.txtFactorRH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMostrarDonantes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCantidadDonada);
            this.Controls.Add(this.label12);
            this.Name = "FrmDonaciones";
            this.Text = "FrmDonaciones";
            this.Load += new System.EventHandler(this.FrmDonaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDonada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDonantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCantidadDonada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMostrarDonantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFactorRH;
        private System.Windows.Forms.TextBox txtGrupoSanguineo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDonar;
        private System.Windows.Forms.Button btnCancelar;
    }
}