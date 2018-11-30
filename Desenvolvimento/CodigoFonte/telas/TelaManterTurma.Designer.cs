namespace gameLearning
{
    partial class telaManterTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaManterTurma));
            this.gameLogoMenor = new System.Windows.Forms.PictureBox();
            this.usuarioLogado = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnListaAlunos = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvTurmasCriadas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogoMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTurmasCriadas)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLogoMenor
            // 
            this.gameLogoMenor.BackColor = System.Drawing.Color.Transparent;
            this.gameLogoMenor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameLogoMenor.BackgroundImage")));
            this.gameLogoMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameLogoMenor.Location = new System.Drawing.Point(29, 30);
            this.gameLogoMenor.Margin = new System.Windows.Forms.Padding(4);
            this.gameLogoMenor.MaximumSize = new System.Drawing.Size(120, 60);
            this.gameLogoMenor.Name = "gameLogoMenor";
            this.gameLogoMenor.Size = new System.Drawing.Size(120, 60);
            this.gameLogoMenor.TabIndex = 2;
            this.gameLogoMenor.TabStop = false;
            // 
            // usuarioLogado
            // 
            this.usuarioLogado.AutoSize = true;
            this.usuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.usuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLogado.ForeColor = System.Drawing.Color.White;
            this.usuarioLogado.Location = new System.Drawing.Point(293, 46);
            this.usuarioLogado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuarioLogado.Name = "usuarioLogado";
            this.usuarioLogado.Size = new System.Drawing.Size(642, 58);
            this.usuarioLogado.TabIndex = 3;
            this.usuarioLogado.Text = "NOME USUARIO LOGADO";
            this.usuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriar.BackgroundImage = global::gameLearning.Properties.Resources.btnCriar;
            this.btnCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriar.Location = new System.Drawing.Point(185, 484);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCriar.MaximumSize = new System.Drawing.Size(180, 80);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(180, 80);
            this.btnCriar.TabIndex = 15;
            this.btnCriar.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = global::gameLearning.Properties.Resources.btnExcluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(396, 484);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.MaximumSize = new System.Drawing.Size(180, 80);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(180, 80);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.TabStop = false;
            // 
            // btnListaAlunos
            // 
            this.btnListaAlunos.BackColor = System.Drawing.Color.Transparent;
            this.btnListaAlunos.BackgroundImage = global::gameLearning.Properties.Resources.btnListaAlunos;
            this.btnListaAlunos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListaAlunos.Location = new System.Drawing.Point(604, 484);
            this.btnListaAlunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListaAlunos.MaximumSize = new System.Drawing.Size(180, 80);
            this.btnListaAlunos.Name = "btnListaAlunos";
            this.btnListaAlunos.Size = new System.Drawing.Size(180, 80);
            this.btnListaAlunos.TabIndex = 17;
            this.btnListaAlunos.TabStop = false;
            this.btnListaAlunos.Click += new System.EventHandler(this.btnListaAlunos_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::gameLearning.Properties.Resources.btnCancelar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(816, 484);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.MaximumSize = new System.Drawing.Size(180, 80);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(180, 80);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(359, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 58);
            this.label3.TabIndex = 19;
            this.label3.Text = "TURMAS CRIADAS";
            // 
            // gvTurmasCriadas
            // 
            this.gvTurmasCriadas.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.gvTurmasCriadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTurmasCriadas.Location = new System.Drawing.Point(304, 277);
            this.gvTurmasCriadas.Margin = new System.Windows.Forms.Padding(4);
            this.gvTurmasCriadas.Name = "gvTurmasCriadas";
            this.gvTurmasCriadas.Size = new System.Drawing.Size(615, 142);
            this.gvTurmasCriadas.TabIndex = 20;
            // 
            // telaManterTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameLearning.Properties.Resources.mainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 624);
            this.Controls.Add(this.gvTurmasCriadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnListaAlunos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.usuarioLogado);
            this.Controls.Add(this.gameLogoMenor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1198, 671);
            this.MinimumSize = new System.Drawing.Size(1198, 671);
            this.Name = "telaManterTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTER TURMAS";
            this.Load += new System.EventHandler(this.telaManterTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameLogoMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListaAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTurmasCriadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameLogoMenor;
        private System.Windows.Forms.Label usuarioLogado;
        private System.Windows.Forms.PictureBox btnCriar;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnListaAlunos;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvTurmasCriadas;
    }
}