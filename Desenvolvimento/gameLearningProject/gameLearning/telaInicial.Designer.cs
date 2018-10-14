namespace gameLearning
{
    partial class telaInicial
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
            System.Windows.Forms.PictureBox btnLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicial));
            this.logoMaior = new System.Windows.Forms.PictureBox();
            this.btnCadastro = new System.Windows.Forms.PictureBox();
            this.btnSobre = new System.Windows.Forms.PictureBox();
            btnLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoMaior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSobre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            btnLogin.BackColor = System.Drawing.Color.Transparent;
            btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnLogin.Location = new System.Drawing.Point(86, 420);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(300, 200);
            btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            btnLogin.TabIndex = 0;
            btnLogin.TabStop = false;
            
            // 
            // logoMaior
            // 
            this.logoMaior.BackColor = System.Drawing.Color.Transparent;
            this.logoMaior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoMaior.BackgroundImage")));
            this.logoMaior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoMaior.Location = new System.Drawing.Point(86, 53);
            this.logoMaior.Name = "logoMaior";
            this.logoMaior.Size = new System.Drawing.Size(500, 300);
            this.logoMaior.TabIndex = 2;
            this.logoMaior.TabStop = false;
            this.logoMaior.Click += new System.EventHandler(this.logoMaior_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastro.BackgroundImage")));
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastro.Location = new System.Drawing.Point(544, 420);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(300, 200);
            this.btnCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.TabStop = false;
            // 
            // btnSobre
            // 
            this.btnSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSobre.BackgroundImage")));
            this.btnSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSobre.Location = new System.Drawing.Point(989, 420);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(300, 200);
            this.btnSobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSobre.TabIndex = 4;
            this.btnSobre.TabStop = false;
            // 
            // telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.logoMaior);
            this.Controls.Add(btnLogin);
            this.Name = "telaInicial";
            this.Text = "GAME LEARNING - BEM VINDO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoMaior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSobre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoMaior;
        private System.Windows.Forms.PictureBox btnCadastro;
        private System.Windows.Forms.PictureBox btnSobre;
    }
}

