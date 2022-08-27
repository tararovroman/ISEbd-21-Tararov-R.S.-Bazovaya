﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Parking<T> where T : class, ITransport
    {
        /// <summary>
        /// Список объектов, которые храним
        /// </summary>
        private readonly List<T> _places;

        /// <summary>
        /// Максимальное количество мест на парковке
        /// </summary>
        private readonly int _maxCount;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 180;

        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 170;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }

        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }

        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется самолет
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="plane">Добавляемый самолет</param>
        /// <returns></returns>
        public static bool operator +(Parking<T> p, T plane)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            p._places.Add(plane);
            return true;
        }

        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем самолет
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                return null;
            }
            T plane = p._places[index];
            p._places.RemoveAt(index);
            return plane;
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(5 + i / 2 * _placeSizeWidth - 15, i % 2 * _placeSizeHeight - 15, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }

        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        /// <summary>
        /// Функция получения элементы из списка
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
    }
}
