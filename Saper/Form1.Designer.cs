namespace Saper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            labelInfo = new Label();
            labelName = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            labelT1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBoxOpen = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBoxZero = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBoxMine = new PictureBox();
            pictureBoxFlag = new PictureBox();
            trackBarY = new TrackBar();
            buttonStart = new Button();
            trackBarX = new TrackBar();
            trackBarBomb = new TrackBar();
            labelX = new Label();
            labelY = new Label();
            labelB = new Label();
            labelNumMines = new Label();
            buttonReturnToMenu = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBomb).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(labelInfo);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(labelT1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBoxOpen);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBoxZero);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBoxMine);
            panel1.Controls.Add(pictureBoxFlag);
            panel1.Controls.Add(trackBarY);
            panel1.Controls.Add(buttonStart);
            panel1.Controls.Add(trackBarX);
            panel1.Controls.Add(trackBarBomb);
            panel1.Controls.Add(labelX);
            panel1.Controls.Add(labelY);
            panel1.Controls.Add(labelB);
            panel1.Location = new Point(56, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 650);
            panel1.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 17F);
            label8.ForeColor = Color.FromArgb(87, 166, 67);
            label8.Location = new Point(16, 431);
            label8.Name = "label8";
            label8.Size = new Size(750, 28);
            label8.TabIndex = 51;
            label8.Text = "только неоткрытые клетки с минами, неважно, с флажками или без них.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 17F);
            label7.ForeColor = Color.FromArgb(87, 166, 67);
            label7.Location = new Point(16, 403);
            label7.Name = "label7";
            label7.Size = new Size(960, 28);
            label7.TabIndex = 50;
            label7.Text = "можно пометить клетку флажком правой кнопкой. Победа наступает, когда на поле остаются";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Impact", 17F);
            labelInfo.ForeColor = Color.FromArgb(87, 166, 67);
            labelInfo.Location = new Point(16, 319);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(949, 28);
            labelInfo.TabIndex = 47;
            labelInfo.Text = "Цель игры Сапер – вскрыть пустые ячейки, не вскрыв при этом ни одной, содержащей мину.";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Impact", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.FromArgb(87, 166, 67);
            labelName.Location = new Point(442, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(148, 59);
            labelName.TabIndex = 0;
            labelName.Text = "Сапер";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 17F);
            label6.ForeColor = Color.FromArgb(87, 166, 67);
            label6.Location = new Point(16, 375);
            label6.Name = "label6";
            label6.Size = new Size(984, 28);
            label6.TabIndex = 49;
            label6.Text = "Если в ней будет находиться мина, вы проиграете. Чтобы случайно не нажать по клетке с миной,";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 17F);
            label4.ForeColor = Color.FromArgb(87, 166, 67);
            label4.Location = new Point(276, 542);
            label4.Name = "label4";
            label4.Size = new Size(280, 28);
            label4.TabIndex = 46;
            label4.Text = "- Свободная от мин клетка";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 17F);
            label5.ForeColor = Color.FromArgb(87, 166, 67);
            label5.Location = new Point(16, 347);
            label5.Name = "label5";
            label5.Size = new Size(1003, 28);
            label5.TabIndex = 48;
            label5.Text = "Игра начинается с первого клика по любой ячейке на поле. При клике на ячейке, она открывается.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 17F);
            label3.ForeColor = Color.FromArgb(87, 166, 67);
            label3.Location = new Point(276, 504);
            label3.Name = "label3";
            label3.Size = new Size(255, 28);
            label3.TabIndex = 45;
            label3.Text = "- Непроверенная клетка";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(26, 26, 26);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(16, 467);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 17F);
            label2.ForeColor = Color.FromArgb(87, 166, 67);
            label2.Location = new Point(276, 612);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 44;
            label2.Text = "- Мина.";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(26, 26, 26);
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = Properties.Resources._4;
            pictureBox4.Location = new Point(112, 467);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 17F);
            label1.ForeColor = Color.FromArgb(87, 166, 67);
            label1.Location = new Point(276, 576);
            label1.Name = "label1";
            label1.Size = new Size(853, 28);
            label1.TabIndex = 43;
            label1.Text = "-нужен, чтобы помечать потенциально \"заминированные\" клетки правой кнопкой.";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(26, 26, 26);
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = Properties.Resources._5;
            pictureBox5.Location = new Point(144, 467);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // labelT1
            // 
            labelT1.AutoSize = true;
            labelT1.Font = new Font("Impact", 17F);
            labelT1.ForeColor = Color.FromArgb(87, 166, 67);
            labelT1.Location = new Point(276, 467);
            labelT1.Name = "labelT1";
            labelT1.Size = new Size(415, 28);
            labelT1.TabIndex = 42;
            labelT1.Text = "- Количество мин рядом с этой клеткой.";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(26, 26, 26);
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = Properties.Resources._3;
            pictureBox3.Location = new Point(80, 467);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // pictureBoxOpen
            // 
            pictureBoxOpen.BackColor = Color.FromArgb(26, 26, 26);
            pictureBoxOpen.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxOpen.Image = Properties.Resources.open;
            pictureBoxOpen.Location = new Point(240, 540);
            pictureBoxOpen.Name = "pictureBoxOpen";
            pictureBoxOpen.Size = new Size(30, 30);
            pictureBoxOpen.TabIndex = 41;
            pictureBoxOpen.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(26, 26, 26);
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Image = Properties.Resources._6;
            pictureBox6.Location = new Point(176, 467);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(26, 26, 26);
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Image = Properties.Resources._7;
            pictureBox7.Location = new Point(208, 467);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.TabIndex = 40;
            pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(26, 26, 26);
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(48, 467);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxZero
            // 
            pictureBoxZero.BackColor = Color.FromArgb(26, 26, 26);
            pictureBoxZero.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxZero.Image = Properties.Resources.zero;
            pictureBoxZero.Location = new Point(240, 504);
            pictureBoxZero.Name = "pictureBoxZero";
            pictureBoxZero.Size = new Size(30, 30);
            pictureBoxZero.TabIndex = 36;
            pictureBoxZero.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(26, 26, 26);
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Image = Properties.Resources._8;
            pictureBox8.Location = new Point(240, 467);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.TabIndex = 39;
            pictureBox8.TabStop = false;
            // 
            // pictureBoxMine
            // 
            pictureBoxMine.BackColor = Color.FromArgb(26, 26, 26);
            pictureBoxMine.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMine.Image = Properties.Resources.mina;
            pictureBoxMine.Location = new Point(240, 612);
            pictureBoxMine.Name = "pictureBoxMine";
            pictureBoxMine.Size = new Size(30, 30);
            pictureBoxMine.TabIndex = 37;
            pictureBoxMine.TabStop = false;
            // 
            // pictureBoxFlag
            // 
            pictureBoxFlag.BackColor = Color.FromArgb(26, 26, 26);
            pictureBoxFlag.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFlag.Image = Properties.Resources.flag1;
            pictureBoxFlag.Location = new Point(240, 576);
            pictureBoxFlag.Name = "pictureBoxFlag";
            pictureBoxFlag.Size = new Size(30, 30);
            pictureBoxFlag.TabIndex = 38;
            pictureBoxFlag.TabStop = false;
            // 
            // trackBarY
            // 
            trackBarY.Location = new Point(12, 125);
            trackBarY.Maximum = 31;
            trackBarY.Minimum = 10;
            trackBarY.Name = "trackBarY";
            trackBarY.Size = new Size(495, 45);
            trackBarY.TabIndex = 16;
            trackBarY.TickFrequency = 0;
            trackBarY.TickStyle = TickStyle.None;
            trackBarY.Value = 31;
            trackBarY.ValueChanged += trackBarY_ValueChanged;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(50, 50, 50);
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStart.ForeColor = Color.FromArgb(87, 166, 67);
            buttonStart.Location = new Point(208, 217);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(541, 88);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Построить поле";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.MouseClick += buttonStart_MouseClick;
            // 
            // trackBarX
            // 
            trackBarX.Location = new Point(12, 74);
            trackBarX.Maximum = 59;
            trackBarX.Minimum = 10;
            trackBarX.Name = "trackBarX";
            trackBarX.Size = new Size(495, 45);
            trackBarX.TabIndex = 15;
            trackBarX.TickFrequency = 0;
            trackBarX.TickStyle = TickStyle.None;
            trackBarX.Value = 59;
            trackBarX.ValueChanged += trackBarX_ValueChanged;
            // 
            // trackBarBomb
            // 
            trackBarBomb.Location = new Point(16, 176);
            trackBarBomb.Maximum = 333;
            trackBarBomb.Minimum = 1;
            trackBarBomb.Name = "trackBarBomb";
            trackBarBomb.Size = new Size(495, 45);
            trackBarBomb.TabIndex = 17;
            trackBarBomb.TickFrequency = 0;
            trackBarBomb.TickStyle = TickStyle.None;
            trackBarBomb.Value = 190;
            trackBarBomb.ValueChanged += trackBarBomb_ValueChanged;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Impact", 20F);
            labelX.ForeColor = Color.FromArgb(87, 166, 67);
            labelX.Location = new Point(513, 65);
            labelX.Name = "labelX";
            labelX.Size = new Size(477, 34);
            labelX.TabIndex = 18;
            labelX.Text = "59 - количество клеток по горизонтали";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Font = new Font("Impact", 20F);
            labelY.ForeColor = Color.FromArgb(87, 166, 67);
            labelY.Location = new Point(513, 116);
            labelY.Name = "labelY";
            labelY.Size = new Size(449, 34);
            labelY.TabIndex = 19;
            labelY.Text = "31 - количество клеток по вертикали";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Impact", 20F);
            labelB.ForeColor = Color.FromArgb(87, 166, 67);
            labelB.Location = new Point(517, 164);
            labelB.Name = "labelB";
            labelB.Size = new Size(461, 34);
            labelB.TabIndex = 20;
            labelB.Text = "190 - количество мин. Оптимально:182";
            // 
            // labelNumMines
            // 
            labelNumMines.AutoSize = true;
            labelNumMines.Font = new Font("Impact", 20F);
            labelNumMines.ForeColor = Color.FromArgb(87, 166, 67);
            labelNumMines.Location = new Point(12, 9);
            labelNumMines.Name = "labelNumMines";
            labelNumMines.Size = new Size(187, 34);
            labelNumMines.TabIndex = 29;
            labelNumMines.Text = "Осталось мин: ";
            labelNumMines.Visible = false;
            // 
            // buttonReturnToMenu
            // 
            buttonReturnToMenu.BackColor = Color.FromArgb(50, 50, 50);
            buttonReturnToMenu.FlatStyle = FlatStyle.Popup;
            buttonReturnToMenu.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReturnToMenu.ForeColor = Color.FromArgb(87, 166, 67);
            buttonReturnToMenu.Location = new Point(332, 0);
            buttonReturnToMenu.Name = "buttonReturnToMenu";
            buttonReturnToMenu.Size = new Size(541, 43);
            buttonReturnToMenu.TabIndex = 30;
            buttonReturnToMenu.Text = "Вернуться в меню";
            buttonReturnToMenu.UseVisualStyleBackColor = false;
            buttonReturnToMenu.Visible = false;
            buttonReturnToMenu.MouseClick += buttonReturnToMenu_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1228, 888);
            Controls.Add(buttonReturnToMenu);
            Controls.Add(labelNumMines);
            Controls.Add(panel1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saper (Dark Theme)";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZero).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarY).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarX).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBomb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label labelInfo;
        private Label labelName;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox5;
        private Label labelT1;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxOpen;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxZero;
        private PictureBox pictureBox8;
        private PictureBox pictureBoxMine;
        private PictureBox pictureBoxFlag;
        private TrackBar trackBarY;
        private Button buttonStart;
        private TrackBar trackBarX;
        private TrackBar trackBarBomb;
        private Label labelX;
        private Label labelY;
        private Label labelB;
        private Label labelNumMines;
        private Button buttonReturnToMenu;
        private Label label8;
        private Label label7;
    }
}
