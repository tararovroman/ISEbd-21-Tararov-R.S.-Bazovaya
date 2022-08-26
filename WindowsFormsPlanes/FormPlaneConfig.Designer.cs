namespace WindowsFormsPlanes
{
    partial class FormPlaneConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxLines = new System.Windows.Forms.CheckBox();
            this.checkBoxTurbine = new System.Windows.Forms.CheckBox();
            this.checkBoxMachinegun = new System.Windows.Forms.CheckBox();
            this.checkBoxRockets = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelIstrebitel = new System.Windows.Forms.Label();
            this.labelWarPlane = new System.Windows.Forms.Label();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.pGray = new System.Windows.Forms.Panel();
            this.pBlack = new System.Windows.Forms.Panel();
            this.pWhite = new System.Windows.Forms.Panel();
            this.pBlue = new System.Windows.Forms.Panel();
            this.pYellow = new System.Windows.Forms.Panel();
            this.pGreen = new System.Windows.Forms.Panel();
            this.pOrange = new System.Windows.Forms.Panel();
            this.pRed = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelPlane.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLines);
            this.groupBox1.Controls.Add(this.checkBoxTurbine);
            this.groupBox1.Controls.Add(this.checkBoxMachinegun);
            this.groupBox1.Controls.Add(this.checkBoxRockets);
            this.groupBox1.Controls.Add(this.numericUpDownWeight);
            this.groupBox1.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // checkBoxLines
            // 
            this.checkBoxLines.AutoSize = true;
            this.checkBoxLines.Location = new System.Drawing.Point(185, 144);
            this.checkBoxLines.Name = "checkBoxLines";
            this.checkBoxLines.Size = new System.Drawing.Size(70, 20);
            this.checkBoxLines.TabIndex = 7;
            this.checkBoxLines.Text = "Линии";
            this.checkBoxLines.UseVisualStyleBackColor = true;
            // 
            // checkBoxTurbine
            // 
            this.checkBoxTurbine.AutoSize = true;
            this.checkBoxTurbine.Location = new System.Drawing.Point(185, 117);
            this.checkBoxTurbine.Name = "checkBoxTurbine";
            this.checkBoxTurbine.Size = new System.Drawing.Size(86, 20);
            this.checkBoxTurbine.TabIndex = 6;
            this.checkBoxTurbine.Text = "Турбина";
            this.checkBoxTurbine.UseVisualStyleBackColor = true;
            // 
            // checkBoxMachinegun
            // 
            this.checkBoxMachinegun.AutoSize = true;
            this.checkBoxMachinegun.Location = new System.Drawing.Point(185, 90);
            this.checkBoxMachinegun.Name = "checkBoxMachinegun";
            this.checkBoxMachinegun.Size = new System.Drawing.Size(87, 20);
            this.checkBoxMachinegun.TabIndex = 5;
            this.checkBoxMachinegun.Text = "Пулемет";
            this.checkBoxMachinegun.UseVisualStyleBackColor = true;
            // 
            // checkBoxRockets
            // 
            this.checkBoxRockets.AutoSize = true;
            this.checkBoxRockets.Location = new System.Drawing.Point(185, 64);
            this.checkBoxRockets.Name = "checkBoxRockets";
            this.checkBoxRockets.Size = new System.Drawing.Size(77, 20);
            this.checkBoxRockets.TabIndex = 4;
            this.checkBoxRockets.Text = "Ракеты";
            this.checkBoxRockets.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(9, 142);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWeight.TabIndex = 3;
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 64);
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес самолета:";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость:";
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(459, 223);
            this.pictureBoxPlane.TabIndex = 1;
            this.pictureBoxPlane.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelIstrebitel);
            this.groupBox2.Controls.Add(this.labelWarPlane);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип самолета";
            // 
            // labelIstrebitel
            // 
            this.labelIstrebitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIstrebitel.Location = new System.Drawing.Point(9, 98);
            this.labelIstrebitel.Name = "labelIstrebitel";
            this.labelIstrebitel.Size = new System.Drawing.Size(148, 45);
            this.labelIstrebitel.TabIndex = 1;
            this.labelIstrebitel.Text = "Истребитель";
            this.labelIstrebitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIstrebitel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelIstrebitel_MouseDown);
            // 
            // labelWarPlane
            // 
            this.labelWarPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarPlane.Location = new System.Drawing.Point(9, 39);
            this.labelWarPlane.Name = "labelWarPlane";
            this.labelWarPlane.Size = new System.Drawing.Size(148, 45);
            this.labelWarPlane.TabIndex = 0;
            this.labelWarPlane.Text = "Военный самолет";
            this.labelWarPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarPlane_MouseDown);
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(197, 25);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(466, 229);
            this.panelPlane.TabIndex = 3;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(12, 86);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(178, 45);
            this.labelDopColor.TabIndex = 9;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(12, 27);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(178, 45);
            this.labelBaseColor.TabIndex = 8;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pGray
            // 
            this.pGray.BackColor = System.Drawing.Color.Silver;
            this.pGray.Location = new System.Drawing.Point(150, 199);
            this.pGray.Name = "pGray";
            this.pGray.Size = new System.Drawing.Size(40, 40);
            this.pGray.TabIndex = 7;
            this.pGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // pBlack
            // 
            this.pBlack.BackColor = System.Drawing.Color.Black;
            this.pBlack.Location = new System.Drawing.Point(104, 199);
            this.pBlack.Name = "pBlack";
            this.pBlack.Size = new System.Drawing.Size(40, 40);
            this.pBlack.TabIndex = 6;
            this.pBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // pWhite
            // 
            this.pWhite.BackColor = System.Drawing.Color.White;
            this.pWhite.Location = new System.Drawing.Point(58, 199);
            this.pWhite.Name = "pWhite";
            this.pWhite.Size = new System.Drawing.Size(40, 40);
            this.pWhite.TabIndex = 5;
            this.pWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // pBlue
            // 
            this.pBlue.BackColor = System.Drawing.Color.Blue;
            this.pBlue.Location = new System.Drawing.Point(12, 199);
            this.pBlue.Name = "pBlue";
            this.pBlue.Size = new System.Drawing.Size(40, 40);
            this.pBlue.TabIndex = 4;
            this.pBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // pYellow
            // 
            this.pYellow.BackColor = System.Drawing.Color.Yellow;
            this.pYellow.Location = new System.Drawing.Point(104, 153);
            this.pYellow.Name = "pYellow";
            this.pYellow.Size = new System.Drawing.Size(40, 40);
            this.pYellow.TabIndex = 3;
            this.pYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // pGreen
            // 
            this.pGreen.BackColor = System.Drawing.Color.Lime;
            this.pGreen.Location = new System.Drawing.Point(150, 153);
            this.pGreen.Name = "pGreen";
            this.pGreen.Size = new System.Drawing.Size(40, 40);
            this.pGreen.TabIndex = 2;
            this.pGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // pOrange
            // 
            this.pOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pOrange.Location = new System.Drawing.Point(58, 153);
            this.pOrange.Name = "pOrange";
            this.pOrange.Size = new System.Drawing.Size(40, 40);
            this.pOrange.TabIndex = 1;
            this.pOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // pRed
            // 
            this.pRed.BackColor = System.Drawing.Color.Red;
            this.pRed.Location = new System.Drawing.Point(12, 153);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(40, 40);
            this.pRed.TabIndex = 0;
            this.pRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(675, 283);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(92, 38);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDopColor);
            this.groupBox3.Controls.Add(this.labelBaseColor);
            this.groupBox3.Controls.Add(this.pGray);
            this.groupBox3.Controls.Add(this.pBlack);
            this.groupBox3.Controls.Add(this.pWhite);
            this.groupBox3.Controls.Add(this.pBlue);
            this.groupBox3.Controls.Add(this.pYellow);
            this.groupBox3.Controls.Add(this.pGreen);
            this.groupBox3.Controls.Add(this.pOrange);
            this.groupBox3.Controls.Add(this.pRed);
            this.groupBox3.Location = new System.Drawing.Point(669, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 252);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвета";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(773, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 38);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPlaneConfig";
            this.Text = "Выбор самолета";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxLines;
        private System.Windows.Forms.CheckBox checkBoxTurbine;
        private System.Windows.Forms.CheckBox checkBoxMachinegun;
        private System.Windows.Forms.CheckBox checkBoxRockets;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelIstrebitel;
        private System.Windows.Forms.Label labelWarPlane;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel pGray;
        private System.Windows.Forms.Panel pBlack;
        private System.Windows.Forms.Panel pWhite;
        private System.Windows.Forms.Panel pBlue;
        private System.Windows.Forms.Panel pYellow;
        private System.Windows.Forms.Panel pGreen;
        private System.Windows.Forms.Panel pOrange;
        private System.Windows.Forms.Panel pRed;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCancel;
    }
}