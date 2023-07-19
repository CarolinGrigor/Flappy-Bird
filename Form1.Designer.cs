namespace Happy_Bird
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ostacolobasso = new System.Windows.Forms.PictureBox();
            this.ostacoloalto = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.terra = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.ostacolobasso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacoloalto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terra)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(25, 58);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 20);
            this.scoreText.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timerevent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ostacolobasso
            // 
            this.ostacolobasso.BackColor = System.Drawing.Color.Transparent;
            this.ostacolobasso.Image = ((System.Drawing.Image)(resources.GetObject("ostacolobasso.Image")));
            this.ostacolobasso.Location = new System.Drawing.Point(347, 270);
            this.ostacolobasso.Name = "ostacolobasso";
            this.ostacolobasso.Size = new System.Drawing.Size(66, 386);
            this.ostacolobasso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ostacolobasso.TabIndex = 2;
            this.ostacolobasso.TabStop = false;
            // 
            // ostacoloalto
            // 
            this.ostacoloalto.BackColor = System.Drawing.Color.Transparent;
            this.ostacoloalto.Image = ((System.Drawing.Image)(resources.GetObject("ostacoloalto.Image")));
            this.ostacoloalto.Location = new System.Drawing.Point(347, -205);
            this.ostacoloalto.Name = "ostacoloalto";
            this.ostacoloalto.Size = new System.Drawing.Size(66, 386);
            this.ostacoloalto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ostacoloalto.TabIndex = 1;
            this.ostacoloalto.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::Happy_Bird.Properties.Resources.birdup_removebg_preview;
            this.bird.Location = new System.Drawing.Point(12, 209);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(46, 38);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // terra
            // 
            this.terra.Image = ((System.Drawing.Image)(resources.GetObject("terra.Image")));
            this.terra.Location = new System.Drawing.Point(-1, 452);
            this.terra.Name = "terra";
            this.terra.Size = new System.Drawing.Size(1684, 50);
            this.terra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.terra.TabIndex = 3;
            this.terra.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 501);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Happy_Bird.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 501);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.terra);
            this.Controls.Add(this.ostacolobasso);
            this.Controls.Add(this.ostacoloalto);
            this.Controls.Add(this.bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.ostacolobasso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostacoloalto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox ostacoloalto;
        private System.Windows.Forms.PictureBox ostacolobasso;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox terra;
        private System.Windows.Forms.Splitter splitter1;
    }
}

