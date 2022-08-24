using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WindowsFormsPlanes
{
    internal class Istrebitel
    {
        /// <summary>
        /// Левая координата отрисовки самолета
        /// </summary>
        private float _startPosX;

        /// <summary>
        /// Правая кооридната отрисовки самолета
        /// </summary>
        private float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;

        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        private readonly int planeWidth = 190;

        /// <summary>
        /// Высота отрисовки самолета
        /// </summary>
        private readonly int planeHeight = 170;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }

        /// <summary>
        /// Вес самолета
        /// </summary>
        public float Weight { private set; get; }

        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { private set; get; }

        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Признак наличия ракет
        /// </summary>
        public bool Rockets { private set; get; }

        /// <summary>
        /// Признак наличия пулемета
        /// </summary>
        public bool Machinegun { private set; get; }

        /// <summary>
        /// Признак наличия турбины
        /// </summary>
        public bool Turbine { private set; get; }

        /// <summary>
        /// Признак наличия линий
        /// </summary>
        public bool Lines { private set; get; }

        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="rockets">Признак наличия ракет</param>
        /// <param name="machinegun">Признак наличия пулемета</param>
        /// <param name="turbine">Признак наличия турбины</param>
        /// <param name="lines">Признак наличия турбины</param>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool rockets, bool machinegun, bool turbine, bool lines)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Rockets = rockets;
            Machinegun = machinegun;
            Turbine = turbine;
            Lines = lines;
        }

        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureHeight = height;
            _pictureWidth = width;
        }

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
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


        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // ракеты
            if (Rockets)
            {
                g.DrawRectangle(pen, _startPosX + 90, _startPosY + 60, 10, 10);
                g.DrawLine(pen, _startPosX + 90, _startPosY + 60, _startPosX + 80, _startPosY + 65);
                g.DrawLine(pen, _startPosX + 80, _startPosY + 65, _startPosX + 90, _startPosY + 70);
                g.DrawLine(pen, _startPosX + 90, _startPosY + 70, _startPosX + 90, _startPosY + 60);

                g.DrawRectangle(pen, _startPosX + 90, _startPosY + 130, 10, 10);
                g.DrawLine(pen, _startPosX + 90, _startPosY + 130, _startPosX + 80, _startPosY + 135);
                g.DrawLine(pen, _startPosX + 80, _startPosY + 135, _startPosX + 90, _startPosY + 140);
                g.DrawLine(pen, _startPosX + 90, _startPosY + 140, _startPosX + 90, _startPosY + 130);

                Brush brBlack = new SolidBrush(Color.Black);
                g.FillRectangle(brBlack, _startPosX + 90, _startPosY + 60, 10, 10);
                g.FillRectangle(brBlack, _startPosX + 90, _startPosY + 130, 10, 10);

            }

            // пулемет
            if (Machinegun)
            {
                g.DrawLine(pen, _startPosX + 30, _startPosY + 100, _startPosX + 20, _startPosY + 100);

            }

            // турбина
            if (Turbine)
            {
                g.DrawRectangle(pen, _startPosX + 180, _startPosY + 95, 2, 10);

                Brush brBlack = new SolidBrush(Color.Black);
                g.FillRectangle(brBlack, _startPosX + 180, _startPosY + 95, 2, 10);
            }

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

            if (Lines)
            {
                g.DrawRectangle(pen, _startPosX + 130, _startPosY + 90, 5, 20);
                g.DrawRectangle(pen, _startPosX + 140, _startPosY + 90, 5, 20);

                Brush brd = new SolidBrush(DopColor);
                g.FillRectangle(brd, _startPosX + 130, _startPosY + 90, 5, 20);
                g.FillRectangle(brd, _startPosX + 140, _startPosY + 90, 5, 20);
            }

            // нос
            g.DrawLine(pen, _startPosX + 50, _startPosY + 90, _startPosX + 30, _startPosY + 100);
            g.DrawLine(pen, _startPosX + 30, _startPosY + 100, _startPosX + 50, _startPosY + 110);
            g.DrawLine(pen, _startPosX + 50, _startPosY + 110, _startPosX + 50, _startPosY + 90);
        }
    }
}
