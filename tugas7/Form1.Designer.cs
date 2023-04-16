namespace tugas7
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.gambar_film = new System.Windows.Forms.ImageList(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gambar_film
            // 
            this.gambar_film.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("gambar_film.ImageStream")));
            this.gambar_film.TransparentColor = System.Drawing.Color.Transparent;
            this.gambar_film.Images.SetKeyName(0, "images (7).jpg");
            this.gambar_film.Images.SetKeyName(1, "1650826663.jpg");
            this.gambar_film.Images.SetKeyName(2, "poster-film-yang-tayang-di-bioskop-april-2023-9.jpeg");
            this.gambar_film.Images.SetKeyName(3, "Screen_Shot_2021_10_20_at_12_13_24.png");
            this.gambar_film.Images.SetKeyName(4, "sedeng_92whatsapp-image-2022-11-20-at-09.57.16.jpeg");
            this.gambar_film.Images.SetKeyName(5, "0b7f50354ec4ef04f5cd50abc512232a.jpg");
            this.gambar_film.Images.SetKeyName(6, "last-night-in-soho.jpeg");
            this.gambar_film.Images.SetKeyName(7, "310890273_129523326532590_6791100282573647555_n.webp.jpg");
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(12, 564);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1268, 368);
            this.panel.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1292, 637);
            this.Controls.Add(this.panel);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList gambar_film;
        private System.Windows.Forms.Panel panel;
    }
}

