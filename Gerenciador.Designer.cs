namespace GerenciadorDeOvni
{
    partial class Gerenciador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.grbTripulacao = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulante = new System.Windows.Forms.Button();
            this.btnAddTripulante = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAbduzido = new System.Windows.Forms.Button();
            this.btnAddAbduzido = new System.Windows.Forms.Button();
            this.grbEstatisticas = new System.Windows.Forms.GroupBox();
            this.lblCheio = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblVaca = new System.Windows.Forms.Label();
            this.grbTripulacao.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbEstatisticas.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Lime;
            this.lblTitulo.Location = new System.Drawing.Point(86, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(438, 43);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gerenciador de O.V.N.I";
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLigar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.ForeColor = System.Drawing.Color.Lime;
            this.btnLigar.Location = new System.Drawing.Point(12, 86);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(115, 81);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesligar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.ForeColor = System.Drawing.Color.Red;
            this.btnDesligar.Location = new System.Drawing.Point(513, 83);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(115, 81);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = false;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // grbTripulacao
            // 
            this.grbTripulacao.Controls.Add(this.btnRemoverTripulante);
            this.grbTripulacao.Controls.Add(this.btnAddTripulante);
            this.grbTripulacao.ForeColor = System.Drawing.Color.Lime;
            this.grbTripulacao.Location = new System.Drawing.Point(12, 234);
            this.grbTripulacao.Name = "grbTripulacao";
            this.grbTripulacao.Size = new System.Drawing.Size(238, 109);
            this.grbTripulacao.TabIndex = 5;
            this.grbTripulacao.TabStop = false;
            this.grbTripulacao.Text = "Tripulação:";
            // 
            // btnRemoverTripulante
            // 
            this.btnRemoverTripulante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRemoverTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverTripulante.Location = new System.Drawing.Point(7, 65);
            this.btnRemoverTripulante.Name = "btnRemoverTripulante";
            this.btnRemoverTripulante.Size = new System.Drawing.Size(225, 23);
            this.btnRemoverTripulante.TabIndex = 1;
            this.btnRemoverTripulante.Text = "Remover";
            this.btnRemoverTripulante.UseVisualStyleBackColor = true;
            this.btnRemoverTripulante.Click += new System.EventHandler(this.btnRemoverTripulante_Click);
            // 
            // btnAddTripulante
            // 
            this.btnAddTripulante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTripulante.Location = new System.Drawing.Point(7, 36);
            this.btnAddTripulante.Name = "btnAddTripulante";
            this.btnAddTripulante.Size = new System.Drawing.Size(225, 23);
            this.btnAddTripulante.TabIndex = 0;
            this.btnAddTripulante.Text = "Adicionar";
            this.btnAddTripulante.UseVisualStyleBackColor = true;
            this.btnAddTripulante.Click += new System.EventHandler(this.btnAddTripulante_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRemoverAbduzido);
            this.grbAbduzidos.Controls.Add(this.btnAddAbduzido);
            this.grbAbduzidos.ForeColor = System.Drawing.Color.Lime;
            this.grbAbduzidos.Location = new System.Drawing.Point(390, 234);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(238, 109);
            this.grbAbduzidos.TabIndex = 6;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos:";
            // 
            // btnRemoverAbduzido
            // 
            this.btnRemoverAbduzido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRemoverAbduzido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverAbduzido.Location = new System.Drawing.Point(7, 65);
            this.btnRemoverAbduzido.Name = "btnRemoverAbduzido";
            this.btnRemoverAbduzido.Size = new System.Drawing.Size(225, 23);
            this.btnRemoverAbduzido.TabIndex = 1;
            this.btnRemoverAbduzido.Text = "Desabduzir";
            this.btnRemoverAbduzido.UseVisualStyleBackColor = true;
            this.btnRemoverAbduzido.Click += new System.EventHandler(this.btnRemoverAbduzido_Click);
            // 
            // btnAddAbduzido
            // 
            this.btnAddAbduzido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddAbduzido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAbduzido.Location = new System.Drawing.Point(7, 36);
            this.btnAddAbduzido.Name = "btnAddAbduzido";
            this.btnAddAbduzido.Size = new System.Drawing.Size(225, 23);
            this.btnAddAbduzido.TabIndex = 0;
            this.btnAddAbduzido.Text = "Abduzir";
            this.btnAddAbduzido.UseVisualStyleBackColor = true;
            this.btnAddAbduzido.Click += new System.EventHandler(this.btnAddAbduzido_Click);
            // 
            // grbEstatisticas
            // 
            this.grbEstatisticas.Controls.Add(this.lblVaca);
            this.grbEstatisticas.Controls.Add(this.lblCheio);
            this.grbEstatisticas.Controls.Add(this.lblPlaneta);
            this.grbEstatisticas.Controls.Add(this.lblAbduzidos);
            this.grbEstatisticas.Controls.Add(this.lblTripulantes);
            this.grbEstatisticas.Controls.Add(this.lblStatus);
            this.grbEstatisticas.ForeColor = System.Drawing.Color.Lime;
            this.grbEstatisticas.Location = new System.Drawing.Point(171, 86);
            this.grbEstatisticas.Name = "grbEstatisticas";
            this.grbEstatisticas.Size = new System.Drawing.Size(304, 142);
            this.grbEstatisticas.TabIndex = 7;
            this.grbEstatisticas.TabStop = false;
            this.grbEstatisticas.Text = "Estatísticas:";
            // 
            // lblCheio
            // 
            this.lblCheio.AutoSize = true;
            this.lblCheio.Location = new System.Drawing.Point(103, 62);
            this.lblCheio.Name = "lblCheio";
            this.lblCheio.Size = new System.Drawing.Size(0, 13);
            this.lblCheio.TabIndex = 4;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneta.Location = new System.Drawing.Point(7, 117);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(108, 16);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta Atual: ----";
            this.lblPlaneta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.Location = new System.Drawing.Point(6, 89);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(90, 16);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos : 0 ";
            this.lblAbduzidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.Location = new System.Drawing.Point(7, 59);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(90, 16);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes: 1 ";
            this.lblTripulantes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status: Ligado";
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.cmbPlaneta);
            this.grbPlaneta.ForeColor = System.Drawing.Color.Lime;
            this.grbPlaneta.Location = new System.Drawing.Point(221, 349);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(200, 59);
            this.grbPlaneta.TabIndex = 8;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta:";
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPlaneta.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(6, 31);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(188, 21);
            this.cmbPlaneta.TabIndex = 0;
            this.cmbPlaneta.SelectionChangeCommitted += new System.EventHandler(this.cmbPlaneta_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.Lime;
            this.btnVoltar.Location = new System.Drawing.Point(529, 361);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 40);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar p/ Casa";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Location = new System.Drawing.Point(103, 91);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(0, 13);
            this.lblVaca.TabIndex = 5;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(641, 416);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbEstatisticas);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulacao);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbTripulacao.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbEstatisticas.ResumeLayout(false);
            this.grbEstatisticas.PerformLayout();
            this.grbPlaneta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.GroupBox grbTripulacao;
        private System.Windows.Forms.Button btnRemoverTripulante;
        private System.Windows.Forms.Button btnAddTripulante;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRemoverAbduzido;
        private System.Windows.Forms.Button btnAddAbduzido;
        private System.Windows.Forms.GroupBox grbEstatisticas;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Label lblCheio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblVaca;
    }
}