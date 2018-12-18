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

    class Train : Trainabstract
    {
        protected const int trainWidth = 200;
        protected const int trainHeight = 60;
        public Train(int maxSpeed, int weight, Color mainColor, Color windowColor)
        {
            MaxSpeed = maxSpeed;//макс скорость
            Weight = weight;//вес
            MainColor = mainColor;//цвет первого вагона
            WindowColor = windowColor;//цвет окон
        }

        public Train(string info)
        {
            string[] str = info.Split(';');
            if(str.Length == 4)
            {
                MaxSpeed = Convert.ToInt32(str[0]);
                Weight = Convert.ToInt32(str[1]);
                MainColor = Color.FromName(str[2]);
                WindowColor = Color.FromName(str[3]);
            }
        }

        public override void MoveTrain(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch(direction)
            { //поезд двигается только вперед и назад
                case Direction.Right:
                    if(_startPosX+step<_pictureWidth-trainWidth)//проверка на выход за правую границу
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left://проверка на выход за левую границу
                    if (_startPosX-step>0)
                    {
                        _startPosX -= step;
                    }
                    break;
                /*case Direction.Up:
                    if(_startPosY-step>0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if(_startPosY-step<_pictureheight-trainHeight)
                    {
                        _startPosY += step;
                    }
                    break;*/
            }
        }
        public override void DrawTrain(Graphics g)//рисуем только первый вагон, рельсы, траву, рельсы, столбы, линию электропередач
        {
            Pen pen = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Black, 1);
            Brush test = new SolidBrush(MainColor);
            Brush test2 = new SolidBrush(WindowColor);
            Brush grass = new SolidBrush(Color.Green);
            Brush column = new SolidBrush(Color.Gray);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 20, 50, 20);//borders
            g.DrawEllipse(pen, _startPosX + 10, _startPosY + 20, 20, 20);//граница носа
            g.DrawEllipse(pen, _startPosX + 25, _startPosY + 40, 10, 10);//граница колес
            g.DrawEllipse(pen, _startPosX + 55, _startPosY + 40, 10, 10);
            g.FillEllipse(test, _startPosX + 10, _startPosY + 20, 20, 20);//nose
            g.FillEllipse(test, _startPosX + 25, _startPosY + 40, 10, 10); //whells
            g.FillEllipse(test, _startPosX + 55, _startPosY + 40, 10, 10);
            g.FillRectangle(test, _startPosX + 20, _startPosY + 20, 50, 20);//main rectangle
            g.DrawLine(pen, _startPosX + 40, _startPosY + 20, _startPosX + 50, _startPosY + 10);//рога
            g.DrawLine(pen, _startPosX + 45, _startPosY + 10, _startPosX + 55, _startPosY + 10);
            g.FillRectangle(test2, _startPosX + 25, _startPosY + 23, 40, 8);//окно с границей
            g.DrawRectangle(pen2, _startPosX + 25, _startPosY + 23, 40, 8);
        }

        public override string ToString()
        {
            return MaxSpeed+";"+Weight+";"+MainColor.Name+";"+WindowColor.Name;
        }

    }
}
