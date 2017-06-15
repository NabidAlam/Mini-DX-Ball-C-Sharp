namespace Mini_DX_Ball_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Timer vert;
            this.ball = new System.Windows.Forms.PictureBox();
            this.slide = new System.Windows.Forms.PictureBox();
            this.horz = new System.Windows.Forms.Timer(this.components);
            vert = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(360, 107);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(91, 88);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // slide
            // 
            this.slide.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.slide.Location = new System.Drawing.Point(360, 550);
            this.slide.Name = "slide";
            this.slide.Size = new System.Drawing.Size(181, 16);
            this.slide.TabIndex = 1;
            this.slide.TabStop = false;
            // 
            // vert
            // 
            vert.Tick += new System.EventHandler(this.vert_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(886, 567);
            this.Controls.Add(this.slide);
            this.Controls.Add(this.ball);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox slide;
        private System.Windows.Forms.Timer horz;
    }
}

