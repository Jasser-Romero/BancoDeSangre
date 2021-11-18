
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonaciones));
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
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDonar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDonada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDonantes)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCantidadDonada
            // 
            this.nudCantidadDonada.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.nudCantidadDonada.Location = new System.Drawing.Point(395, 154);
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
            this.nudCantidadDonada.Size = new System.Drawing.Size(139, 22);
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
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label12.Location = new System.Drawing.Point(273, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Cantidad a donar:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtApellidos.Location = new System.Drawing.Point(626, 52);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(148, 22);
            this.txtApellidos.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtNombre.Location = new System.Drawing.Point(249, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(148, 22);
            this.txtNombre.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(549, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(185, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label11.Location = new System.Drawing.Point(173, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Factor RH:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label10.Location = new System.Drawing.Point(506, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Grupo Sanguíneo:";
            // 
            // dgvMostrarDonantes
            // 
            this.dgvMostrarDonantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostrarDonantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrarDonantes.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvMostrarDonantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarDonantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarDonantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarDonantes.ColumnHeadersHeight = 30;
            this.dgvMostrarDonantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMostrarDonantes.EnableHeadersVisualStyles = false;
            this.dgvMostrarDonantes.GridColor = System.Drawing.Color.Red;
            this.dgvMostrarDonantes.Location = new System.Drawing.Point(23, 233);
            this.dgvMostrarDonantes.Name = "dgvMostrarDonantes";
            this.dgvMostrarDonantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarDonantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMostrarDonantes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrarDonantes.Size = new System.Drawing.Size(910, 265);
            this.dgvMostrarDonantes.TabIndex = 41;
            this.dgvMostrarDonantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarDonantes_CellClick);
            this.dgvMostrarDonantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarDonantes_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.Location = new System.Drawing.Point(35, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Seleccione quien donará:";
            // 
            // txtFactorRH
            // 
            this.txtFactorRH.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtFactorRH.Location = new System.Drawing.Point(249, 98);
            this.txtFactorRH.Name = "txtFactorRH";
            this.txtFactorRH.ReadOnly = true;
            this.txtFactorRH.Size = new System.Drawing.Size(148, 22);
            this.txtFactorRH.TabIndex = 43;
            this.txtFactorRH.TextChanged += new System.EventHandler(this.txtFactorRH_TextChanged);
            // 
            // txtGrupoSanguineo
            // 
            this.txtGrupoSanguineo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtGrupoSanguineo.Location = new System.Drawing.Point(626, 102);
            this.txtGrupoSanguineo.Name = "txtGrupoSanguineo";
            this.txtGrupoSanguineo.ReadOnly = true;
            this.txtGrupoSanguineo.Size = new System.Drawing.Size(148, 22);
            this.txtGrupoSanguineo.TabIndex = 44;
            this.txtGrupoSanguineo.TextChanged += new System.EventHandler(this.txtGrupoSanguineo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(564, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mililitros";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(443, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 23);
            this.label14.TabIndex = 48;
            this.label14.Text = "DONACION";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnCancelar.Image = global::BancoDeSangre.Properties.Resources.icons8_cancelar_30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(822, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 46);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDonar
            // 
            this.btnDonar.BackColor = System.Drawing.Color.LightGray;
            this.btnDonar.FlatAppearance.BorderSize = 0;
            this.btnDonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnDonar.Image = global::BancoDeSangre.Properties.Resources.icons8_gota_de_sangre_30;
            this.btnDonar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonar.Location = new System.Drawing.Point(705, 173);
            this.btnDonar.Name = "btnDonar";
            this.btnDonar.Size = new System.Drawing.Size(92, 45);
            this.btnDonar.TabIndex = 46;
            this.btnDonar.Text = "Donar";
            this.btnDonar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonar.UseVisualStyleBackColor = false;
            this.btnDonar.Click += new System.EventHandler(this.btnDonar_Click);
            // 
            // FrmDonaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 559);
            this.Controls.Add(this.label14);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label14;
    }
}