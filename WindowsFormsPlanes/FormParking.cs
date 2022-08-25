using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlanes
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Parking<WarPlane> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<WarPlane>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать военный самолет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetWarPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new WarPlane(100, 1000, dialog.Color);
                if ((parking + plane) > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать истребитель"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetIstrebitel_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Istrebitel(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
                    if ((parking + plane) > -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var a = Convert.ToInt32(maskedTextBox.Text) - 1;
                var plane = parking - Convert.ToInt32(a);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
