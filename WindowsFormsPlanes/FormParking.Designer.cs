namespace WindowsFormsPlanes
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetWarPlane = new System.Windows.Forms.Button();
            this.buttonSetIstrebitel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.buttonDelParking = new System.Windows.Forms.Button();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1018, 560);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetWarPlane
            // 
            this.buttonSetWarPlane.Location = new System.Drawing.Point(1037, 275);
            this.buttonSetWarPlane.Name = "buttonSetWarPlane";
            this.buttonSetWarPlane.Size = new System.Drawing.Size(137, 60);
            this.buttonSetWarPlane.TabIndex = 1;
            this.buttonSetWarPlane.Text = "Припарковать военный самолет";
            this.buttonSetWarPlane.UseVisualStyleBackColor = true;
            this.buttonSetWarPlane.Click += new System.EventHandler(this.buttonSetWarPlane_Click);
            // 
            // buttonSetIstrebitel
            // 
            this.buttonSetIstrebitel.Location = new System.Drawing.Point(1037, 341);
            this.buttonSetIstrebitel.Name = "buttonSetIstrebitel";
            this.buttonSetIstrebitel.Size = new System.Drawing.Size(137, 60);
            this.buttonSetIstrebitel.TabIndex = 2;
            this.buttonSetIstrebitel.Text = "Припарковать истребитель";
            this.buttonSetIstrebitel.UseVisualStyleBackColor = true;
            this.buttonSetIstrebitel.Click += new System.EventHandler(this.buttonSetIstrebitel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakePlane);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1037, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать самолет";
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(24, 80);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(88, 30);
            this.buttonTakePlane.TabIndex = 2;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(75, 34);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(37, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 16;
            this.listBoxParkings.Location = new System.Drawing.Point(1037, 120);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(137, 84);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(1037, 210);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(137, 35);
            this.buttonDelParking.TabIndex = 5;
            this.buttonDelParking.Text = "Удалить парковку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(1037, 71);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(137, 43);
            this.buttonAddParking.TabIndex = 6;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(1037, 43);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(137, 22);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1034, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Парковки:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetIstrebitel);
            this.Controls.Add(this.buttonSetWarPlane);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetWarPlane;
        private System.Windows.Forms.Button buttonSetIstrebitel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonDelParking;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label label2;
    }
}