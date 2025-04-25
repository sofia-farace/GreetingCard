using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer soundPlayer;

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pinkpen = new Pen(Color.PaleVioletRed);
            Brush pinkBrush = new SolidBrush(Color.PaleVioletRed);
            Font drawFont = new Font("Edwardian Script ITC", 50, FontStyle.Regular);
            g.Clear(Color.LightPink);

            // draws pink heart
            g.TranslateTransform(180, 180);
            g.RotateTransform(45);
            g.FillRectangle(pinkBrush, 0, 0, 100, 100);
            g.FillEllipse(pinkBrush, 0, -50, 100, 100);
            g.FillEllipse(pinkBrush, -50, 0, 100, 100);

            //draws borders and text
            g.ResetTransform();
            g.DrawLine(pinkpen, 0, 30, 380, 30);
            g.DrawLine(pinkpen, 0, 430, 380, 430);
            g.DrawString("Happy", drawFont, pinkBrush, 100, 60);
            g.DrawString("Valentine's Day", drawFont, pinkBrush, 5, 330);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //plays music
            soundPlayer = new SoundPlayer(Properties.Resources.musicbox);
            soundPlayer.Play();

            Graphics g = this.CreateGraphics();
            Pen pinkPen = new Pen(Color.PaleVioletRed);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush lightPinkBrush = new SolidBrush(Color.LightPink);
            Brush pinkBrush = new SolidBrush(Color.PaleVioletRed);
            Brush hotPinkBrush = new SolidBrush(Color.HotPink);
            Brush deepPinkBrush = new SolidBrush(Color.DeepPink);

            g.Clear(Color.LightPink);

            // draws a pattern of different colored hearts that move horizontally

            int x = 0;

            for (x = 0; x < 500; x += 25)
            {
                g.FillRectangle(pinkBrush, x, 200, 100, 100);
                g.FillEllipse(pinkBrush, x, 150, 100, 100);
                g.FillEllipse(pinkBrush, x - 50, 200, 100, 100);

                g.FillRectangle(deepPinkBrush, x - 200, 200, 100, 100);
                g.FillEllipse(deepPinkBrush, x - 200, 150, 100, 100);
                g.FillEllipse(deepPinkBrush, x - 250, 200, 100, 100);

                g.FillRectangle(hotPinkBrush, x - 400, 200, 100, 100);
                g.FillEllipse(hotPinkBrush, x - 400, 150, 100, 100);
                g.FillEllipse(hotPinkBrush, x - 450, 200, 100, 100);

                g.FillRectangle(hotPinkBrush, x, 20, 100, 100);
                g.FillEllipse(hotPinkBrush, x, -30, 100, 100);
                g.FillEllipse(hotPinkBrush, x - 50, 20, 100, 100);

                g.FillRectangle(pinkBrush, x - 200, 20, 100, 100);
                g.FillEllipse(pinkBrush, x - 200, -30, 100, 100);
                g.FillEllipse(pinkBrush, x - 250, 20, 100, 100);

                g.FillRectangle(deepPinkBrush, x - 400, 20, 100, 100);
                g.FillEllipse(deepPinkBrush, x - 400, -30, 100, 100);
                g.FillEllipse(deepPinkBrush, x - 450, 20, 100, 100);

                g.FillRectangle(deepPinkBrush, x, 400, 100, 100);
                g.FillEllipse(deepPinkBrush, x, 350, 100, 100);
                g.FillEllipse(deepPinkBrush, x - 50, 400, 100, 100);

                g.FillRectangle(hotPinkBrush, x - 200, 400, 100, 100);
                g.FillEllipse(hotPinkBrush, x - 200, 350, 100, 100);
                g.FillEllipse(hotPinkBrush, x - 250, 400, 100, 100);

                g.FillRectangle(pinkBrush, x - 400, 400, 100, 100);
                g.FillEllipse(pinkBrush, x - 400, 350, 100, 100);
                g.FillEllipse(pinkBrush, x - 450, 400, 100, 100);

                Thread.Sleep(100);

                g.Clear(Color.LightPink);
            }

            // creates text that grows in font

            int i;

            for (i = 1; i <= 55; i += 5)
            {
                Font drawFont = new Font("Edwardian Script ITC", i, FontStyle.Regular);
                g.DrawString("  Will you \n    be my \nValentine?", drawFont, pinkBrush, 45, 100);
                Thread.Sleep(100);
                g.Clear(Color.LightPink);
            }

            yesButton.Visible = true;
            noButton.Visible = true;

            Font drawFont2 = new Font("Edwardian Script ITC", 55, FontStyle.Regular);
            g.DrawString("  Will you \n     be my \nValentine?", drawFont2, pinkBrush, 45, 100);
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            int x = 1;

            //plays shooting star sound 

            soundPlayer = new SoundPlayer(Properties.Resources.sparkle);
            soundPlayer.Play();


            Graphics g = this.CreateGraphics();
            Pen pinkPen = new Pen(Color.PaleVioletRed);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush lightPinkBrush = new SolidBrush(Color.LightPink);
            Brush pinkBrush = new SolidBrush(Color.PaleVioletRed);
            Brush hotPinkBrush = new SolidBrush(Color.HotPink);
            Brush deepPinkBrush = new SolidBrush(Color.DeepPink);

            yesButton.Visible = false;
            noButton.Visible = false;
            g.Clear(Color.LightPink);
            g.TranslateTransform(180, 180);
            g.RotateTransform(45);

            // draws a heart that changes colors

            while (x > 0)
            {
                g.FillRectangle(pinkBrush, 0, 0, 100, 100);
                g.FillEllipse(pinkBrush, 0, -50, 100, 100);
                g.FillEllipse(pinkBrush, -50, 0, 100, 100);

                Thread.Sleep(100);

                g.FillRectangle(hotPinkBrush, 0, 0, 100, 100);
                g.FillEllipse(hotPinkBrush, 0, -50, 100, 100);
                g.FillEllipse(hotPinkBrush, -50, 0, 100, 100);

                Thread.Sleep(100);

                g.FillRectangle(deepPinkBrush, 0, 0, 100, 100);
                g.FillEllipse(deepPinkBrush, 0, -50, 100, 100);
                g.FillEllipse(deepPinkBrush, -50, 0, 100, 100);

                Thread.Sleep(100);
            }
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            // plays sad sound

            soundPlayer = new SoundPlayer(Properties.Resources.sad);
            soundPlayer.Play();

            //draws a sad face

            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 10);
            Brush blackBrush = new SolidBrush(Color.Black);

            yesButton.Visible = false;
            noButton.Visible = false;
            g.Clear(Color.LightPink);

            g.FillEllipse(blackBrush, 150, 200, 10, 20);
            g.FillEllipse(blackBrush, 220, 200, 10, 20);

            g.DrawArc(blackPen, 160, 250, 60, 60, -180, 180);

            g.DrawEllipse(blackPen, 100, 150, 180, 180);
        }
    }
}
