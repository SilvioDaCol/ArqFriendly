﻿namespace gameLearning
{
    partial class telaSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaSobre));
            System.Windows.Forms.PictureBox pictureBox2;
            this.gameLogoMenor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogoMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLogoMenor
            // 
            this.gameLogoMenor.BackColor = System.Drawing.Color.Transparent;
            this.gameLogoMenor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameLogoMenor.BackgroundImage")));
            this.gameLogoMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gameLogoMenor.Location = new System.Drawing.Point(30, 29);
            this.gameLogoMenor.Margin = new System.Windows.Forms.Padding(4);
            this.gameLogoMenor.Name = "gameLogoMenor";
            this.gameLogoMenor.Size = new System.Drawing.Size(159, 77);
            this.gameLogoMenor.TabIndex = 1;
            this.gameLogoMenor.TabStop = false;
            this.gameLogoMenor.Click += new System.EventHandler(this.gameLogoMenor_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(175, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 344);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastro.BackgroundImage")));
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastro.Location = new System.Drawing.Point(487, -3);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(237, 170);
            this.btnCadastro.TabIndex = 5;
            this.btnCadastro.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Location = new System.Drawing.Point(487, 453);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new System.Windows.Forms.Padding(0, 200, 0, 0);
            pictureBox2.Size = new System.Drawing.Size(237, 147);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // telaSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameLogoMenor);
            this.Name = "telaSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaSobre";
            ((System.ComponentModel.ISupportInitialize)(this.gameLogoMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameLogoMenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCadastro;
    }
}