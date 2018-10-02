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
        public FormForTrain()
        {
            InitializeComponent();
        }

        private Train train;

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxForTrain.Width, pictureBoxForTrain.Height);
            Graphics gr = Graphics.FromImage(bmp);
            train.DrawCar(gr);
            pictureBoxForTrain.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            train = new Train(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
            Color.Red, Color.Blue, true, true);
            train.SetPosition(rnd.Next(10, 100)+600, rnd.Next(10, 400), pictureBoxForTrain.Width, pictureBoxForTrain.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    train.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    train.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    train.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    train.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
