namespace GerenciadorDeOvni
{
    partial class Inicializador
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
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.txbTripulantes = new System.Windows.Forms.NumericUpDown();
            this.txbAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.lblPlanetadeOrigem = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.pibNave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txbTripulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAbduzidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibNave)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(82, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(438, 43);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciador de O.V.N.I";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.Location = new System.Drawing.Point(25, 104);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(211, 21);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Capacidade Tripulantes: ";
            this.lblTripulantes.Click += new System.EventHandler(this.lblTripulantes_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.Location = new System.Drawing.Point(24, 147);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(212, 21);
            this.lblAbduzidos.TabIndex = 3;
            this.lblAbduzidos.Text = "Capacidade Abduzidos:  ";
            // 
            // txbTripulantes
            // 
            this.txbTripulantes.Location = new System.Drawing.Point(242, 104);
            this.txbTripulantes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txbTripulantes.Name = "txbTripulantes";
            this.txbTripulantes.Size = new System.Drawing.Size(155, 20);
            this.txbTripulantes.TabIndex = 4;
            this.txbTripulantes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txbAbduzidos
            // 
            this.txbAbduzidos.Location = new System.Drawing.Point(242, 147);
            this.txbAbduzidos.Name = "txbAbduzidos";
            this.txbAbduzidos.Size = new System.Drawing.Size(155, 20);
            this.txbAbduzidos.TabIndex = 5;
            // 
            // lblPlanetadeOrigem
            // 
            this.lblPlanetadeOrigem.AutoSize = true;
            this.lblPlanetadeOrigem.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetadeOrigem.Location = new System.Drawing.Point(57, 191);
            this.lblPlanetadeOrigem.Name = "lblPlanetadeOrigem";
            this.lblPlanetadeOrigem.Size = new System.Drawing.Size(168, 21);
            this.lblPlanetadeOrigem.TabIndex = 6;
            this.lblPlanetadeOrigem.Text = "Planeta de Origem:";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(242, 191);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(155, 21);
            this.cmbPlanetas.TabIndex = 7;
            // 
            // btnCriar
            // 
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(40, 277);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(328, 54);
            this.btnCriar.TabIndex = 8;
            this.btnCriar.Text = "Criar Nave";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // pibNave
            // 
            this.pibNave.Image = global::GerenciadorDeOvni.Properties.Resources.abduction;
            this.pibNave.Location = new System.Drawing.Point(415, 55);
            this.pibNave.Name = "pibNave";
            this.pibNave.Size = new System.Drawing.Size(199, 276);
            this.pibNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibNave.TabIndex = 0;
            this.pibNave.TabStop = false;
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 344);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblPlanetadeOrigem);
            this.Controls.Add(this.txbAbduzidos);
            this.Controls.Add(this.txbTripulantes);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibNave);
            this.Name = "Inicializador";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.txbTripulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAbduzidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibNave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibNave;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.NumericUpDown txbTripulantes;
        private System.Windows.Forms.NumericUpDown txbAbduzidos;
        private System.Windows.Forms.Label lblPlanetadeOrigem;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnCriar;
    }
}