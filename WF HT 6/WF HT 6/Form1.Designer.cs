namespace WF_HT_6
{
    partial class BestOil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestOil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbproil = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudhrn = new System.Windows.Forms.NumericUpDown();
            this.nudlitr = new System.Windows.Forms.NumericUpDown();
            this.rbamoil = new System.Windows.Forms.RadioButton();
            this.rbsum = new System.Windows.Forms.RadioButton();
            this.gbSumOil = new System.Windows.Forms.GroupBox();
            this.lbOilSum = new System.Windows.Forms.Label();
            this.cbOil = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbProdSum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHotD = new System.Windows.Forms.Label();
            this.nudHotD = new System.Windows.Forms.NumericUpDown();
            this.lbGamb = new System.Windows.Forms.Label();
            this.lbEspr = new System.Windows.Forms.Label();
            this.lbTea = new System.Windows.Forms.Label();
            this.chbHotD = new System.Windows.Forms.CheckBox();
            this.nudTea = new System.Windows.Forms.NumericUpDown();
            this.nudEspr = new System.Windows.Forms.NumericUpDown();
            this.nudGamb = new System.Windows.Forms.NumericUpDown();
            this.chbTea = new System.Windows.Forms.CheckBox();
            this.chbEspr = new System.Windows.Forms.CheckBox();
            this.chbGamb = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btGeneral = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.lbDay = new System.Windows.Forms.ListBox();
            this.lbGen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudhrn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudlitr)).BeginInit();
            this.gbSumOil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lbproil);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.gbSumOil);
            this.groupBox1.Controls.Add(this.cbOil);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // lbproil
            // 
            this.lbproil.AutoSize = true;
            this.lbproil.Location = new System.Drawing.Point(222, 81);
            this.lbproil.Name = "lbproil";
            this.lbproil.Size = new System.Drawing.Size(34, 19);
            this.lbproil.TabIndex = 8;
            this.lbproil.Text = "ГРН";
            this.toolTip1.SetToolTip(this.lbproil, "Цена на сегодня");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Бензин";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudhrn);
            this.panel1.Controls.Add(this.nudlitr);
            this.panel1.Controls.Add(this.rbamoil);
            this.panel1.Controls.Add(this.rbsum);
            this.panel1.Location = new System.Drawing.Point(15, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 156);
            this.panel1.TabIndex = 5;
            // 
            // nudhrn
            // 
            this.nudhrn.DecimalPlaces = 2;
            this.nudhrn.Location = new System.Drawing.Point(155, 88);
            this.nudhrn.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudhrn.Name = "nudhrn";
            this.nudhrn.Size = new System.Drawing.Size(120, 27);
            this.nudhrn.TabIndex = 6;
            this.toolTip1.SetToolTip(this.nudhrn, "Выберите или напишите сумму в грн");
            this.nudhrn.ValueChanged += new System.EventHandler(this.nudhrn_ValueChanged);
            // 
            // nudlitr
            // 
            this.nudlitr.Location = new System.Drawing.Point(155, 36);
            this.nudlitr.Name = "nudlitr";
            this.nudlitr.Size = new System.Drawing.Size(120, 27);
            this.nudlitr.TabIndex = 5;
            this.toolTip1.SetToolTip(this.nudlitr, "Выберите количество литров");
            this.nudlitr.ValueChanged += new System.EventHandler(this.nudlitr_ValueChanged);
            // 
            // rbamoil
            // 
            this.rbamoil.AutoSize = true;
            this.rbamoil.Location = new System.Drawing.Point(18, 36);
            this.rbamoil.Name = "rbamoil";
            this.rbamoil.Size = new System.Drawing.Size(122, 23);
            this.rbamoil.TabIndex = 3;
            this.rbamoil.TabStop = true;
            this.rbamoil.Text = "Количество, л";
            this.toolTip1.SetToolTip(this.rbamoil, "Выберите для расчета по количеству литров");
            this.rbamoil.UseVisualStyleBackColor = true;
            this.rbamoil.CheckedChanged += new System.EventHandler(this.rbamoil_CheckedChanged);
            // 
            // rbsum
            // 
            this.rbsum.AutoSize = true;
            this.rbsum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbsum.Location = new System.Drawing.Point(18, 93);
            this.rbsum.Name = "rbsum";
            this.rbsum.Size = new System.Drawing.Size(104, 23);
            this.rbsum.TabIndex = 4;
            this.rbsum.TabStop = true;
            this.rbsum.Text = "Сумма, грн";
            this.toolTip1.SetToolTip(this.rbsum, "Выберите для расчета литража исходя из суммы грн");
            this.rbsum.UseVisualStyleBackColor = true;
            this.rbsum.CheckedChanged += new System.EventHandler(this.rbsum_CheckedChanged);
            // 
            // gbSumOil
            // 
            this.gbSumOil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSumOil.Controls.Add(this.lbOilSum);
            this.gbSumOil.Location = new System.Drawing.Point(15, 291);
            this.gbSumOil.Name = "gbSumOil";
            this.gbSumOil.Size = new System.Drawing.Size(286, 100);
            this.gbSumOil.TabIndex = 1;
            this.gbSumOil.TabStop = false;
            this.gbSumOil.Text = "Всего по заправке:";
            // 
            // lbOilSum
            // 
            this.lbOilSum.AutoSize = true;
            this.lbOilSum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOilSum.Location = new System.Drawing.Point(91, 39);
            this.lbOilSum.Name = "lbOilSum";
            this.lbOilSum.Size = new System.Drawing.Size(84, 26);
            this.lbOilSum.TabIndex = 3;
            this.lbOilSum.Text = "0,00 грн";
            // 
            // cbOil
            // 
            this.cbOil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOil.FormattingEnabled = true;
            this.cbOil.Location = new System.Drawing.Point(215, 27);
            this.cbOil.Name = "cbOil";
            this.cbOil.Size = new System.Drawing.Size(86, 27);
            this.cbOil.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cbOil, "Выберите марку бензина");
            this.cbOil.SelectedIndexChanged += new System.EventHandler(this.cbOil_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 397);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кафе";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Navy;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2017, 11, 11, 21, 5, 59, 0);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbProdSum);
            this.groupBox5.Location = new System.Drawing.Point(16, 291);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Всего по продуктам:";
            // 
            // lbProdSum
            // 
            this.lbProdSum.AutoSize = true;
            this.lbProdSum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProdSum.Location = new System.Drawing.Point(109, 39);
            this.lbProdSum.Name = "lbProdSum";
            this.lbProdSum.Size = new System.Drawing.Size(84, 26);
            this.lbProdSum.TabIndex = 4;
            this.lbProdSum.Text = "0,00 грн";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbHotD);
            this.panel2.Controls.Add(this.nudHotD);
            this.panel2.Controls.Add(this.lbGamb);
            this.panel2.Controls.Add(this.lbEspr);
            this.panel2.Controls.Add(this.lbTea);
            this.panel2.Controls.Add(this.chbHotD);
            this.panel2.Controls.Add(this.nudTea);
            this.panel2.Controls.Add(this.nudEspr);
            this.panel2.Controls.Add(this.nudGamb);
            this.panel2.Controls.Add(this.chbTea);
            this.panel2.Controls.Add(this.chbEspr);
            this.panel2.Controls.Add(this.chbGamb);
            this.panel2.Location = new System.Drawing.Point(18, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 171);
            this.panel2.TabIndex = 3;
            // 
            // lbHotD
            // 
            this.lbHotD.AutoSize = true;
            this.lbHotD.Location = new System.Drawing.Point(201, 16);
            this.lbHotD.Name = "lbHotD";
            this.lbHotD.Size = new System.Drawing.Size(0, 19);
            this.lbHotD.TabIndex = 6;
            // 
            // nudHotD
            // 
            this.nudHotD.Location = new System.Drawing.Point(113, 14);
            this.nudHotD.Name = "nudHotD";
            this.nudHotD.Size = new System.Drawing.Size(45, 27);
            this.nudHotD.TabIndex = 3;
            this.toolTip1.SetToolTip(this.nudHotD, "Выберите количество\r\nи нажмите =");
            this.nudHotD.ValueChanged += new System.EventHandler(this.nudHotD_ValueChanged);
            // 
            // lbGamb
            // 
            this.lbGamb.AutoSize = true;
            this.lbGamb.Location = new System.Drawing.Point(201, 53);
            this.lbGamb.Name = "lbGamb";
            this.lbGamb.Size = new System.Drawing.Size(0, 19);
            this.lbGamb.TabIndex = 3;
            // 
            // lbEspr
            // 
            this.lbEspr.AutoSize = true;
            this.lbEspr.Location = new System.Drawing.Point(201, 93);
            this.lbEspr.Name = "lbEspr";
            this.lbEspr.Size = new System.Drawing.Size(0, 19);
            this.lbEspr.TabIndex = 4;
            // 
            // lbTea
            // 
            this.lbTea.AutoSize = true;
            this.lbTea.Location = new System.Drawing.Point(201, 134);
            this.lbTea.Name = "lbTea";
            this.lbTea.Size = new System.Drawing.Size(0, 19);
            this.lbTea.TabIndex = 5;
            // 
            // chbHotD
            // 
            this.chbHotD.AutoSize = true;
            this.chbHotD.Location = new System.Drawing.Point(8, 15);
            this.chbHotD.Name = "chbHotD";
            this.chbHotD.Size = new System.Drawing.Size(78, 23);
            this.chbHotD.TabIndex = 3;
            this.chbHotD.Text = "Хот Дог";
            this.toolTip1.SetToolTip(this.chbHotD, "Выберите нужный товар, \r\nчтобы указать его количество");
            this.chbHotD.UseVisualStyleBackColor = true;
            // 
            // nudTea
            // 
            this.nudTea.Location = new System.Drawing.Point(113, 133);
            this.nudTea.Name = "nudTea";
            this.nudTea.Size = new System.Drawing.Size(45, 27);
            this.nudTea.TabIndex = 5;
            this.toolTip1.SetToolTip(this.nudTea, "Выберите количество\r\nи нажмите =");
            this.nudTea.ValueChanged += new System.EventHandler(this.nudTea_ValueChanged);
            // 
            // nudEspr
            // 
            this.nudEspr.Location = new System.Drawing.Point(113, 93);
            this.nudEspr.Name = "nudEspr";
            this.nudEspr.Size = new System.Drawing.Size(45, 27);
            this.nudEspr.TabIndex = 4;
            this.toolTip1.SetToolTip(this.nudEspr, "Выберите количество\r\nи нажмите =");
            this.nudEspr.ValueChanged += new System.EventHandler(this.nudEspr_ValueChanged);
            // 
            // nudGamb
            // 
            this.nudGamb.Location = new System.Drawing.Point(113, 51);
            this.nudGamb.Name = "nudGamb";
            this.nudGamb.Size = new System.Drawing.Size(45, 27);
            this.nudGamb.TabIndex = 3;
            this.toolTip1.SetToolTip(this.nudGamb, "Выберите количество\r\nи нажмите =");
            this.nudGamb.ValueChanged += new System.EventHandler(this.nudGamb_ValueChanged);
            // 
            // chbTea
            // 
            this.chbTea.AutoSize = true;
            this.chbTea.Location = new System.Drawing.Point(8, 133);
            this.chbTea.Name = "chbTea";
            this.chbTea.Size = new System.Drawing.Size(54, 23);
            this.chbTea.TabIndex = 2;
            this.chbTea.Text = "Чай";
            this.toolTip1.SetToolTip(this.chbTea, "Выберите нужный товар, \r\nчтобы указать его количество\r\n");
            this.chbTea.UseVisualStyleBackColor = true;
            // 
            // chbEspr
            // 
            this.chbEspr.AutoSize = true;
            this.chbEspr.Location = new System.Drawing.Point(8, 92);
            this.chbEspr.Name = "chbEspr";
            this.chbEspr.Size = new System.Drawing.Size(90, 23);
            this.chbEspr.TabIndex = 1;
            this.chbEspr.Text = "Эспрессо";
            this.toolTip1.SetToolTip(this.chbEspr, "Выберите нужный товар, \r\nчтобы указать его количество\r\n");
            this.chbEspr.UseVisualStyleBackColor = true;
            // 
            // chbGamb
            // 
            this.chbGamb.AutoSize = true;
            this.chbGamb.Location = new System.Drawing.Point(8, 51);
            this.chbGamb.Name = "chbGamb";
            this.chbGamb.Size = new System.Drawing.Size(99, 23);
            this.chbGamb.TabIndex = 0;
            this.chbGamb.Text = "Гамбургер";
            this.toolTip1.SetToolTip(this.chbGamb, "Выберите нужный товар, \r\nчтобы указать его количество\r\n");
            this.chbGamb.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btGeneral);
            this.groupBox3.Controls.Add(this.btClear);
            this.groupBox3.Controls.Add(this.lbDay);
            this.groupBox3.Controls.Add(this.lbGen);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(12, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 173);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ИТОГО:";
            // 
            // btGeneral
            // 
            this.btGeneral.Location = new System.Drawing.Point(345, 116);
            this.btGeneral.Name = "btGeneral";
            this.btGeneral.Size = new System.Drawing.Size(159, 42);
            this.btGeneral.TabIndex = 7;
            this.btGeneral.Text = "Общая выручка";
            this.toolTip1.SetToolTip(this.btGeneral, "Нажмите, чтобы увидеть всю выручку");
            this.btGeneral.UseVisualStyleBackColor = true;
            this.btGeneral.Click += new System.EventHandler(this.btGeneral_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(12, 116);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(99, 42);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Очистить";
            this.toolTip1.SetToolTip(this.btClear, "Нажмите, \r\nчтобы сохранить данные\r\n и очистить окно");
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbDay
            // 
            this.lbDay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbDay.FormattingEnabled = true;
            this.lbDay.ItemHeight = 19;
            this.lbDay.Location = new System.Drawing.Point(521, 21);
            this.lbDay.Name = "lbDay";
            this.lbDay.ScrollAlwaysVisible = true;
            this.lbDay.Size = new System.Drawing.Size(131, 137);
            this.lbDay.TabIndex = 5;
            // 
            // lbGen
            // 
            this.lbGen.AutoSize = true;
            this.lbGen.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGen.Location = new System.Drawing.Point(248, 49);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(148, 45);
            this.lbGen.TabIndex = 4;
            this.lbGen.Text = "0,00 грн";
            this.toolTip1.SetToolTip(this.lbGen, "ИТОГ");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(111, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.toolTip1.SetToolTip(this.button1, "нажмите, чтобы рассчитать все суммы");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "BestOil";
            // 
            // BestOil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 650);
            this.Name = "BestOil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.toolTip1.SetToolTip(this, "BestOil КАССА");
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudhrn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudlitr)).EndInit();
            this.gbSumOil.ResumeLayout(false);
            this.gbSumOil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbOil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rbsum;
        private System.Windows.Forms.RadioButton rbamoil;
        private System.Windows.Forms.GroupBox gbSumOil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudhrn;
        private System.Windows.Forms.NumericUpDown nudlitr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudTea;
        private System.Windows.Forms.NumericUpDown nudEspr;
        private System.Windows.Forms.NumericUpDown nudGamb;
        private System.Windows.Forms.CheckBox chbTea;
        private System.Windows.Forms.CheckBox chbEspr;
        private System.Windows.Forms.CheckBox chbGamb;
        private System.Windows.Forms.Label lbOilSum;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbProdSum;
        private System.Windows.Forms.Label lbHotD;
        private System.Windows.Forms.NumericUpDown nudHotD;
        private System.Windows.Forms.Label lbEspr;
        private System.Windows.Forms.Label lbTea;
        private System.Windows.Forms.CheckBox chbHotD;
        private System.Windows.Forms.Label lbGen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbproil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbGamb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lbDay;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btGeneral;
    }
}

