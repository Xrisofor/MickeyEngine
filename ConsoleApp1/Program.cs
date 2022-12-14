using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Windows.Forms;

namespace SerializeData
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Serialize();
                Deserialize();
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        static void Serialize()
        {
            //создаем объект который будет сериализован

            List<string> words = new List<string>();
            words.Add("Mickey Engine");
            words.Add("Тестирование создание простого файла типа mpak");
            words.Add("");
            words.Add("Внизу будет рандомный текст:");
            words.Add("Привет");
            words.Add("Я");
            words.Add("Хочу");
            words.Add("Купить");
            words.Add("У");
            words.Add("Вас");
            words.Add("Этот");
            words.Add("Файл");

            //откроем поток для записи в файл
            FileStream fs = new FileStream("file.mpak", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            //сериализация
            bf.Serialize(fs, words);
            fs.Close();
        }

        static void Deserialize()
        {
            List<string> words;
            FileStream fs = new FileStream("file.mpak", FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            words = (List<string>)bf.Deserialize(fs);
            fs.Close();

            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
        }
    }
}