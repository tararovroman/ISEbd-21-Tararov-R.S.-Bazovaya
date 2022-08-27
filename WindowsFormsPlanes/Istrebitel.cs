using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WindowsFormsPlanes
{
    /// <summary>
    /// Класс отрисовки истребителя
    /// </summary>
    public class Istrebitel : WarPlane, IEquatable<Istrebitel>
    {
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
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="rockets">Признак наличия ракет</param>
        /// <param name="machinegun">Признак наличия пулемета</param>
        /// <param name="turbine">Признак наличия турбины</param>
        /// <param name="lines">Признак наличия турбины</param>
        public Istrebitel(int maxSpeed, float weight, Color mainColor, Color dopColor, bool rockets, bool machinegun, bool turbine, bool lines) : base(maxSpeed, weight, mainColor, 190, 170)
        {
            DopColor = dopColor;
            Rockets = rockets;
            Machinegun = machinegun;
            Turbine = turbine;
            Lines = lines;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public Istrebitel(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Rockets = Convert.ToBoolean(strs[4]);
                Machinegun = Convert.ToBoolean(strs[5]);
                Turbine = Convert.ToBoolean(strs[6]);
                Lines = Convert.ToBoolean(strs[7]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            Brush brBlack = new SolidBrush(Color.Black);

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
                g.FillRectangle(brBlack, _startPosX + 180, _startPosY + 95, 2, 10);
            }

            // теперь отрисуем основу
            base.DrawTransport(g);

            // линии
            if (Lines)
            {
                g.DrawRectangle(pen, _startPosX + 130, _startPosY + 90, 5, 20);
                g.DrawRectangle(pen, _startPosX + 140, _startPosY + 90, 5, 20);

                g.FillRectangle(dopBrush, _startPosX + 130, _startPosY + 90, 5, 20);
                g.FillRectangle(dopBrush, _startPosX + 140, _startPosY + 90, 5, 20);
            }

        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Rockets}{separator}{Machinegun}{separator}{Turbine}{separator}{Lines}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Istrebitel other)
        {
            if (DopColor == other.DopColor && Rockets == other.Rockets && Machinegun == other.Machinegun && 
                Turbine == other.Turbine && Lines == other.Lines)
            {
                return base.Equals(other);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Istrebitel planeObj))
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }
    }
}
