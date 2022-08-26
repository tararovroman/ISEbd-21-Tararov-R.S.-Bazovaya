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
    public partial class FormPlaneConfig : Form
    {
        /// <summary>
        /// Переменная-выбранный самолет
        /// </summary>
        Vehicle plane = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event PlaneDelegate eventAddPlane;
        public FormPlaneConfig()
        {
            InitializeComponent();
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
            pRed.MouseDown += panelColor_MouseDown;
            pOrange.MouseDown += panelColor_MouseDown;
            pYellow.MouseDown += panelColor_MouseDown;
            pGreen.MouseDown += panelColor_MouseDown;
            pBlue.MouseDown += panelColor_MouseDown;
            pWhite.MouseDown += panelColor_MouseDown;
            pBlack.MouseDown += panelColor_MouseDown;
            pGray.MouseDown += panelColor_MouseDown;
        }

        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawTransport(gr);
                pictureBoxPlane.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(PlaneDelegate ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new PlaneDelegate(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelWarPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarPlane.DoDragDrop(labelWarPlane.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelIstrebitel_MouseDown(object sender, MouseEventArgs e)
        {
            labelIstrebitel.DoDragDrop(labelIstrebitel.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelWarPlane":
                    plane = new WarPlane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Green);
                    break;
                case "labelIstrebitel":
                    plane = new Istrebitel((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Blue, Color.White,
checkBoxRockets.Checked, checkBoxMachinegun.Checked, checkBoxTurbine.Checked, checkBoxLines.Checked);
                    break;
            }
            DrawPlane();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Copy | DragDropEffects.Move);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                if (plane is Istrebitel)
                {
                    (plane as Istrebitel).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawPlane();
                }
            }
        }

        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
    }
}
