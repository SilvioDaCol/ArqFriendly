﻿namespace gameLearning
{
    partial class telaManterExercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaManterExercicios));
            this.gvAtividadesProfessor = new System.Windows.Forms.DataGridView();
            this.lbNOME = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameLogoMenor = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnPontuacaoPorAluno = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.PictureBox();
            this.btnCriar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvAtividadesProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogoMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPontuacaoPorAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriar)).BeginInit();
            this.SuspendLayout();
            // 
            // gvAtividadesProfessor
            // 
            this.gvAtividadesProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAtividadesProfessor.Location = new System.Drawing.Point(125, 227);
            this.gvAtividadesProfessor.Name = "gvAtividadesProfessor";
            this.gvAtividadesProfessor.Size = new System.Drawing.Size(652, 115);
            this.gvAtividadesProfessor.TabIndex = 24;
            // 
            // lbNOME
            // 
            this.lbNOME.AutoSize = true;
            this.lbNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNOME.Location = new System.Drawing.Point(162, 42);
            this.lbNOME.Name = "lbNOME";
            this.lbNOME.Size = new System.Drawing.Size(331, 31);
            this.lbNOME.TabIndex = 22;
            this.lbNOME.Text = "Nome do usuario logado...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(234, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 46);
            this.label3.TabIndex = 23;
            this.label3.Text = "ATIVIDADES CRIADAS";
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
            this.gameLogoMenor.TabIndex = 21;
            this.gameLogoMenor.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::gameLearning.Properties.Resources.btnCancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(707, 400);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 65);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPontuacaoPorAluno
            // 
            this.btnPontuacaoPorAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnPontuacaoPorAluno.BackgroundImage = global::gameLearning.Properties.Resources.btnEnviar;
            this.btnPontuacaoPorAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPontuacaoPorAluno.Location = new System.Drawing.Point(548, 400);
            this.btnPontuacaoPorAluno.Margin = new System.Windows.Forms.Padding(2);
            this.btnPontuacaoPorAluno.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnPontuacaoPorAluno.Name = "btnPontuacaoPorAluno";
            this.btnPontuacaoPorAluno.Size = new System.Drawing.Size(135, 65);
            this.btnPontuacaoPorAluno.TabIndex = 27;
            this.btnPontuacaoPorAluno.TabStop = false;
            this.btnPontuacaoPorAluno.Click += new System.EventHandler(this.btnPontuacaoPorAluno_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = global::gameLearning.Properties.Resources.btnJogar;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(392, 400);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 65);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImage = global::gameLearning.Properties.Resources.btnJogar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(234, 400);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(135, 65);
            this.btnAlterar.TabIndex = 25;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriar.BackgroundImage = global::gameLearning.Properties.Resources.btnJogar;
            this.btnCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriar.Location = new System.Drawing.Point(79, 400);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriar.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(135, 65);
            this.btnCriar.TabIndex = 29;
            this.btnCriar.TabStop = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // telaManterExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameLearning.Properties.Resources.mainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 517);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPontuacaoPorAluno);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gvAtividadesProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNOME);
            this.Controls.Add(this.gameLogoMenor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(904, 556);
            this.MinimumSize = new System.Drawing.Size(904, 556);
            this.Name = "telaManterExercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaManterExercicio";
            this.Load += new System.EventHandler(this.telaManterExercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAtividadesProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogoMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPontuacaoPorAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvAtividadesProfessor;
        private System.Windows.Forms.Label lbNOME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox gameLogoMenor;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnPontuacaoPorAluno;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnAlterar;
        private System.Windows.Forms.PictureBox btnCriar;
    }
}