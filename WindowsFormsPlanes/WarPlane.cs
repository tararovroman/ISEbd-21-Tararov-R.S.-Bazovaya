using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    public class WarPlane : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected readonly int planeWidth = 190;

        /// <summary>
        /// Высота отрисовки самолета
        /// </summary>
        protected readonly int planeHeight = 170;

        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char separator = ';';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        public WarPlane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public WarPlane(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Конструкторс изменением размеров самолета
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="planeWidth">Ширина отрисовки самолета</param>
        /// <param name="planeHeight">Высота отрисовки самолета</param>
        protected WarPlane(int maxSpeed, float weight, Color mainColor, int planeWidth, int planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step >= 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step >= 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // крылья
            g.DrawLine(pen, _startPosX + 100, _startPosY + 30, _startPosX + 100, _startPosY + 170);
            g.DrawLine(pen, _startPosX + 100, _startPosY + 170, _startPosX + 110, _startPosY + 170);
            g.DrawLine(pen, _startPosX + 110, _startPosY + 170, _startPosX + 120, _startPosY + 110);
            g.DrawLine(pen, _startPosX + 120, _startPosY + 110, _startPosX + 120, _startPosY + 90);
            g.DrawLine(pen, _startPosX + 120, _startPosY + 90, _startPosX + 110, _startPosY + 30);
            g.DrawLine(pen, _startPosX + 110, _startPosY + 30, _startPosX + 100, _startPosY + 30);

            // хвост
            g.DrawLine(pen, _startPosX + 160, _startPosY + 80, _startPosX + 160, _startPosY + 120);
            g.DrawLine(pen, _startPosX + 160, _startPosY + 120, _startPosX + 180, _startPosY + 140);
            g.DrawLine(pen, _startPosX + 180, _startPosY + 140, _startPosX + 180, _startPosY + 60);
            g.DrawLine(pen, _startPosX + 180, _startPosY + 60, _startPosX + 160, _startPosY + 80);

            // корпус
            g.DrawRectangle(pen, _startPosX + 50, _startPosY + 90, 130, 20);

            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX + 50, _startPosY + 90, 130, 20);

            // нос
            g.DrawLine(pen, _startPosX + 50, _startPosY + 90, _startPosX + 30, _startPosY + 100);
            g.DrawLine(pen, _startPosX + 30, _startPosY + 100, _startPosX + 50, _startPosY + 110);
            g.DrawLine(pen, _startPosX + 50, _startPosY + 110, _startPosX + 50, _startPosY + 90);
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}
