namespace Season.Discoteca.Winforms
{
    partial class FrmListaMusicas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMusicas = new System.Windows.Forms.DataGridView();
            this.clmIdMusica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTituloMusica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnoMusica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteMusic = new System.Windows.Forms.Button();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.btnAlterMusic = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvMusicas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Músicas";
            // 
            // dgvMusicas
            // 
            this.dgvMusicas.AllowUserToAddRows = false;
            this.dgvMusicas.AllowUserToDeleteRows = false;
            this.dgvMusicas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdMusica,
            this.clmTituloMusica,
            this.clmAnoMusica});
            this.dgvMusicas.Location = new System.Drawing.Point(6, 19);
            this.dgvMusicas.MultiSelect = false;
            this.dgvMusicas.Name = "dgvMusicas";
            this.dgvMusicas.ReadOnly = true;
            this.dgvMusicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusicas.Size = new System.Drawing.Size(350, 358);
            this.dgvMusicas.TabIndex = 0;
            // 
            // clmIdMusica
            // 
            this.clmIdMusica.DataPropertyName = "Id";
            this.clmIdMusica.HeaderText = "Id";
            this.clmIdMusica.Name = "clmIdMusica";
            this.clmIdMusica.Visible = false;
            // 
            // clmTituloMusica
            // 
            this.clmTituloMusica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmTituloMusica.DataPropertyName = "Titulo";
            this.clmTituloMusica.HeaderText = "Titulo Musica";
            this.clmTituloMusica.Name = "clmTituloMusica";
            this.clmTituloMusica.ReadOnly = true;
            this.clmTituloMusica.Width = 95;
            // 
            // clmAnoMusica
            // 
            this.clmAnoMusica.DataPropertyName = "Ano";
            this.clmAnoMusica.HeaderText = "Ano Música";
            this.clmAnoMusica.Name = "clmAnoMusica";
            this.clmAnoMusica.ReadOnly = true;
            this.clmAnoMusica.Width = 200;
            // 
            // btnDeleteMusic
            // 
            this.btnDeleteMusic.Location = new System.Drawing.Point(19, 408);
            this.btnDeleteMusic.Name = "btnDeleteMusic";
            this.btnDeleteMusic.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMusic.TabIndex = 1;
            this.btnDeleteMusic.Text = "&Remove";
            this.btnDeleteMusic.UseVisualStyleBackColor = true;
            this.btnDeleteMusic.Click += new System.EventHandler(this.btnDeleteMusic_Click);
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Location = new System.Drawing.Point(100, 408);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(75, 23);
            this.btnAddMusic.TabIndex = 2;
            this.btnAddMusic.Text = "&Add";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // btnAlterMusic
            // 
            this.btnAlterMusic.Location = new System.Drawing.Point(181, 408);
            this.btnAlterMusic.Name = "btnAlterMusic";
            this.btnAlterMusic.Size = new System.Drawing.Size(75, 23);
            this.btnAlterMusic.TabIndex = 3;
            this.btnAlterMusic.Text = "Alter";
            this.btnAlterMusic.UseVisualStyleBackColor = true;
            this.btnAlterMusic.Click += new System.EventHandler(this.btnAlterMusic_Click);
            // 
            // FrmListaMusicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 443);
            this.Controls.Add(this.btnAlterMusic);
            this.Controls.Add(this.btnAddMusic);
            this.Controls.Add(this.btnDeleteMusic);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmListaMusicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discoteca - Lista de Músicas Cadastradas";
            this.Load += new System.EventHandler(this.FrmListaMusicas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMusicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdMusica;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTituloMusica;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnoMusica;
        private System.Windows.Forms.Button btnDeleteMusic;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Button btnAlterMusic;
    }
}

