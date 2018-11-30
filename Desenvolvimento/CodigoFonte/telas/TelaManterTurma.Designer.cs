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
            System.Windows.Forms.PictureBox btnCancelar;
            System.Windows.Forms.PictureBox btnEnviar;
            this.gameLogoMenor = new System.Windows.Forms.PictureBox();
            this.usuarioLogado = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnListaAlunos = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvTurmasCriadas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.campoCurso = new System.Windows.Forms.ComboBox();
            this.campoSemestre = new System.Windows.Forms.ComboBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelSemestre = new System.Windows.Forms.Label();
            this.gpbDadosTurma = new System.Windows.Forms.GroupBox();
            btnCancelar = new System.Windows.Forms.PictureBox();
            btnEnviar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogoMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTurmasCriadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnEnviar)).BeginInit();
            this.gpbDadosTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameLogoMenor
            // 
            this.gameLogoMenor.BackColor = System.Drawing.Color.Transparent;
            this.gameLogoMenor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameLogoMenor.BackgroundImage")));
            this.gameLogoMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameLogoMenor.Location = new System.Drawing.Point(22, 24);
            this.gameLogoMenor.MaximumSize = new System.Drawing.Size(90, 49);
            this.gameLogoMenor.Name = "gameLogoMenor";
            this.gameLogoMenor.Size = new System.Drawing.Size(90, 49);
            this.gameLogoMenor.TabIndex = 2;
            this.gameLogoMenor.TabStop = false;
            // 
            // usuarioLogado
            // 
            this.usuarioLogado.AutoSize = true;
            this.usuarioLogado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLogado.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.usuarioLogado.Location = new System.Drawing.Point(220, 37);
            this.usuarioLogado.Name = "usuarioLogado";
            this.usuarioLogado.Size = new System.Drawing.Size(515, 46);
            this.usuarioLogado.TabIndex = 3;
            this.usuarioLogado.Text = "NOME USUARIO LOGADO";
            this.usuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriar.BackgroundImage = global::gameLearning.Properties.Resources.btnCriar;
            this.btnCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriar.Location = new System.Drawing.Point(139, 393);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriar.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(135, 65);
            this.btnCriar.TabIndex = 15;
            this.btnCriar.TabStop = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = global::gameLearning.Properties.Resources.btnExcluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(297, 393);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 65);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnListaAlunos
            // 
            this.btnListaAlunos.BackColor = System.Drawing.Color.Transparent;
            this.btnListaAlunos.BackgroundImage = global::gameLearning.Properties.Resources.btnListaAlunos;
            this.btnListaAlunos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListaAlunos.Location = new System.Drawing.Point(453, 393);
            this.btnListaAlunos.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaAlunos.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnListaAlunos.Name = "btnListaAlunos";
            this.btnListaAlunos.Size = new System.Drawing.Size(135, 65);
            this.btnListaAlunos.TabIndex = 17;
            this.btnListaAlunos.TabStop = false;
            this.btnListaAlunos.Click += new System.EventHandler(this.btnListaAlunos_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::gameLearning.Properties.Resources.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(612, 393);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 65);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(269, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "TURMAS CRIADAS";
            // 
            // gvTurmasCriadas
            // 
            this.gvTurmasCriadas.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.gvTurmasCriadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTurmasCriadas.Location = new System.Drawing.Point(228, 225);
            this.gvTurmasCriadas.Name = "gvTurmasCriadas";
            this.gvTurmasCriadas.Size = new System.Drawing.Size(461, 115);
            this.gvTurmasCriadas.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(114, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "CRIAR NOVA TURMA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoCurso
            // 
            this.campoCurso.BackColor = System.Drawing.Color.PaleGreen;
            this.campoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCurso.FormattingEnabled = true;
            this.campoCurso.Items.AddRange(new object[] {
            "TADS",
            "ELETR",
            "MEC",
            "ENG",
            "MED"});
            this.campoCurso.Location = new System.Drawing.Point(248, 201);
            this.campoCurso.Name = "campoCurso";
            this.campoCurso.Size = new System.Drawing.Size(220, 33);
            this.campoCurso.TabIndex = 32;
            // 
            // campoSemestre
            // 
            this.campoSemestre.BackColor = System.Drawing.Color.PaleGreen;
            this.campoSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSemestre.FormattingEnabled = true;
            this.campoSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.campoSemestre.Location = new System.Drawing.Point(248, 241);
            this.campoSemestre.Name = "campoSemestre";
            this.campoSemestre.Size = new System.Drawing.Size(220, 33);
            this.campoSemestre.TabIndex = 33;
            // 
            // labelCurso
            // 
            this.labelCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurso.AutoSize = true;
            this.labelCurso.BackColor = System.Drawing.Color.Transparent;
            this.labelCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurso.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelCurso.Location = new System.Drawing.Point(145, 206);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(97, 26);
            this.labelCurso.TabIndex = 34;
            this.labelCurso.Text = "CURSO";
            // 
            // labelSemestre
            // 
            this.labelSemestre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.BackColor = System.Drawing.Color.Transparent;
            this.labelSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemestre.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelSemestre.Location = new System.Drawing.Point(101, 244);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(141, 26);
            this.labelSemestre.TabIndex = 35;
            this.labelSemestre.Text = "SEMESTRE";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnCancelar.BackColor = System.Drawing.Color.Transparent;
            btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCancelar.Location = new System.Drawing.Point(368, 354);
            btnCancelar.MaximumSize = new System.Drawing.Size(135, 65);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new System.Windows.Forms.Padding(0, 162, 0, 0);
            btnCancelar.Size = new System.Drawing.Size(135, 65);
            btnCancelar.TabIndex = 36;
            btnCancelar.TabStop = false;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnEnviar.BackColor = System.Drawing.Color.Transparent;
            btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEnviar.Location = new System.Drawing.Point(131, 354);
            btnEnviar.MaximumSize = new System.Drawing.Size(135, 65);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Padding = new System.Windows.Forms.Padding(0, 162, 0, 0);
            btnEnviar.Size = new System.Drawing.Size(135, 65);
            btnEnviar.TabIndex = 37;
            btnEnviar.TabStop = false;
            btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // gpbDadosTurma
            // 
            this.gpbDadosTurma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbDadosTurma.BackgroundImage = global::gameLearning.Properties.Resources.mainBack;
            this.gpbDadosTurma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbDadosTurma.Controls.Add(btnEnviar);
            this.gpbDadosTurma.Controls.Add(btnCancelar);
            this.gpbDadosTurma.Controls.Add(this.labelSemestre);
            this.gpbDadosTurma.Controls.Add(this.labelCurso);
            this.gpbDadosTurma.Controls.Add(this.campoSemestre);
            this.gpbDadosTurma.Controls.Add(this.campoCurso);
            this.gpbDadosTurma.Controls.Add(this.label1);
            this.gpbDadosTurma.Location = new System.Drawing.Point(129, 24);
            this.gpbDadosTurma.Name = "gpbDadosTurma";
            this.gpbDadosTurma.Size = new System.Drawing.Size(643, 468);
            this.gpbDadosTurma.TabIndex = 21;
            this.gpbDadosTurma.TabStop = false;
            // 
            // telaManterTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameLearning.Properties.Resources.mainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 514);
            this.Controls.Add(this.gpbDadosTurma);
            this.Controls.Add(this.gvTurmasCriadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnListaAlunos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.usuarioLogado);
            this.Controls.Add(this.gameLogoMenor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(902, 553);
            this.MinimumSize = new System.Drawing.Size(902, 553);
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
            ((System.ComponentModel.ISupportInitialize)(btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnEnviar)).EndInit();
            this.gpbDadosTurma.ResumeLayout(false);
            this.gpbDadosTurma.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox campoCurso;
        private System.Windows.Forms.ComboBox campoSemestre;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelSemestre;
        private System.Windows.Forms.GroupBox gpbDadosTurma;
    }
}