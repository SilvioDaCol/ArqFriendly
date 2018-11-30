namespace gameLearning
{
    partial class telaPontuacao
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
            this.lbExercicio = new System.Windows.Forms.Label();
            this.gvPontuacaoPorAluno = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvPontuacaoPorAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbExercicio
            // 
            this.lbExercicio.AutoSize = true;
            this.lbExercicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbExercicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbExercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbExercicio.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbExercicio.Location = new System.Drawing.Point(275, 9);
            this.lbExercicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExercicio.Name = "lbExercicio";
            this.lbExercicio.Size = new System.Drawing.Size(372, 46);
            this.lbExercicio.TabIndex = 24;
            this.lbExercicio.Text = "EXERCICIO TAL...";
            // 
            // gvPontuacaoPorAluno
            // 
            this.gvPontuacaoPorAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPontuacaoPorAluno.Location = new System.Drawing.Point(235, 85);
            this.gvPontuacaoPorAluno.Name = "gvPontuacaoPorAluno";
            this.gvPontuacaoPorAluno.Size = new System.Drawing.Size(423, 323);
            this.gvPontuacaoPorAluno.TabIndex = 23;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::gameLearning.Properties.Resources.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(384, 427);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.MaximumSize = new System.Drawing.Size(135, 65);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 65);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // telaPontuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameLearning.Properties.Resources.mainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 517);
            this.Controls.Add(this.lbExercicio);
            this.Controls.Add(this.gvPontuacaoPorAluno);
            this.Controls.Add(this.btnVoltar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(904, 556);
            this.MinimumSize = new System.Drawing.Size(904, 556);
            this.Name = "telaPontuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaPontuacao";
            this.Load += new System.EventHandler(this.telaPontuacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPontuacaoPorAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExercicio;
        private System.Windows.Forms.DataGridView gvPontuacaoPorAluno;
        private System.Windows.Forms.PictureBox btnVoltar;
    }
}