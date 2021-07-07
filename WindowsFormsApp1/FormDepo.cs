using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsApp1
{
    public partial class FormDepo : Form
    {

        FormTrainConfig formconfig;
        MultiDepo multidepo;

        private const int countOfDepo = 5;

        private Logger logger;

        public FormDepo()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            multidepo = new MultiDepo(countOfDepo, pictureBox1.Width, pictureBox1.Height);
            for(int i=0;i<countOfDepo;i++)
            {
                listBox1.Items.Add("Депо № " + (i + 1));
            }
            listBox1.SelectedIndex = 0;
        }

        private void Draw()
        {
            if(listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                multidepo[listBox1.SelectedIndex].Draw(gr);
                pictureBox1.Image = bmp;
            }
        }
        
        private void releasetrain_button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    try
                    {
                        var train = multidepo[listBox1.SelectedIndex] - Convert.ToInt32(maskedTextBox1.Text);

                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        train.SetPosition(5, 5, pictureBox2.Width, pictureBox2.Height);
                        train.DrawTrain(gr);
                        pictureBox2.Image = bmp;
                        logger.Info("Train release " + train.ToString() + " from " + maskedTextBox1.Text + " line.");
                        Draw();
                    }
                    catch(TrainNotFound ex)
                    {
                        MessageBox.Show(ex.Message, "Поезд не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Что-то пошло не так.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void button_addtrain_Click(object sender, EventArgs e)
        {
            formconfig = new FormTrainConfig();
            formconfig.AddEvent(AddTrain);
            formconfig.Show();
        }

        private void AddTrain(ITransport train)
        {
            if(train != null && listBox1.SelectedIndex > -1)
            {
                try
                {
                    int place = multidepo[listBox1.SelectedIndex] + train;
                    logger.Info("Train: "+train.ToString()+" put on "+place+" line");
                    Draw();
                }
                catch(DepoOverflowExeption ex)
                {
                    MessageBox.Show(ex.Message,"Нет свободных линий.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "При добавлении поезда что-то пошло не так.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    multidepo.SaveData(saveFileDialog1.FileName);
                    MessageBox.Show("Сохранено в файл.","Результат",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    logger.Info("save in file "+saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "При сохранении что-то пошло не так.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    multidepo.LoadData(openFileDialog1.FileName);
                    MessageBox.Show("Загружено.","Результат.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    logger.Info("load from file "+openFileDialog1.FileName);
                }
                catch (LineNotEmpty ex)
                {
                    MessageBox.Show(ex.Message, "Линия занята.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "При загрузке что-то пошло не так.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
