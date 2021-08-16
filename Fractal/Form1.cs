using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using System.Diagnostics;

namespace Fractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FracIcon.InitializeContexts();

        }


        int a1, a2, a3, a4, a5;
        float r, g, b;


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fractalDataSet1.frac". При необходимости она может быть перемещена или удалена.
            this.fracTableAdapter1.Fill(this.fractalDataSet1.frac);




            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_SINGLE);
            // очистка окна
            Gl.glClearColor(255, 255, 255, 1);
            // установка порта вывода в соответствии с размерами элемента FracIcon 
            Gl.glViewport(0, 0, FracIcon.Width, FracIcon.Height);
            // настройка проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION); Gl.glLoadIdentity();
            // настроить 2D ортогональную проекцию 

            if ((float)FracIcon.Width <= (float)FracIcon.Height)
            { Glu.gluOrtho2D(0.0, 30.0 * (float)FracIcon.Height / (float)FracIcon.Width, 0.0, 30.0); }
            else
            { Glu.gluOrtho2D(0.0, 30.0 * (float)FracIcon.Width / (float)FracIcon.Height, 0.0, 30.0); }
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            ToolTip t = new ToolTip();
            t.SetToolTip(trackBar4, "X фрактала");
            t.SetToolTip(trackBar2, "Y фрактала");
            t.SetToolTip(trackBar1, "Увилечение фрактала");
            t.SetToolTip(trackBar5, "Поворот фрактала");
            t.SetToolTip(trackBar3, "Качество отрисовки");


        }


        public static class CompPerformance
        {
            static PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            static PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            public static string getCurrentCpuUsage()
            {
                return cpuCounter.NextValue() + "%";
            }

            public static string getAvailableRAM()
            {
                return ramCounter.NextValue() + "MB";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = CompPerformance.getCurrentCpuUsage();
            toolStripStatusLabel4.Text = CompPerformance.getAvailableRAM();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            a1 = 20; a2 = 20; a3 = 1; a4 = 1; a5 = 7;
            Display();
            button1.Enabled = false;
            trackBar1.Enabled = true;
            trackBar2.Enabled = true;
            trackBar3.Enabled = true;
            trackBar4.Enabled = true;
            trackBar5.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;
            button2.Enabled = true;
            

        }


        private void Track(object sender, EventArgs e)
        {
            a1 = trackBar4.Value;
            a2 = trackBar2.Value;
            a3 = trackBar1.Value;
            a4 = trackBar5.Value;
            a5 = trackBar3.Value;

            numericUpDown1.Value = trackBar4.Value;
            numericUpDown2.Value = trackBar2.Value;
            numericUpDown3.Value = trackBar1.Value;
            numericUpDown4.Value = trackBar5.Value;
            numericUpDown5.Value = trackBar3.Value;

            trackBar4.Value = Convert.ToInt32(numericUpDown1.Value);
            trackBar2.Value = Convert.ToInt32(numericUpDown2.Value);
            trackBar1.Value = Convert.ToInt32(numericUpDown3.Value);
            trackBar5.Value = Convert.ToInt32(numericUpDown4.Value);
            trackBar3.Value = Convert.ToInt32(numericUpDown5.Value);
            Display();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            Color clr = cdlg.Color;
            float r1, b1, g1;

            try
            {

                r1 = clr.R;
                g1 = clr.G;
                b1 = clr.B;

                r = r1 / 255;
                b = b1 / 255;
                g = g1 / 255;
                // show the value in message box

                MessageBox.Show("Red :" + r + ", Green :" + g + ", Blue :" + b);
                Display();

            }
            catch (Exception ex)
            {
                //doing nothing
            }

        }




        private void ewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.fracBindingSource.EndEdit();
                this.fracTableAdapter1.Update(this.fractalDataSet1.frac);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Cell_KeyPress);
        }
        private void Cell_KeyPress(object Sender, KeyPressEventArgs pressE)
        {
            if (!Char.IsDigit(pressE.KeyChar) && pressE.KeyChar != 8)
                pressE.KeyChar = Convert.ToChar("\0");
            errortext.SetError(dataGridView1, "Предуприждение, допустимы только числа");
        }

    

        private void cбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a1 = 20; a2 = 20; a3 = 1; a4 = 1; a5 = 7; r = 0; g = 0;b =0;
            Display();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://cdn.fishki.net/upload/post/201406/05/1275160/giphy-19.gif");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.ua/search?q=" + textBox1.Text);
        }


        private void ewrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a1 = (int)dataGridView1.CurrentRow.Cells[1].Value;
            a2 = (int)dataGridView1.CurrentRow.Cells[2].Value;
            a3 = (int)dataGridView1.CurrentRow.Cells[3].Value;
            a4 = (int)dataGridView1.CurrentRow.Cells[4].Value;
            a5 = (int)dataGridView1.CurrentRow.Cells[5].Value;
            r = (int)dataGridView1.CurrentRow.Cells[6].Value;
            g = (int)dataGridView1.CurrentRow.Cells[7].Value;
            b = (int)dataGridView1.CurrentRow.Cells[8].Value;

            Display();
        }



        private void werToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fracTableAdapter1.Insert(a1, a2, a3, a4, a5, (int)r, (int)g, (int)b);
            fracTableAdapter1.qwerty(fractalDataSet1.frac);
        }




        void Display()
        {
            /* Очистка экрана цветом по-умолчанию */
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            /* Задание цвета для рисования */
            Gl.glColor3f(r, g, b);

            /* Начало рисования. Вершины 2n и 2n+1 будут обьединены в линию*/
            Gl.glBegin(Gl.GL_LINES);

            /* Вызов функции, рисующей фрактал. В функции передаются вершины в буфер */
            SetFractal(a1, a2, a3, a4, a5);

            /* Функция, выгружающая буфер в сцену */
            Gl.glEnd();

            /*  Прорисовка текущего буфера */
            Gl.glFlush();

            FracIcon.Invalidate();
        }


        public static class MathF
        {
            public static Func<double, float> Cos = angleR => (float)Math.Cos(angleR);
            public static Func<double, float> Sin = angleR => (float)Math.Sin(angleR);
        }
        void SetFractal(float x, float y, float r, float angle, int deep)
        {
            float pi5 = 3.141596f / 5;
            float h = 2 * r * MathF.Cos(pi5);

            for (int i = 0; i < 5; i++)
            {

                float ang2 = angle + pi5 * i * 2,
                x2 = x - h * MathF.Cos(ang2),
                y2 = y - h * MathF.Sin(ang2),
                rad2 = r / (2 * MathF.Cos(pi5) + 1),
                ang3 = angle + 3.141596f + (2 * i + 1) * pi5;
                for (int j = 0; j < 4; j++)
                {
                    /* В буфер записываются вершины. Эти две вершины будут соединены в прямые между собой*/
                    Gl.glVertex2f(x + rad2 * MathF.Cos(ang3 + j * pi5 * 2), y + rad2 * MathF.Sin(ang3 + j * pi5 * 2));
                    Gl.glVertex2f(x + rad2 * MathF.Cos(ang3 + (j + 1) * pi5 * 2), y + rad2 * MathF.Sin(ang3 + (j + 1) * pi5 * 2));

                }
                /* Условие выхода из рекурсии. Из максимальной глубины рекурсии не строятся меньшие пятиугольники*/
                if (deep > 0) SetFractal(x2, y2, r / (2 * MathF.Cos(pi5) + 1), angle + 3.141596f + (2 * i + 1) * pi5, deep - 1);
            }

        }




        private void FracIcon_ClientSizeChanged(object sender, EventArgs e)
        {
            Display();

        }
    }
}
