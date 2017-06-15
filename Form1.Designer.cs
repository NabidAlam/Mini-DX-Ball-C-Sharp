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
            this.ball = new System.Windows.Forms.PictureBox();
            this.slider = new System.Windows.Forms.PictureBox();
            this.vert = new System.Windows.Forms.Timer(this.components);
            this.horz = new System.Windows.Forms.Timer(this.components);
            this.key_watch = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Enabled = false;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(360, 12);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(65, 69);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // slider
            // 
            this.slider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.slider.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.slider.Enabled = false;
            this.slider.Location = new System.Drawing.Point(271, 534);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(181, 16);
            this.slider.TabIndex = 1;
            this.slider.TabStop = false;
            // 
            // vert
            // 
            this.vert.Enabled = true;
            this.vert.Interval = 1;
            this.vert.Tick += new System.EventHandler(this.vert_Tick);
            // 
            // horz
            // 
            this.horz.Enabled = true;
            this.horz.Interval = 1;
            this.horz.Tick += new System.EventHandler(this.horz_Tick);
            // 
            // key_watch
            // 
            this.key_watch.Enabled = true;
            this.key_watch.Tick += new System.EventHandler(this.key_watch_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(709, 551);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.ball);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Timer horz;
        private System.Windows.Forms.Timer key_watch;
        private System.Windows.Forms.Timer vert;
    }
}

