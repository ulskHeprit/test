using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public class MultiDepo
    {
        List<Depo<ITransport>> numberOfDepo;
        private const int countPlaces = 10;
        private int _pictureWidth;
        private int _pictureHeight;

        public MultiDepo(int countOfDepo, int pictureWidth, int pictureHight)
        {
            numberOfDepo = new List<Depo<ITransport>>();
            this._pictureWidth = pictureWidth;
            this._pictureHeight = pictureHight;
            for(int i=0;i<countOfDepo;i++)
            {
                numberOfDepo.Add(new Depo<ITransport>(countPlaces, pictureWidth, pictureHight));
            }
        }

        public Depo<ITransport> this[int ind]
        {
            get
            {
                if(ind>-1 && ind < numberOfDepo.Count)
                {
                    return numberOfDepo[ind];
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            if(File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    WriteToFile("CountDepos:" + numberOfDepo.Count+Environment.NewLine,fs);
                    foreach(var count in numberOfDepo)
                    {
                        WriteToFile("Number" + Environment.NewLine, fs);
                        for(int i=0;i<countPlaces;i++)
                        {
                            try
                            {
                                var train = count[i];
                                if (train != null)
                                {
                                    if (train.GetType().Name == "Train")
                                    {
                                        WriteToFile(i + ":Train:", fs);
                                    }
                                    if (train.GetType().Name == "locomotive")
                                    {
                                        WriteToFile(i + ":locomotive:", fs);
                                    }
                                    WriteToFile(train + Environment.NewLine, fs);
                                }
                            }
                            finally { }
                        }
                    }
                }
            }
        }

        private void WriteToFile(string text,FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public void LoadData(string filename)
        {
            if(!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string buffertext = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while(bs.Read(b,0,b.Length)>0)
                    {
                        buffertext += temp.GetString(b);
                    }
                }
            }
            buffertext = buffertext.Replace("\r", "");
            var str = buffertext.Split('\n');
            if(str[0].Contains("CountDepos"))
            {
                int count = Convert.ToInt32(str[0].Split(':')[1]);
                if(numberOfDepo !=null)
                {
                    numberOfDepo.Clear();
                }
                numberOfDepo = new List<Depo<ITransport>>(count);
            }
            else
            {
                throw new Exception("Неверный формат файла.");
            }
            int counter = -1;
            ITransport train = null;
            for (int i = 1; i < str.Length; ++i)
            {
                if (str[i] == "Number")
                {
                    counter++;
                    numberOfDepo.Add(new Depo<ITransport>(countPlaces, _pictureWidth, _pictureHeight));
                    continue;
                }
                if(string.IsNullOrEmpty(str[i]))
                {
                    continue;
                }
                if (str[i].Split(':')[1]=="Train")
                {
                    train = new Train(str[i].Split(':')[2]);
                }
                else if(str[i].Split(':')[1]=="locomotive")
                {
                    train = new locomotive(str[i].Split(':')[2]);
                }
                numberOfDepo[counter][Convert.ToInt32(str[i].Split(':')[0])] = train;
            }
        }

    }
}
