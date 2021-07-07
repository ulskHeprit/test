using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormForTrain : Form
    {
        private ITransport train1; //ссылка на объект интерфейса
        Bitmap bmp;//битмап
        Graphics gr;//рисовалка
        Color mainColor, windowColor, carriageColor;//цвета: первого вагона, окон, второго вагона
        bool lights, carriage;//флаги света фар, второго вагона
        public FormForTrain()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBoxForTrain.Width, pictureBoxForTrain.Height);//присваивание значений переменным
            gr = Graphics.FromImage(bmp);
            mainColor = Color.Tomato;
            windowColor = Color.Gray;
            lights = true;
            carriage = true;
            carriageColor = Color.Green;
        }
        

        private void Draw()
        {

            gr.FillRectangle(Brushes.White, 0, 0, 900, 500);//очистка битмапа белым закрашенным прямоугольником
            train1.DrawTrain(gr);//рисовка
            pictureBoxForTrain.Image = bmp;//вывод картинки на форму
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // создание базового поезда из базового класса Train
            train1 = new Train(1000,10000,Color.Gray,Color.CadetBlue);
            train1.SetPosition(rnd.Next(10, 100)+600, rnd.Next(10, 400), pictureBoxForTrain.Width, pictureBoxForTrain.Height);
            Draw();
        }

        private void create_lokomotive_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // создание локомотива из класса locomotive
            train1 = new locomotive(1000, 10000, mainColor, windowColor, lights, carriage, carriageColor);
            train1.SetPosition(rnd.Next(10, 100) + 600, rnd.Next(10, 400), pictureBoxForTrain.Width, pictureBoxForTrain.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            { /*поезда двигаются только вперед и назад
                case "buttonUp":
                    train1.MoveTrain(Direction.Up);
                    break;
                case "buttonDown":
                    train1.MoveTrain(Direction.Down);
                    break;*/
                case "buttonLeft":
                    train1.MoveTrain(Direction.Left);
                    break;
                case "buttonRight":
                    train1.MoveTrain(Direction.Right);
                    break;
            }
            Draw();
        }

        
    }
}
