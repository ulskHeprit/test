using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Depo<T> where T : class, ITransport
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private int placeSizeW = 200;//размер места
        private int placeSizeH = 60;

        public Depo(int count, int picturew, int pictureh)
        {
            maxCount = count;
            places = new Dictionary<int, T>();
            PictureWidth = picturew;
            PictureHeight = pictureh;
        }

        public static int operator +(Depo<T> p, T train)
        {
            if(p.places.Count == p.maxCount) //проверка на "свободные места"
            {
                throw new DepoOverflowExeption();//депо полное
            }
            for(int i=0;i<p.maxCount;i++)
            {
                if(p.CheckFreePlace(i))//проверка на пустое место и добавление поезда 
                {
                    p.places.Add(i, train);
                    p.places[i].SetPosition(5 + i / 10 * p.placeSizeW + 40, i % 10 * p.placeSizeH + 8, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Depo<T> p, int index)
        {
            if(!p.CheckFreePlace(index))//проверка свободного места и удаление поезда
            {
                T train = p.places[index];
                p.places.Remove(index);
                return train;
            }

            throw new TrainNotFound(index);//поезд не найден
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);//проверка на содержание поезда с index
        }

        public void Draw(Graphics g)
        {
            DrawDepo(g);
            var keys = places.Keys.ToList();
            for(int i =0;i<keys.Count;i++)
            {
                places[keys[i]].DrawTrain(g);
            }
        }

        private void DrawDepo(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
                for(int j =0;j<10;++j)
                {
                    g.DrawLine(pen, 0, j * placeSizeH + 60 , 200, j * placeSizeH+60);//"рельсы"
                }
                g.DrawLine(pen, 0, 0, 0, placeSizeH*10);//вертикальная линия слева
            
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return null;
                    //throw new TrainNotFound(ind);
            }
            set
            {
                if(CheckFreePlace(ind))
                {
                    places.Add(ind, value);
                    places[ind].SetPosition(5 + ind / 10 * placeSizeW + 40, ind % 10 * placeSizeH + 8, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new LineNotEmpty(ind);
                }
            }
        }

    }
}
