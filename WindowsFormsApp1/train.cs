using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    class Train
    {
        //start position
        private float startPosX;
        private float startPosY;
        //picture resolution
        private int pictureWidth;
        private int pictureHeight;
        //object features
        private const int trainWidth = 100;
        private const int trainHeight = 40;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }        //object color        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public Color CarriageColor { private set; get; }
        //object acc.
        public bool FrontLight { private set; get; }
        public bool Carriage { private set; get; }

        public Train(int maxSpeed, float weight, Color mainColor, Color dopColor, Color carriageColor, bool frontLight, bool carriage)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            CarriageColor = carriageColor;
            FrontLight = frontLight;
            Carriage = carriage;
        }        public void SetPosition(int x, int y, int width, int height)
        {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (startPosX + step < pictureWidth - trainWidth)
                    {
                        startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (startPosX - step > 0)
                    {
                        startPosX -= step;
                    }
                    break;
            }
        }        public void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black,2);
            Pen pen2 = new Pen(Color.Black, 1);
            Brush test = new SolidBrush(MainColor);
            Brush test2 = new SolidBrush(DopColor);
            Brush grass = new SolidBrush(Color.Green);
            Brush column = new SolidBrush(Color.Gray);
            Brush carriagecolor = new SolidBrush(CarriageColor);
            if (FrontLight)
            {
                g.FillRectangle(Brushes.MidnightBlue, 0, 0, 900, 500);
            }
            g.FillRectangle(column, 51, startPosY, 4, 60);//columns
            g.DrawRectangle(pen2, 50, startPosY, 5, 60);
            g.FillRectangle(column, 251, startPosY, 4, 60);
            g.DrawRectangle(pen2, 250, startPosY, 5, 60);
            g.FillRectangle(column, 451, startPosY, 4, 60);
            g.DrawRectangle(pen2, 450, startPosY, 5, 60);
            g.FillRectangle(column, 651, startPosY, 4, 60);
            g.DrawRectangle(pen2, 650, startPosY, 5, 60);
            g.FillRectangle(column, 851, startPosY, 4, 60);
            g.DrawRectangle(pen2, 850, startPosY, 5, 60);
            g.DrawLine(pen2, 0, startPosY + 8, FormForTrain.ActiveForm.Size.Width, startPosY + 8);//линия электропередач
            g.DrawLine(pen, 0, startPosY + 52, FormForTrain.ActiveForm.Size.Width, startPosY + 52);//рельсы
            g.FillRectangle(grass, 0,startPosY+53, FormForTrain.ActiveForm.Size.Width, 500-startPosY);//трава

            if (FrontLight)
            {
                Brush brushforlight = new SolidBrush(Color.Yellow);
                g.FillPie(brushforlight, startPosX - 35, startPosY + 20, 100, 20, 160, 40);
            }
            g.DrawRectangle(pen, startPosX + 20, startPosY + 20, 50, 20);//borders
            g.DrawEllipse(pen, startPosX + 10, startPosY + 20, 20, 20);//граница носа
            g.DrawEllipse(pen, startPosX + 25, startPosY + 40, 10, 10);//граница колес
            g.DrawEllipse(pen, startPosX + 55, startPosY + 40, 10, 10);
            g.FillEllipse(test, startPosX + 10, startPosY + 20, 20, 20);//nose
            g.FillEllipse(test, startPosX + 25, startPosY + 40, 10, 10); //whells
            g.FillEllipse(test, startPosX + 55, startPosY + 40, 10, 10);
            g.FillRectangle(test, startPosX + 20, startPosY + 20, 50, 20);//main rectangle
            g.DrawLine(pen, startPosX + 40, startPosY + 20, startPosX + 50, startPosY + 10);//рога
            g.DrawLine(pen, startPosX + 45, startPosY + 10, startPosX + 55, startPosY + 10);
            g.FillRectangle(test2, startPosX + 25, startPosY + 23, 40, 8);//окно с границей
            g.DrawRectangle(pen2, startPosX + 25, startPosY + 23, 40, 8);
            if (Carriage)//вагон
            {
                g.DrawLine(pen, startPosX + 70, startPosY + 35, startPosX + 80, startPosY + 35);//перемычка+рога
                g.DrawLine(pen, startPosX + 100, startPosY + 20, startPosX + 110, startPosY + 10);
                g.DrawLine(pen, startPosX + 105, startPosY + 10, startPosX + 115, startPosY + 10);
                g.DrawRectangle(pen, startPosX + 80, startPosY + 20, 50, 20);//границы
                g.DrawEllipse(pen, startPosX + 85, startPosY + 40, 10, 10);
                g.DrawEllipse(pen, startPosX + 115, startPosY + 40, 10, 10);
                g.FillRectangle(carriagecolor, startPosX + 80, startPosY + 20, 50, 20);//зиливка вагона+окно
                g.FillRectangle(test2, startPosX + 85, startPosY + 23, 40, 8);
                g.DrawRectangle(pen2, startPosX + 85, startPosY + 23, 40, 8);
                g.FillEllipse(test, startPosX + 85, startPosY + 40, 10, 10);//колеса
                g.FillEllipse(test, startPosX + 115, startPosY + 40, 10, 10);
            }
        }
    }
}
