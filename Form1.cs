using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Trace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int startX = 10, startY = 300; // начальные координаты траектории 

            int speed = 50; //скорость полета объекта

            double angle = -20; //угол полета объекта

            double x = startX, y = startY; //начальные координаты для получения следующих

            double deltaX, deltaY; //смещения вдоль X Y

            Pen pen = new Pen(Color.Blue); //создания "кисти" c заданым цветом

            Graphics g = e.Graphics; //получения graphics object

            for (int i = 0; i < 100; i++)
            {//100 - это кол-во "смещений" (прыжков)

                deltaX = speed * Math.Cos(angle * Math.PI / 180);//вычисляем deltaX (x2 - x1) 
                deltaY = speed * Math.Sin(angle * Math.PI / 180);//вычисляем deltaY (y2 - y1)  

                x += deltaX;//x2=x1+deltaX  
                y += deltaY;//y2=y1+deltaY  

                g.DrawLine(pen, (float)x, (float)y, (float)(x - deltaX), (float)(y - deltaY));//рисуем line  
            }
        }
    }
}
