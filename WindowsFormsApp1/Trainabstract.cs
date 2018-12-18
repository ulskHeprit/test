using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    abstract class Trainabstract : ITransport
    {
        protected float _startPosX;//стартовая точка х у
        protected float _startPosY;
        protected int _pictureWidth;//размер рисунка ширина высота
        protected int _pictureheight;
        public int MaxSpeed { protected set; get; }//макс скорость
        public int Weight { protected set; get; }//вес
        public Color MainColor { protected set; get; }//цвет первого вагона
        public Color WindowColor { protected set; get; }//цвет окон
        
        public void setMainColor(Color color)
        {
            MainColor = color;
        }
        public void setWindowColor(Color color)
        {
            WindowColor = color;
        }

        public void SetPosition(int x, int y,int width, int height)//установка позиции
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureheight = height;
        }
        public abstract void DrawTrain(Graphics g);//рисуем
        public abstract void MoveTrain(Direction direction);//двигаем


    }
}
