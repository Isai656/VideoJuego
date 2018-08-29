using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_eventos_del_mouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int puntos = 0;
        int total_tiros = 0;
        int tiros_perdidos =0;

        void funcion_disparos()
        {
            puntos++;
            label1.Text = "puntaje" + puntos;
            total_tiros++;
            label2.Text = "disparos" + total_tiros;
        }
        void reset()
        {
            puntos = 0;
            total_tiros = 0;
            tiros_perdidos = 0;
            label1.Text = "puntaje" + puntos;
            label2.Text = "disparos" + total_tiros;
            label3.Text = "fallidos" + tiros_perdidos;
            timer1.Start();
        }
        void funcion_perdidos()
        {
            tiros_perdidos++;
            label3.Text = "fallidos" + tiros_perdidos;
            total_tiros++;
            label2.Text = "disparos" + total_tiros;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(0, 500);
            y = r.Next(200, 330);
            pictureBox1.Location = new Point(x, y);
            if (tiros_perdidos>=10)
            {
                timer1.Stop();
                label1.Text = "ya perdistesss";
            }



        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            funcion_perdidos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            funcion_disparos();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
