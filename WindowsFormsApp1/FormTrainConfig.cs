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
    public partial class FormTrainConfig : Form
    {

        ITransport train = null;

        private event trainDelegate eventAddTrain;

        public FormTrainConfig()
        {
            InitializeComponent();
            button_cancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawTrain()
        {
            if(train != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.SetPosition(50, 30, pictureBox1.Width, pictureBox1.Height);
                train.DrawTrain(gr);
                pictureBox1.Image = bmp;
            }
        }

        public void AddEvent(trainDelegate ev)
        {
            if(eventAddTrain == null)
            {
                eventAddTrain = new trainDelegate(ev);
            }
            else
            {
                eventAddTrain += ev;
            } 
        }

        private void label_train_MouseDown(object sender, MouseEventArgs e)
        {
            label_train.DoDragDrop(label_train.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void label_locomotive_MouseDown(object sender, MouseEventArgs e)
        {
            label_locomotive.DoDragDrop(label_locomotive.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panel_train_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel_train_DragDrop(object sender, DragEventArgs e)
        {
            switch(e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Поезд":
                    train = new Train(1000, 10000, Color.Black, Color.White);
                    break;
                case "Локомотив":
                    train = new locomotive(1000, 10000, Color.Blue, Color.Yellow, true, true, Color.Black);
                    break;
            }
            DrawTrain();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void label_maincolor_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void label_maincolor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                train.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTrain();
            }
        }

        private void label_windowcolor_DragDrop(object sender, DragEventArgs e)
        {
            if(train != null)
            {
                train.setWindowColor((Color)e.Data.GetData(typeof(Color)));
                DrawTrain();
            }
        }

        private void label_carriagecolor_DragDrop(object sender, DragEventArgs e)
        {
            if(train != null)
            {
                if(train is locomotive)
                {
                    (train as locomotive).setCarriageColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTrain();
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(train);
            Close();
        }
    }
}
