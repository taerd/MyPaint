using System.Windows.Forms;

namespace NewPaint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxEraser = new System.Windows.Forms.PictureBox();
            this.pictureBoxPen = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSystemColorsControl = new System.Windows.Forms.Panel();
            this.panelLime = new System.Windows.Forms.Panel();
            this.panelAquamarine = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCol2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCol1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar = new System.Windows.Forms.PictureBox();
            this.pictureBoxEllipse = new System.Windows.Forms.PictureBox();
            this.pictureBoxRectangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(12, 104);
            this.panelMain.MinimumSize = new System.Drawing.Size(573, 297);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(573, 297);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseUp);
            this.panelMain.Resize += new System.EventHandler(this.panelMain_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxEraser);
            this.groupBox1.Controls.Add(this.pictureBoxPen);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // pictureBoxEraser
            // 
            this.pictureBoxEraser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEraser.Image")));
            this.pictureBoxEraser.Location = new System.Drawing.Point(89, 28);
            this.pictureBoxEraser.Name = "pictureBoxEraser";
            this.pictureBoxEraser.Size = new System.Drawing.Size(24, 22);
            this.pictureBoxEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEraser.TabIndex = 1;
            this.pictureBoxEraser.TabStop = false;
            this.pictureBoxEraser.Click += new System.EventHandler(this.ChangeItem);
            // 
            // pictureBoxPen
            // 
            this.pictureBoxPen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPen.Image")));
            this.pictureBoxPen.Location = new System.Drawing.Point(22, 28);
            this.pictureBoxPen.Name = "pictureBoxPen";
            this.pictureBoxPen.Size = new System.Drawing.Size(29, 27);
            this.pictureBoxPen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPen.TabIndex = 0;
            this.pictureBoxPen.TabStop = false;
            this.pictureBoxPen.Click += new System.EventHandler(this.ChangeItem);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panelSystemColorsControl);
            this.groupBox2.Controls.Add(this.panelLime);
            this.groupBox2.Controls.Add(this.panelAquamarine);
            this.groupBox2.Controls.Add(this.panelPurple);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(158, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(99, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 17);
            this.panel1.TabIndex = 9;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelSystemColorsControl
            // 
            this.panelSystemColorsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSystemColorsControl.Location = new System.Drawing.Point(99, 21);
            this.panelSystemColorsControl.Name = "panelSystemColorsControl";
            this.panelSystemColorsControl.Size = new System.Drawing.Size(17, 17);
            this.panelSystemColorsControl.TabIndex = 8;
            this.panelSystemColorsControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelLime
            // 
            this.panelLime.BackColor = System.Drawing.Color.Lime;
            this.panelLime.Location = new System.Drawing.Point(76, 44);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(17, 17);
            this.panelLime.TabIndex = 7;
            this.panelLime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelAquamarine
            // 
            this.panelAquamarine.BackColor = System.Drawing.Color.Aquamarine;
            this.panelAquamarine.Location = new System.Drawing.Point(76, 21);
            this.panelAquamarine.Name = "panelAquamarine";
            this.panelAquamarine.Size = new System.Drawing.Size(17, 17);
            this.panelAquamarine.TabIndex = 6;
            this.panelAquamarine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(52, 44);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(17, 17);
            this.panelPurple.TabIndex = 5;
            this.panelPurple.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(52, 21);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(17, 17);
            this.panelBlue.TabIndex = 4;
            this.panelBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(29, 44);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(17, 17);
            this.panelGreen.TabIndex = 3;
            this.panelGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(29, 21);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(17, 17);
            this.panelYellow.TabIndex = 2;
            this.panelYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(6, 44);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(17, 17);
            this.panelRed.TabIndex = 1;
            this.panelRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(6, 21);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(17, 17);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.panelCol2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.panelCol1);
            this.groupBox3.Location = new System.Drawing.Point(303, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 67);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Основной цвет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цвет 2";
            // 
            // panelCol2
            // 
            this.panelCol2.Location = new System.Drawing.Point(92, 21);
            this.panelCol2.Name = "panelCol2";
            this.panelCol2.Size = new System.Drawing.Size(25, 25);
            this.panelCol2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Цвет 1";
            // 
            // panelCol1
            // 
            this.panelCol1.BackColor = System.Drawing.Color.Black;
            this.panelCol1.Location = new System.Drawing.Point(21, 21);
            this.panelCol1.Name = "panelCol1";
            this.panelCol1.Size = new System.Drawing.Size(25, 25);
            this.panelCol1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxArrow);
            this.groupBox4.Controls.Add(this.pictureBoxStar);
            this.groupBox4.Controls.Add(this.pictureBoxEllipse);
            this.groupBox4.Controls.Add(this.pictureBoxRectangle);
            this.groupBox4.Controls.Add(this.pictureBoxLine);
            this.groupBox4.Location = new System.Drawing.Point(448, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(139, 67);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фигуры";
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(84, 44);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(22, 21);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxArrow.TabIndex = 4;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // pictureBoxStar
            // 
            this.pictureBoxStar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStar.Image")));
            this.pictureBoxStar.Location = new System.Drawing.Point(39, 45);
            this.pictureBoxStar.Name = "pictureBoxStar";
            this.pictureBoxStar.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStar.TabIndex = 3;
            this.pictureBoxStar.TabStop = false;
            this.pictureBoxStar.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // pictureBoxEllipse
            // 
            this.pictureBoxEllipse.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEllipse.Image")));
            this.pictureBoxEllipse.Location = new System.Drawing.Point(108, 21);
            this.pictureBoxEllipse.Name = "pictureBoxEllipse";
            this.pictureBoxEllipse.Size = new System.Drawing.Size(24, 21);
            this.pictureBoxEllipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEllipse.TabIndex = 2;
            this.pictureBoxEllipse.TabStop = false;
            this.pictureBoxEllipse.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // pictureBoxRectangle
            // 
            this.pictureBoxRectangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRectangle.Image")));
            this.pictureBoxRectangle.Location = new System.Drawing.Point(59, 21);
            this.pictureBoxRectangle.Name = "pictureBoxRectangle";
            this.pictureBoxRectangle.Size = new System.Drawing.Size(24, 20);
            this.pictureBoxRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRectangle.TabIndex = 1;
            this.pictureBoxRectangle.TabStop = false;
            this.pictureBoxRectangle.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(15, 21);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(24, 20);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLine.TabIndex = 0;
            this.pictureBoxLine.TabStop = false;
            this.pictureBoxLine.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBoxAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Фаил";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxOpen,
            this.toolStripTextBoxSave,
            this.toolStripComboBoxClear});
            this.toolStripTextBox1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTextBox1.Image")));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(79, 24);
            this.toolStripTextBox1.Text = "Фаил";
            // 
            // toolStripTextBoxOpen
            // 
            this.toolStripTextBoxOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen1,
            this.toolStripMenuItemOpen2});
            this.toolStripTextBoxOpen.Name = "toolStripTextBoxOpen";
            this.toolStripTextBoxOpen.Size = new System.Drawing.Size(166, 26);
            this.toolStripTextBoxOpen.Text = "Открыть";
            // 
            // toolStripMenuItemOpen1
            // 
            this.toolStripMenuItemOpen1.Name = "toolStripMenuItemOpen1";
            this.toolStripMenuItemOpen1.Size = new System.Drawing.Size(354, 26);
            this.toolStripMenuItemOpen1.Text = "Не изменяя размер панели";
            this.toolStripMenuItemOpen1.Click += new System.EventHandler(this.toolStripMenuItemOpen1_Click);
            // 
            // toolStripMenuItemOpen2
            // 
            this.toolStripMenuItemOpen2.Name = "toolStripMenuItemOpen2";
            this.toolStripMenuItemOpen2.Size = new System.Drawing.Size(354, 26);
            this.toolStripMenuItemOpen2.Text = "Изменяя размер панели по картинке";
            this.toolStripMenuItemOpen2.Click += new System.EventHandler(this.toolStripMenuItemOpen2_Click);
            // 
            // toolStripTextBoxSave
            // 
            this.toolStripTextBoxSave.Name = "toolStripTextBoxSave";
            this.toolStripTextBoxSave.Size = new System.Drawing.Size(166, 26);
            this.toolStripTextBoxSave.Text = "Сохранить";
            this.toolStripTextBoxSave.Click += new System.EventHandler(this.toolStripTextBoxSave_Click);
            // 
            // toolStripComboBoxClear
            // 
            this.toolStripComboBoxClear.Name = "toolStripComboBoxClear";
            this.toolStripComboBoxClear.Size = new System.Drawing.Size(166, 26);
            this.toolStripComboBoxClear.Text = "Очистить";
            this.toolStripComboBoxClear.Click += new System.EventHandler(this.toolStripComboBoxClear_Click);
            // 
            // toolStripTextBoxAbout
            // 
            this.toolStripTextBoxAbout.Name = "toolStripTextBoxAbout";
            this.toolStripTextBoxAbout.Size = new System.Drawing.Size(118, 24);
            this.toolStripTextBoxAbout.Text = "О программе";
            this.toolStripTextBoxAbout.Click += new System.EventHandler(this.toolStripTextBoxAbout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(532, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "3";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Толщина";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1111111, 111111111);
            this.MinimumSize = new System.Drawing.Size(615, 460);
            this.Name = "Form1";
            this.Text = "Paint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBoxOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBoxSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBoxAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxPen;
        private System.Windows.Forms.PictureBox pictureBoxEraser;
        private Panel panelYellow;
        private Panel panelRed;
        private Panel panelBlack;
        private Panel panel1;
        private Panel panelSystemColorsControl;
        private Panel panelLime;
        private Panel panelAquamarine;
        private Panel panelPurple;
        private Panel panelBlue;
        private Panel panelGreen;
        private Label label4;
        private Panel panelCol2;
        private Label label3;
        private Panel panelCol1;
        private PictureBox pictureBoxLine;
        private PictureBox pictureBoxArrow;
        private PictureBox pictureBoxStar;
        private PictureBox pictureBoxEllipse;
        private PictureBox pictureBoxRectangle;
        private ComboBox comboBox1;
        private ToolStripMenuItem toolStripComboBoxClear;
        private Label label5;
    }
}

