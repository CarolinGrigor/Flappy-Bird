using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Happy_Bird
{
    public partial class Form1 : Form
    {
        SoundPlayer player;
        int velocita = 6;
        int gravita = 5;
        int score = 0;
        bool gameover = false;
        int pos, topb;
        Random random = new Random();
        Random rb = new Random();
        Random nd = new Random();
        Button retryButton;
        Button startButton;
        DateTime startTime;
        Stopwatch stopwatch = new Stopwatch();
        double targetFrameTime = 1000.0 / 120.0; // Target tempo di frame (16.67ms per 120 FPS)
    
        public Form1()
        {
            InitializeComponent();

            retryButton = new Button();
            retryButton.Text = "RETRY";
            retryButton.Size = new Size(80, 40);
            retryButton.Location = new Point(200, 200);
            retryButton.Visible = false;
            retryButton.Enabled = false;
            retryButton.BackColor = Color.MintCream;
            retryButton.Click += retryButton_Click;
            Controls.Add(retryButton);

            startButton = new Button();
            startButton.Text = "START";
            startButton.Size = new Size(80, 40);
            startButton.Location = new Point(200, 300);
            startButton.Click += startButton_Click;
            startButton.BackColor = Color.LightCyan;
            Controls.Add(startButton);

            /*retryButton.Click rappresenta l'evento di click del pulsante startButton, 
            mentre retryButton_Click rappresenta il metodo che viene eseguito quando
            si verifica l'evento di click*/

            /*Controls.Add(retryButton) serve ad aggiungere il pulsante retryButton alla
            raccolta di controlli del form, consentendo di visualizzarlo e interagire con 
            esso all'interno dell'applicazione*/

            /*startButton.Click rappresenta l'evento di click del pulsante startButton,
            mentre startButton_Click rappresenta il metodo che viene eseguito quando
            si verifica l'evento di click*/

            /*Controls.Add(startButton) serve ad aggiungere il pulsante startButton alla
            raccolta di controlli del form, consentendo di visualizzarlo e interagire con 
            esso all'interno dell'applicazione*/

            bird.Visible = false;
            ostacoloalto.Visible = false;
            ostacolobasso.Visible = false;
            terra.Visible = false;
            scoreText.Visible = false;
            label1.Location = new Point(90, 200);
            label1.Font = new Font(label1.Font.FontFamily, 42, FontStyle.Bold);
            label1.Text = "";
            this.BackgroundImage = Happy_Bird.Properties.Resources.immaginestart;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            timer.Stop(); // Ferma il timer all'avvio del gioco

            player = new SoundPlayer(@"C:\Users\Carolin\Downloads\Music (online-audio-converter.com).wav");
            player.PlayLooping();


            this.DoubleBuffered = true;
        }

        public void timerevent(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer1.Start();
            bird.Visible = true;
            ostacoloalto.Visible = true;
            ostacolobasso.Visible = true;
            terra.Visible = true;
            scoreText.Visible = true;
            label1.Visible = false;
            this.BackgroundImage = Happy_Bird.Properties.Resources.download;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            if (!gameover)
            {
                bird.Top += gravita;
                ostacoloalto.Left -= velocita;
                ostacolobasso.Left -= velocita;

                scoreText.Text = score.ToString();
                scoreText.Text = "Score: " + score;

                pos = random.Next(47, 70);
                topb = rb.Next(112, 417);

                if (ostacolobasso.Left < -pos)
                {
                    ostacolobasso.Left = 497;
                    ostacolobasso.Top = topb;
                    score++;
                }

                if (ostacoloalto.Left < -pos)
                {
                    ostacoloalto.Left = 497;
                    ostacoloalto.Top = topb - 475;
                    score++;
                }

                if (bird.Bounds.IntersectsWith(ostacoloalto.Bounds) ||
                    bird.Bounds.IntersectsWith(ostacolobasso.Bounds) ||
                    bird.Bounds.IntersectsWith(terra.Bounds))
                {
                    Finish();
                    retryButton.Visible = true;
                    retryButton.Enabled = true;
                }

                if (score > 10)
                {
                    velocita = 10;
                }

                if (score > 20)
                {
                    velocita = 13;
                }

                if (score > 30)
                {
                    velocita = 20;
                }

                if (bird.Top < -20)
                {
                    Finish();
                    retryButton.Visible = true;
                    retryButton.Enabled = true;
                }
            }

            stopwatch.Stop();

            // Controlla il tempo trascorso per il frame e attendi se necessario per raggiungere il target frame rate
            double elapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds;
            double remainingTime = targetFrameTime - elapsedMilliseconds;

            if (remainingTime > 0)
                Thread.Sleep((int)remainingTime);

            stopwatch.Reset();
            Invalidate(); // Forza il ridisegno del form
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (!gameover && e.KeyCode == Keys.Space)
            {
                e.Handled = true; // Impedisce la riproduzione dell'audio di errore
                e.SuppressKeyPress = true; // Impedisce la propagazione del tasto Space
                bird.Visible = true;
                bird.Image = Happy_Bird.Properties.Resources.birdup_removebg_preview;
                gravita = -5;
            }
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (!gameover && e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                bird.Visible = true;
                bird.Image = Happy_Bird.Properties.Resources.birddown_removebg_preview;
                gravita = 5;
            }
        }

        private void Finish()
        {
            timer.Stop();
            bird.Visible = false;
            ostacoloalto.Visible = false;
            ostacolobasso.Visible = false;
            terra.Visible = false;
            scoreText.Visible = false;
            label1.Visible = true;
            label1.Location = new Point(130, 154);
            label1.Font = new Font(label1.Font.FontFamily, 12, FontStyle.Bold);
            label1.BackColor = Color.Transparent;
            label1.Text = "Game Over! Your score is: " + score;
            this.BackgroundImage = Happy_Bird.Properties.Resources.download;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            gameover = true;
        }

        private void restart()
        {
            gameover = false;
            bird.Location = new Point(12, 209);

            bird.Visible = false;
            ostacolobasso.Location = new Point(347, 270);
            ostacoloalto.Location = new Point(347, -205);
            ostacoloalto.Visible = false;
            ostacolobasso.Visible = false;
            terra.Visible = false;
            scoreText.Visible = false;
            label1.Location = new Point(90, 200);
            label1.Font = new Font(label1.Font.FontFamily, 42, FontStyle.Bold);
            label1.Text = "";
            this.BackgroundImage = Happy_Bird.Properties.Resources.immaginestart;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            label2.Visible = false;

            velocita = 6;
            score = 0;

            ostacoloalto.Left = 347;
            ostacolobasso.Left = 347;

            retryButton.Visible = false;
            retryButton.Enabled = false;

            startButton.Visible = true; // Mostra il pulsante di avvio
            startButton.Enabled = true; // Abilita l'interazione con il pulsante di avvio
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameover)
            {
                label2.Text = "";
            }
            else
            {
                TimeSpan elapsedTime = DateTime.Now - startTime;
                label2.Text = elapsedTime.ToString(@"hh\:mm\:ss");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            startButton.Enabled = false;
            label2.Visible = true;
            timer.Start(); 
            startTime = DateTime.Now; // Memorizza il tempo di inizio del gioco
        }
    }
}