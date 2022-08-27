﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    /// <summary>
    /// Класс-коллекция парковок
    /// </summary>
    public class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;

        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }

        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        /// <summary>
        /// Сохранение информации по самолетах в ангаре в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"ParkingCollection{Environment.NewLine}", fs);
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    WriteToFile($"Parking{separator}{level.Key}{Environment.NewLine}", fs);
                    foreach (ITransport plane in level.Value)
                    {
                        //Записываем тип мшаины
                        if (plane.GetType().Name == "WarPlane")
                        {
                            WriteToFile($"WarPlane{separator}", fs);
                        }
                        if (plane.GetType().Name == "Istrebitel")
                        {
                            WriteToFile($"Istrebitel{separator}", fs);
                        }
                        //Записываемые параметры
                        WriteToFile(plane + Environment.NewLine, fs);
                    }
                }
            }
        }

        /// <summary>
        /// Загрузка нформации по самолетам в ангаре из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("ParkingCollection"))
            {
                //очищаем записи
                parkingStages.Clear();
            }
            else
            {
                //если нет такой записи, то это не те данные
                throw new Exception("Неверный формат файла");
            }
            Vehicle plane = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i].Contains("Parking"))
                {
                    //начинаем новую парковку
                    key = strs[i].Split(separator)[1];
                    parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(separator)[0] == "WarPlane")
                {
                    plane = new WarPlane(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "Istrebitel")
                {
                    plane = new Istrebitel(strs[i].Split(separator)[1]);
                }
                if (!(parkingStages[key] + plane))
                {
                    throw new Exception("Не удалось загрузить самолет в ангар");
                }
            }
        }
    }
}
