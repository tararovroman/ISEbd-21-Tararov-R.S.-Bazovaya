using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    public abstract class Vehicle : ITransport
    {
        /// <summary>
        /// Левая координата отрисовки самолета
        /// </summary>
        protected float _startPosX;
        
        /// <summary>
        /// Правая кооридната отрисовки самолета
        /// </summary>
        protected float _startPosY;
        
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;
        
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }
        
        /// <summary>
        /// Вес самолета
        /// </summary>
        public float Weight { protected set; get; }
        
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureHeight = height;
            _pictureWidth = width;
        }
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
