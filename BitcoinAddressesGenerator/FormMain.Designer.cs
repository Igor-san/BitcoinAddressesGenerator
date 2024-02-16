namespace BitcoinAddressesGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.numericUpDownGenerationCount = new System.Windows.Forms.NumericUpDown();
            this.textBoxSaveTo = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.progressBarUpdateBase = new System.Windows.Forms.ProgressBar();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonGenerateRandom = new System.Windows.Forms.Button();
            this.timerThread = new System.Windows.Forms.Timer(this.components);
            this.buttonGenerateText = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBoxDelimiter = new System.Windows.Forms.TextBox();
            this.buttonSaveAllToFile = new System.Windows.Forms.Button();
            this.checkBoxSegwitP2SH = new System.Windows.Forms.CheckBox();
            this.checkBoxSegwit = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonBothKey = new System.Windows.Forms.RadioButton();
            this.numericUpDownProcessCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxFlushFile = new System.Windows.Forms.CheckBox();
            this.textBoxResultsFlushFile = new System.Windows.Forms.TextBox();
            this.buttonSelectFlushFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownFlushEveryCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonCompressedKey = new System.Windows.Forms.RadioButton();
            this.radioButtonUnCompressedKey = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxWIFKey = new System.Windows.Forms.CheckBox();
            this.checkBoxHexPrivateKey = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProcessCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlushEveryCount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownGenerationCount
            // 
            this.numericUpDownGenerationCount.Location = new System.Drawing.Point(18, 13);
            this.numericUpDownGenerationCount.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDownGenerationCount.Name = "numericUpDownGenerationCount";
            this.numericUpDownGenerationCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGenerationCount.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numericUpDownGenerationCount, "число случайных генераций");
            this.numericUpDownGenerationCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // textBoxSaveTo
            // 
            this.textBoxSaveTo.Location = new System.Drawing.Point(18, 44);
            this.textBoxSaveTo.Name = "textBoxSaveTo";
            this.textBoxSaveTo.Size = new System.Drawing.Size(360, 20);
            this.textBoxSaveTo.TabIndex = 3;
            this.textBoxSaveTo.Text = "D:\\\\output.txt";
            this.toolTip1.SetToolTip(this.textBoxSaveTo, "какой файл использовать для случайных строк");
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxLog.Location = new System.Drawing.Point(0, 434);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(811, 94);
            this.textBoxLog.TabIndex = 4;
            this.textBoxLog.WordWrap = false;
            // 
            // textBoxText
            // 
            this.textBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxText.Location = new System.Drawing.Point(3, 153);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxText.Size = new System.Drawing.Size(805, 201);
            this.textBoxText.TabIndex = 5;
            this.textBoxText.WordWrap = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(428, 42);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(156, 23);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Генерировать из файла";
            this.toolTip1.SetToolTip(this.buttonGenerate, "чтение семени из файла и генерация для каждого адреса");
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerateFromFile_Click);
            // 
            // progressBarUpdateBase
            // 
            this.progressBarUpdateBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarUpdateBase.Location = new System.Drawing.Point(0, 0);
            this.progressBarUpdateBase.Name = "progressBarUpdateBase";
            this.progressBarUpdateBase.Size = new System.Drawing.Size(730, 33);
            this.progressBarUpdateBase.TabIndex = 25;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(369, 10);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 27;
            this.labelCount.Text = "_";
            this.toolTip1.SetToolTip(this.labelCount, "счетчик");
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStop.Location = new System.Drawing.Point(730, 0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 33);
            this.buttonStop.TabIndex = 29;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonGenerateRandom
            // 
            this.buttonGenerateRandom.Location = new System.Drawing.Point(428, 10);
            this.buttonGenerateRandom.Name = "buttonGenerateRandom";
            this.buttonGenerateRandom.Size = new System.Drawing.Size(156, 23);
            this.buttonGenerateRandom.TabIndex = 30;
            this.buttonGenerateRandom.Text = "Генерировать случайно";
            this.toolTip1.SetToolTip(this.buttonGenerateRandom, "Генерировать случайное семя и из него адрес");
            this.buttonGenerateRandom.UseVisualStyleBackColor = true;
            this.buttonGenerateRandom.Click += new System.EventHandler(this.buttonGenerateRandom_Click);
            // 
            // timerThread
            // 
            this.timerThread.Tick += new System.EventHandler(this.timerThread_Tick);
            // 
            // buttonGenerateText
            // 
            this.buttonGenerateText.Location = new System.Drawing.Point(144, 10);
            this.buttonGenerateText.Name = "buttonGenerateText";
            this.buttonGenerateText.Size = new System.Drawing.Size(117, 22);
            this.buttonGenerateText.TabIndex = 31;
            this.buttonGenerateText.Text = "Случайные строки";
            this.toolTip1.SetToolTip(this.buttonGenerateText, "Генерация случайных строк в файл");
            this.buttonGenerateText.UseVisualStyleBackColor = true;
            this.buttonGenerateText.Click += new System.EventHandler(this.buttonGenerateText_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.FlatAppearance.BorderSize = 0;
            this.buttonSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFile.Image = global::BitcoinAddressesGenerator.Properties.Resources.openIcon;
            this.buttonSelectFile.Location = new System.Drawing.Point(384, 42);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(23, 23);
            this.buttonSelectFile.TabIndex = 33;
            this.toolTip1.SetToolTip(this.buttonSelectFile, "указать путь к файлу");
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // textBoxDelimiter
            // 
            this.textBoxDelimiter.Location = new System.Drawing.Point(346, 12);
            this.textBoxDelimiter.Name = "textBoxDelimiter";
            this.textBoxDelimiter.Size = new System.Drawing.Size(76, 20);
            this.textBoxDelimiter.TabIndex = 35;
            this.textBoxDelimiter.Tag = "";
            this.textBoxDelimiter.Text = " |";
            this.toolTip1.SetToolTip(this.textBoxDelimiter, "разграничитель между ключами");
            // 
            // buttonSaveAllToFile
            // 
            this.buttonSaveAllToFile.Location = new System.Drawing.Point(615, 28);
            this.buttonSaveAllToFile.Name = "buttonSaveAllToFile";
            this.buttonSaveAllToFile.Size = new System.Drawing.Size(78, 23);
            this.buttonSaveAllToFile.TabIndex = 34;
            this.buttonSaveAllToFile.Text = "все в файл";
            this.toolTip1.SetToolTip(this.buttonSaveAllToFile, "сохранить в файл ключи и адреса");
            this.buttonSaveAllToFile.UseVisualStyleBackColor = true;
            this.buttonSaveAllToFile.Click += new System.EventHandler(this.buttonSaveAllToFile_Click);
            // 
            // checkBoxSegwitP2SH
            // 
            this.checkBoxSegwitP2SH.AutoSize = true;
            this.checkBoxSegwitP2SH.Location = new System.Drawing.Point(254, 90);
            this.checkBoxSegwitP2SH.Name = "checkBoxSegwitP2SH";
            this.checkBoxSegwitP2SH.Size = new System.Drawing.Size(86, 17);
            this.checkBoxSegwitP2SH.TabIndex = 48;
            this.checkBoxSegwitP2SH.Text = "SegwitP2SH";
            this.toolTip1.SetToolTip(this.checkBoxSegwitP2SH, "адрес типа SegwitP2SH");
            this.checkBoxSegwitP2SH.UseVisualStyleBackColor = true;
            // 
            // checkBoxSegwit
            // 
            this.checkBoxSegwit.AutoSize = true;
            this.checkBoxSegwit.Location = new System.Drawing.Point(187, 89);
            this.checkBoxSegwit.Name = "checkBoxSegwit";
            this.checkBoxSegwit.Size = new System.Drawing.Size(58, 17);
            this.checkBoxSegwit.TabIndex = 47;
            this.checkBoxSegwit.Text = "Segwit";
            this.toolTip1.SetToolTip(this.checkBoxSegwit, "адрес типа Segwit");
            this.checkBoxSegwit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "дополнительно вывести:";
            this.toolTip1.SetToolTip(this.label2, "выводить дополнительно адреса");
            // 
            // radioButtonBothKey
            // 
            this.radioButtonBothKey.AutoSize = true;
            this.radioButtonBothKey.Location = new System.Drawing.Point(172, 19);
            this.radioButtonBothKey.Name = "radioButtonBothKey";
            this.radioButtonBothKey.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBothKey.TabIndex = 2;
            this.radioButtonBothKey.Text = "оба";
            this.toolTip1.SetToolTip(this.radioButtonBothKey, "ключей будет два");
            this.radioButtonBothKey.UseVisualStyleBackColor = true;
            // 
            // numericUpDownProcessCount
            // 
            this.numericUpDownProcessCount.Location = new System.Drawing.Point(665, 87);
            this.numericUpDownProcessCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProcessCount.Name = "numericUpDownProcessCount";
            this.numericUpDownProcessCount.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownProcessCount.TabIndex = 50;
            this.toolTip1.SetToolTip(this.numericUpDownProcessCount, "число параллельных процессов");
            this.numericUpDownProcessCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Процессов:";
            this.toolTip1.SetToolTip(this.label3, "число параллельных процессов");
            // 
            // checkBoxFlushFile
            // 
            this.checkBoxFlushFile.AutoSize = true;
            this.checkBoxFlushFile.Location = new System.Drawing.Point(18, 114);
            this.checkBoxFlushFile.Name = "checkBoxFlushFile";
            this.checkBoxFlushFile.Size = new System.Drawing.Size(163, 17);
            this.checkBoxFlushFile.TabIndex = 52;
            this.checkBoxFlushFile.Text = "сброс результатов в файл:";
            this.toolTip1.SetToolTip(this.checkBoxFlushFile, "сбрасывать результаты в выбранный файл");
            this.checkBoxFlushFile.UseVisualStyleBackColor = true;
            this.checkBoxFlushFile.CheckedChanged += new System.EventHandler(this.checkBoxFlushFile_CheckedChanged);
            // 
            // textBoxResultsFlushFile
            // 
            this.textBoxResultsFlushFile.Enabled = false;
            this.textBoxResultsFlushFile.Location = new System.Drawing.Point(187, 115);
            this.textBoxResultsFlushFile.Name = "textBoxResultsFlushFile";
            this.textBoxResultsFlushFile.Size = new System.Drawing.Size(307, 20);
            this.textBoxResultsFlushFile.TabIndex = 53;
            this.textBoxResultsFlushFile.Text = "D:\\\\results.txt";
            this.toolTip1.SetToolTip(this.textBoxResultsFlushFile, "какой файл использовать для сброса результатов");
            // 
            // buttonSelectFlushFile
            // 
            this.buttonSelectFlushFile.Enabled = false;
            this.buttonSelectFlushFile.FlatAppearance.BorderSize = 0;
            this.buttonSelectFlushFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFlushFile.Image = global::BitcoinAddressesGenerator.Properties.Resources.openIcon;
            this.buttonSelectFlushFile.Location = new System.Drawing.Point(500, 115);
            this.buttonSelectFlushFile.Name = "buttonSelectFlushFile";
            this.buttonSelectFlushFile.Size = new System.Drawing.Size(31, 23);
            this.buttonSelectFlushFile.TabIndex = 54;
            this.toolTip1.SetToolTip(this.buttonSelectFlushFile, "выбрать файл для сброса результатов");
            this.buttonSelectFlushFile.UseVisualStyleBackColor = true;
            this.buttonSelectFlushFile.Click += new System.EventHandler(this.buttonSelectFlushFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "сбрасывать каждые";
            this.toolTip1.SetToolTip(this.label4, "сбрасывать данные каждые Х строк");
            // 
            // numericUpDownFlushEveryCount
            // 
            this.numericUpDownFlushEveryCount.Location = new System.Drawing.Point(665, 118);
            this.numericUpDownFlushEveryCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownFlushEveryCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFlushEveryCount.Name = "numericUpDownFlushEveryCount";
            this.numericUpDownFlushEveryCount.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownFlushEveryCount.TabIndex = 55;
            this.toolTip1.SetToolTip(this.numericUpDownFlushEveryCount, "сбрасывать данные каждые Х строк");
            this.numericUpDownFlushEveryCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "записей";
            this.toolTip1.SetToolTip(this.label5, "если Оба ключа, то записей будет в 2 раза больше");
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 431);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(811, 3);
            this.splitter1.TabIndex = 36;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 431);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBarUpdateBase);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.labelCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 29);
            this.panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.Location = new System.Drawing.Point(3, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://upad.ru";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBoxWIFKey);
            this.panel3.Controls.Add(this.checkBoxHexPrivateKey);
            this.panel3.Controls.Add(this.buttonSaveAllToFile);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.numericUpDownFlushEveryCount);
            this.panel3.Controls.Add(this.buttonSelectFlushFile);
            this.panel3.Controls.Add(this.textBoxResultsFlushFile);
            this.panel3.Controls.Add(this.checkBoxFlushFile);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.numericUpDownProcessCount);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.checkBoxSegwitP2SH);
            this.panel3.Controls.Add(this.checkBoxSegwit);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonGenerate);
            this.panel3.Controls.Add(this.numericUpDownGenerationCount);
            this.panel3.Controls.Add(this.textBoxDelimiter);
            this.panel3.Controls.Add(this.textBoxSaveTo);
            this.panel3.Controls.Add(this.buttonGenerateRandom);
            this.panel3.Controls.Add(this.buttonSelectFile);
            this.panel3.Controls.Add(this.buttonGenerateText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 144);
            this.panel3.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonBothKey);
            this.groupBox2.Controls.Add(this.radioButtonCompressedKey);
            this.groupBox2.Controls.Add(this.radioButtonUnCompressedKey);
            this.groupBox2.Location = new System.Drawing.Point(352, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 40);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "приватный ключ:";
            // 
            // radioButtonCompressedKey
            // 
            this.radioButtonCompressedKey.AutoSize = true;
            this.radioButtonCompressedKey.Location = new System.Drawing.Point(96, 19);
            this.radioButtonCompressedKey.Name = "radioButtonCompressedKey";
            this.radioButtonCompressedKey.Size = new System.Drawing.Size(64, 17);
            this.radioButtonCompressedKey.TabIndex = 1;
            this.radioButtonCompressedKey.Text = "сжатый";
            this.radioButtonCompressedKey.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnCompressedKey
            // 
            this.radioButtonUnCompressedKey.AutoSize = true;
            this.radioButtonUnCompressedKey.Checked = true;
            this.radioButtonUnCompressedKey.Location = new System.Drawing.Point(6, 19);
            this.radioButtonUnCompressedKey.Name = "radioButtonUnCompressedKey";
            this.radioButtonUnCompressedKey.Size = new System.Drawing.Size(79, 17);
            this.radioButtonUnCompressedKey.TabIndex = 0;
            this.radioButtonUnCompressedKey.TabStop = true;
            this.radioButtonUnCompressedKey.Text = "не сжатый";
            this.radioButtonUnCompressedKey.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "разделитель";
            // 
            // checkBoxWIFKey
            // 
            this.checkBoxWIFKey.AutoSize = true;
            this.checkBoxWIFKey.Checked = true;
            this.checkBoxWIFKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWIFKey.Location = new System.Drawing.Point(27, 89);
            this.checkBoxWIFKey.Name = "checkBoxWIFKey";
            this.checkBoxWIFKey.Size = new System.Drawing.Size(67, 17);
            this.checkBoxWIFKey.TabIndex = 61;
            this.checkBoxWIFKey.Text = "WIF Key";
            this.toolTip1.SetToolTip(this.checkBoxWIFKey, "Приватный ключ в формате WIF ");
            this.checkBoxWIFKey.UseVisualStyleBackColor = true;
            // 
            // checkBoxHexPrivateKey
            // 
            this.checkBoxHexPrivateKey.AutoSize = true;
            this.checkBoxHexPrivateKey.Location = new System.Drawing.Point(115, 89);
            this.checkBoxHexPrivateKey.Name = "checkBoxHexPrivateKey";
            this.checkBoxHexPrivateKey.Size = new System.Drawing.Size(66, 17);
            this.checkBoxHexPrivateKey.TabIndex = 60;
            this.checkBoxHexPrivateKey.Text = "Hex Key";
            this.toolTip1.SetToolTip(this.checkBoxHexPrivateKey, "Приватный ключ в HEX формате");
            this.checkBoxHexPrivateKey.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textBoxLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Генератор адресов биткоина";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProcessCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlushEveryCount)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownGenerationCount;
        private System.Windows.Forms.TextBox textBoxSaveTo;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ProgressBar progressBarUpdateBase;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonGenerateRandom;
        private System.Windows.Forms.Timer timerThread;
        private System.Windows.Forms.Button buttonGenerateText;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox textBoxDelimiter;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonBothKey;
        private System.Windows.Forms.RadioButton radioButtonCompressedKey;
        private System.Windows.Forms.RadioButton radioButtonUnCompressedKey;
        private System.Windows.Forms.CheckBox checkBoxSegwitP2SH;
        private System.Windows.Forms.CheckBox checkBoxSegwit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveAllToFile;
        private System.Windows.Forms.NumericUpDown numericUpDownProcessCount;
        private System.Windows.Forms.Button buttonSelectFlushFile;
        private System.Windows.Forms.TextBox textBoxResultsFlushFile;
        private System.Windows.Forms.CheckBox checkBoxFlushFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownFlushEveryCount;
        private System.Windows.Forms.CheckBox checkBoxWIFKey;
        private System.Windows.Forms.CheckBox checkBoxHexPrivateKey;
    }
}

