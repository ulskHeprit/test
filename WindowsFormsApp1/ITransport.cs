using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height); //стартовая позиция
        void MoveTrain(Direction direction); // сдвинуть поезд
        void DrawTrain(Graphics g); //рисовка
        void setMainColor(Color color);//цвет первого вагона
        void setWindowColor(Color color);//цвет окон
    }
}
