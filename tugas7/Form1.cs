using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas7
{
    public partial class main : Form      
    {
        int nama = 1;        
        int simpanjam=0;
        int jarak_batas = 0;
        int jarak_batas1 = 0;
        int jaraks = 0;
        int jarakb = 0;
        int kontol = 0;
        /////////////////////////////
        Button cancle = new Button();
        Button ok = new Button();
        Label kuntul = new Label();
        Random rwarna = new Random();
        /////////////////////////////
        List <string> jadwal = new List<string>() { "08:30", "12:30", "14:30", "08:30", "12:30", "14:30", "08:30", "12:30", "14:30", "08:30", "12:30", "14:30", "08:30", "12:30", "14:30", "08:30", "12:30", "14:30", "08:30", "12:30", "14:30", "08:30", "12:30", "14:30", };
        List<Button> buttons = new List<Button>();
        List<Button> butkursi = new List<Button>();
        List<List<Button>>  simpankursi= new List<List<Button>>();
        public main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
            kuntul.AutoSize = true;
            kuntul.Text = "Kursi yang di pilih: ";
            kuntul.Font = new Font("Arial", 12, FontStyle.Bold);
            kuntul.Location = new Point(1000, 850);
            panel.AutoSize = true;
            ////////////////////////////
            ok.Size = new Size(140,60);
            ok.Location = new Point(500, 850);
            ok.BackColor = Color.DarkCyan;
            ok.ForeColor = Color.White;
            ok.Text = "GASKEUN";            
            ok.Click += setuju;   
            ///////////////////////////
            cancle.Size = new Size(140, 60);
            cancle.Location = new Point(800, 850);
            cancle.BackColor = Color.LightPink;
            cancle.ForeColor = Color.White;
            cancle.Text = "GAJADI";            
            cancle.Click += gsetuju;
            ///////////////////////////
            for (int i=0;i<8;i++)
            {
                PictureBox film = new PictureBox();
                film.Size = new Size(180, 300);
                film.Location = new Point(20+jarak_batas, 20);
                film.Image = gambar_film.Images[i];
                this.Controls.Add(film);               
                jarak_batas+= 200;
            }
            ///////////////////////////
            jarak_batas=0;
            for(int i=0;i<24;i++)
            {
                if (i % 3 == 0)
                {
                    jarak_batas1 += 200;
                    jarak_batas = 0;
                }
                Button pesen = new Button();
                pesen.Location = new Point(-130 + jarak_batas1, 330 + jarak_batas);
                pesen.AutoSize = true;
                pesen.Text = jadwal[i];
                pesen.BackColor = Color.LightGreen;
                pesen.Tag = i.ToString();
                this.Controls.Add(pesen);
                jarak_batas += 30;
                buttons.Add(pesen);
                pesen.Click += masok;        
            }      
            ////////////////////////////
            for (int z = 0; z < 24; z++)
            {
                nama = 1;
                jarakb = 0;
                butkursi = new List<Button>();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        Button kursi = new Button();                       
                        kursi.Size = new Size(60, 60);
                        kursi.Location = new Point(150 + jaraks, 5 + jarakb);
                        kursi.BackColor = Color.LightGreen;
                        kursi.Tag = "[kursi " + nama.ToString() + "]";
                        butkursi.Add(kursi);
                        jaraks += 70;
                        kursi.Click += nonton;
                        nama++;
                    }
                    jaraks = 0;
                    jarakb += 70;                   
                }
                for (int i = 0; i < 70; i++)
                {
                    int simpan = rwarna.Next(0, butkursi.Count);
                    butkursi[simpan].BackColor = Color.HotPink;
                    butkursi[simpan].Enabled = false;
                }
                simpankursi.Add(butkursi);
            }            
        }
        private void masok(object sender, EventArgs e)
        {
            foreach (Button x in simpankursi[simpanjam])
            {
                if (x.BackColor == Color.Yellow)
                {
                    x.BackColor = Color.LightGreen;
                }
            }
            kuntul.Text = "Kursi yang di pilih: ";

            Button but = sender as Button;
            simpanjam = Convert.ToInt32(but.Tag);
            
            foreach (Button b in buttons)
            {
                if (b.Tag == but.Tag)
                {
                    panel.Controls.Clear();
                    for (int i = 0; i<100; i++)
                    {                       
                        panel.Controls.Add(simpankursi[Convert.ToInt32(but.Tag)][i]);                       
                    }     
                }
            }
            
            this.Controls.Add(ok);
            this.Controls.Add(cancle);
            this.Controls.Add(kuntul);
        }
        private void nonton (object sender, EventArgs e)
        {
            Button memek = sender as Button;
            if(memek.BackColor == Color.LightGreen)
            {
                memek.BackColor = Color.Yellow;
            }
            else if(memek.BackColor == Color.Yellow)
            {
                memek.BackColor = Color.LightGreen;
            }
            kuntul.Text += memek.Tag + " ";
        }
        private void setuju (object sender, EventArgs e)
        {
            foreach (Button x in simpankursi[simpanjam])
            { 
                if(x.BackColor == Color.Yellow)
                {
                    x.BackColor = Color.HotPink;
                    kuntul.Text = "Kursi yang di pilih: ";
                }
            }
        }
        private void gsetuju(object sender, EventArgs e)
        {

            foreach (Button x in simpankursi[simpanjam])
            {
                x.Enabled = true;
                x.BackColor = Color.LightGreen;
                kuntul.Text = "Kursi yang di pilih: ";
            }
        }
    }
}
