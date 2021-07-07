using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class locomotive : Train
    {
        public bool FrontLight { private set; get; }//наличие света фар
        public bool Carriage { private set; get; } // наличие второго вагона
        public Color CarriageColor { private set; get; } // цвет второго вагона

        public locomotive(int maxSpeed, int weight, Color mainColor, Color windowColor,bool frontlight, bool carriage, Color carriageColor) :
            base (maxSpeed,weight,mainColor,windowColor)
        { //конструктор с базой
            WindowColor = windowColor;
            FrontLight = frontlight;
            Carriage = carriage;
            CarriageColor = carriageColor;
        }

        public locomotive(string info):base(info)
        {
            string[] str = info.Split(';');
            if (str.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(str[0]);
                Weight = Convert.ToInt32(str[1]);
                MainColor = Color.FromName(str[2]);
                WindowColor = Color.FromName(str[3]);
                FrontLight = Convert.ToBoolean(str[4]);
                Carriage = Convert.ToBoolean(str[5]);
                CarriageColor = Color.FromName(str[6]);
            }
        }

        public override void DrawTrain(Graphics g) // рисовка
        {
            Pen pen = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Black, 1);
            Brush grass = new SolidBrush(Color.Green);//цвет травы
            Brush column = new SolidBrush(Color.Gray);//цвет колонн
            Brush test = new SolidBrush(MainColor);//цвет первого вагона
            Brush test2 = new SolidBrush(WindowColor);// цвет окон
            Brush carriagecolor = new SolidBrush(CarriageColor);//цвет второго вагона
            if (FrontLight)//если есть свет фар
            {
                Brush brushforlight = new SolidBrush(Color.Yellow);//свет фар
                g.FillPie(brushforlight, _startPosX - 35, _startPosY + 20, 100, 20, 160, 40);
            }
            base.DrawTrain(g);//рисуем первый вагон
            if (Carriage)//если есть второй вагон
            {
                g.DrawLine(pen, _startPosX + 70, _startPosY + 35, _startPosX + 80, _startPosY + 35);//перемычка+рога
                g.DrawLine(pen, _startPosX + 100, _startPosY + 20, _startPosX + 110, _startPosY + 10);
                g.DrawLine(pen, _startPosX + 105, _startPosY + 10, _startPosX + 115, _startPosY + 10);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 20, 50, 20);//границы
                g.DrawEllipse(pen, _startPosX + 85, _startPosY + 40, 10, 10);
                g.DrawEllipse(pen, _startPosX + 115, _startPosY + 40, 10, 10);
                g.FillRectangle(carriagecolor, _startPosX + 80, _startPosY + 20, 50, 20);//зиливка вагона+окно
                g.FillRectangle(test2, _startPosX + 85, _startPosY + 23, 40, 8);
                g.DrawRectangle(pen2, _startPosX + 85, _startPosY + 23, 40, 8);
                g.FillEllipse(carriagecolor, _startPosX + 85, _startPosY + 40, 10, 10);//колеса
                g.FillEllipse(carriagecolor, _startPosX + 115, _startPosY + 40, 10, 10);
            }
        }

        public void setCarriageColor(Color color)
        {
            CarriageColor = color;
        }

        public override string ToString()
        {
            return base.ToString()+";"+ FrontLight.ToString()+";"+Carriage.ToString()+";"+CarriageColor.Name;
        }

    }
}
