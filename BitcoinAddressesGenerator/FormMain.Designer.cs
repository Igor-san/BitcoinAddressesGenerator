namespace RandomText
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
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
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.textBoxDelimiter = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(18, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
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
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxLog.Location = new System.Drawing.Point(0, 434);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(647, 94);
            this.textBoxLog.TabIndex = 4;
            this.textBoxLog.WordWrap = false;
            // 
            // textBoxText
            // 
            this.textBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxText.Location = new System.Drawing.Point(3, 82);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxText.Size = new System.Drawing.Size(641, 268);
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
            this.progressBarUpdateBase.Size = new System.Drawing.Size(566, 34);
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
            this.buttonStop.Location = new System.Drawing.Point(566, 0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 34);
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
            this.buttonGenerateText.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(384, 42);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(23, 23);
            this.buttonSelectFile.TabIndex = 33;
            this.buttonSelectFile.Text = "О";
            this.toolTip1.SetToolTip(this.buttonSelectFile, "указать путь к файлу");
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(590, 41);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(42, 23);
            this.buttonSaveFile.TabIndex = 34;
            this.buttonSaveFile.Text = "С";
            this.toolTip1.SetToolTip(this.buttonSaveFile, "сохранить в файл");
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
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
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 431);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(647, 3);
            this.splitter1.TabIndex = 36;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.3796F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.6204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 431);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBarUpdateBase);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.labelCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 32);
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
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonGenerate);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.textBoxDelimiter);
            this.panel3.Controls.Add(this.textBoxSaveTo);
            this.panel3.Controls.Add(this.buttonSaveFile);
            this.panel3.Controls.Add(this.buttonGenerateRandom);
            this.panel3.Controls.Add(this.buttonSelectFile);
            this.panel3.Controls.Add(this.buttonGenerateText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 73);
            this.panel3.TabIndex = 6;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textBoxLog);
            this.Name = "FormMain";
            this.Text = "Генератор адресов биткоина";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
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
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.TextBox textBoxDelimiter;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}

