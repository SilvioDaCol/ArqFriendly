namespace gameLearning
{
    partial class telaLogadoAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogadoAluno));
            this.gameLearningLogoMenor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameLearningLogoMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLearningLogoMenor
            // 
            this.gameLearningLogoMenor.BackColor = System.Drawing.Color.Transparent;
            this.gameLearningLogoMenor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameLearningLogoMenor.BackgroundImage")));
            this.gameLearningLogoMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameLearningLogoMenor.Location = new System.Drawing.Point(30, 30);
            this.gameLearningLogoMenor.Name = "gameLearningLogoMenor";
            this.gameLearningLogoMenor.Size = new System.Drawing.Size(120, 60);
            this.gameLearningLogoMenor.TabIndex = 3;
            this.gameLearningLogoMenor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::gameLearning.Properties.Resources.btnOla;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(510, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 80);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // telaLogadoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameLearning.Properties.Resources.mainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gameLearningLogoMenor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "telaLogadoAluno";
            this.Text = "telaLogadoAluno";
            ((System.ComponentModel.ISupportInitialize)(this.gameLearningLogoMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameLearningLogoMenor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}