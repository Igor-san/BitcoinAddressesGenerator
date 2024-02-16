using BitcoinAddressesGenerator.Classes;
using NBitcoin;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinAddressesGenerator
{
    public partial class FormMain : Form
    {

        private bool BatchWork = false; //выполнение долгой операции
        private string BatchWorkTip = ""; //описание текущей долгой операции

        Control DisabledControl;

        Network CurrentNetwork = Network.Main;

        public ProgramSettings CurrentSettings = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadSettings();

            this.Text += " " + Assembly.GetEntryAssembly().GetName().Version.ToString();

        }
        private void ErrorMessage(string msg)
        {
            textBoxLog.AppendText("Error: " + msg + Environment.NewLine);
        }

        private void StatusMessage(string msg)
        {
            textBoxLog.AppendText("Info: " + msg + Environment.NewLine);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        private bool StartQuery(out DateTime startTime, string workTip = "", Control control = null)
        {
            startTime = DateTime.Now;

            string msg = "";
            if (BatchWorkTip != "") msg = " (" + BatchWorkTip + ")";

            if (BatchWork)
            {
                ErrorMessage("Выполняется другое длительное задание:" + msg);
                return false;
            }

            BatchWorkTip = workTip;
            BatchWork = true;

            DisabledControl = control;


            if (DisabledControl != null)
            {
                DisabledControl.Enabled = false;
            }


            buttonStop.Focus();
            buttonStop.Select();

            return true;
        }

        /// <summary>
        /// Окончание и запроса и работы, разблокировка контролов
        /// </summary>
        /// <param name="dtStart"></param>
        private void FinallyQueryWork(DateTime dtStart)
        {

            BatchWork = false;
            BatchWorkTip = "";

            if (DisabledControl != null)
            {
                DisabledControl.Enabled = true;
            }

            DateTime dtEnd = DateTime.Now;

            StatusMessage(String.Format("Затрачено {0} sec", (dtEnd - dtStart).TotalMilliseconds / 1000));
        }

        private void EnableControls(bool enable)
        {
            buttonGenerateText.Enabled = enable;

            buttonStop.Enabled = !enable;
        }

        private void buttonGenerateText_Click(object sender, EventArgs e)
        {
            DateTime dtStart;
            if (!StartQuery(out dtStart)) return;
            try
            {
                int count = (int)numericUpDownGenerationCount.Value;

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < count; i++)
                {
                    sb.AppendLine(RandomString(100));
                }

                System.IO.File.WriteAllText(textBoxSaveTo.Text.Trim(), sb.ToString());

            }
            catch (Exception ex)
            {
                ErrorMessage("buttonGenerateText_Click" + ex.Message);
            }
            finally
            {

                FinallyQueryWork(dtStart);
                EnableControls(true);
            }
        }

        static Random random = new Random();

        private static string RandomString(int Size)
        {
            string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, Size)
                                   .Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            DateTime dtStart;
            if (!StartQuery(out dtStart)) return;
            try
            {


                textBoxText.Text = System.IO.File.ReadAllText(textBoxSaveTo.Text.Trim());

                StatusMessage("Загружено " + textBoxText.Lines.Count() + " линий");
            }
            catch (Exception ex)
            {
                ErrorMessage("buttonOpen_Click" + ex.Message);
            }
            finally
            {
                FinallyQueryWork(dtStart);
                EnableControls(true);
            }

        }

        #region ProgressBar

        bool StopProcess = false;

        private void buttonStop_Click(object sender, EventArgs e)
        {

            StopProcess = true;

        }

        private void PerformStep()
        {
            progressBarUpdateBase.PerformStep();
        }

        private void StartProcess(bool start, int maximum, int step = 1, string tooltip = "Background process in progress")
        {

            if (start)
            {
                StopProcess = false;

                buttonStop.Enabled = true;
                progressBarUpdateBase.Style = ProgressBarStyle.Continuous;
                progressBarUpdateBase.Value = 0;
                progressBarUpdateBase.Step = step;
                progressBarUpdateBase.Maximum = maximum;
                BatchWorkTip = tooltip;

            }
            else
            {
                buttonStop.Enabled = false;
                progressBarUpdateBase.Value = 0;
                StopProcess = true;
                BatchWorkTip = "";
            }
        }

        /// <summary>
        /// просто цикл по таймеру показывающий что идет процессобновления базы без кнопок остановит
        /// </summary>
        /// <param name="p"></param>
        /// <param name="max"></param>
        private void StartLoopProcess(bool start, string tooltip = "Background process in progress")
        {

            if (start)
            {
                StopProcess = false;
                buttonStop.Enabled = true;
                buttonStop.Select();
                buttonStop.Focus();
                Application.DoEvents();

                progressBarUpdateBase.Style = ProgressBarStyle.Marquee;
                progressBarUpdateBase.MarqueeAnimationSpeed = 30;
                BatchWorkTip = tooltip;
            }
            else
            {
                StopProcess = true;
                buttonStop.Enabled = false;

                progressBarUpdateBase.Value = 0;
                progressBarUpdateBase.Style = ProgressBarStyle.Continuous;
                progressBarUpdateBase.MarqueeAnimationSpeed = 0;
                BatchWorkTip = "";
            }
        }

        #endregion ProgressBar

        #region ProgressBar Timer
        int ProgressBarCounter = 0;

        private void timerThread_Tick(object sender, EventArgs e)
        {
            try
            {
                labelCount.Text = ProgressBarCounter.ToString();
            }
            catch (Exception ex)
            {
                timerThread.Stop();
                labelCount.Text = "";
                ErrorMessage("Error in timerThread_Tick: " + ex.Message);
            }
        }
        #endregion ProgressBar Timer

        CancellationTokenSource cts;


        void CancelAllThreads()
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }
        private (string privateKeyString, string hex, string address) CreateKeyAddress(bool isCompressed, bool isSegwit, bool isSegwitP2SH, string delem)
        {
            var privateKey = new Key(isCompressed);
       
            var bitcoinPrivateKey = privateKey.GetWif(CurrentNetwork);
            string address = bitcoinPrivateKey.GetAddress(ScriptPubKeyType.Legacy).ToString();

            if (isSegwit)
            {
                address += delem + bitcoinPrivateKey.GetAddress(ScriptPubKeyType.Segwit).ToString();
            }
            if (isSegwitP2SH)
            {
                address += delem + bitcoinPrivateKey.GetAddress(ScriptPubKeyType.SegwitP2SH).ToString();
            }

            return (bitcoinPrivateKey.ToString(), privateKey.ToHex(), address);
        }

        private string CreateKeyAddresses(bool isCompressed, bool isUnCompressed, bool isSegwit, bool isSegwitP2SH, string delem, string format)
        {
            string privateKeys = "";
            string hex = "";
            string addresses = "";

            if (isCompressed && isUnCompressed) //вернем с переносом в StringBuilder
            {
                (string keys1, string hex1, string addr1) = CreateKeyAddress(true, isSegwit, isSegwitP2SH, delem);
                string s1 = string.Format(format, keys1, hex1, addr1, delem);

                (string keys2, string hex2, string addr2) = CreateKeyAddress(false, isSegwit, isSegwitP2SH, delem);
                string s2 = string.Format(format, keys2, hex2, addr2, delem);

                return s1 + "\r\n" + s2;

            }
            else if (isCompressed)
            {
                (privateKeys, hex, addresses) = CreateKeyAddress(true, isSegwit, isSegwitP2SH, delem);


            }
            else
            {
                (privateKeys, hex, addresses) = CreateKeyAddress(false, isSegwit, isSegwitP2SH, delem);
            }


            return string.Format(format, privateKeys, hex, addresses, delem);

        }

        private string GetOutputFormat()
        {
            string format = "{0}{3}{1}{3}{2}";
            //0 - private key, 1 - Hex Private Key, 2 - addresses, 3- delimitator, 
            var WIFKey = checkBoxWIFKey.Checked;
            var HexPrivateKey = checkBoxHexPrivateKey.Checked;
            //var Segwit = checkBoxSegwit.Checked;
            //var SegwitP2SH = checkBoxSegwitP2SH.Checked;

            if (!WIFKey)
            {
                format = format.Replace("{0}{3}", "");
            }
            if (!HexPrivateKey)
            {
                format = format.Replace("{1}{3}", "");
            }

            return format;
        }
        private void buttonGenerateRandom_Click(object sender, EventArgs e)
        {
            DateTime dtStart;
            if (!StartQuery(out dtStart)) return;

            StreamWriter flushFile = null;
            StringBuilder sb = new StringBuilder();

            try
            {

                int count = (int)numericUpDownGenerationCount.Value;

                int flushEveryCount = (int)numericUpDownFlushEveryCount.Value;

                bool flushToFile =  checkBoxFlushFile.Checked;

                if (flushToFile)
                {
                    //будем сбрасывать содержимое stringBuilder в файл
                     flushFile = new StreamWriter(textBoxResultsFlushFile.Text.Trim(), true, Encoding.ASCII);
                }


                StartLoopProcess(true);

                string delem = textBoxDelimiter.Text;

                ProgressBarCounter = 0;
                timerThread.Start();

                bool segwit = checkBoxSegwit.Checked;
                bool segwitP2SH = checkBoxSegwitP2SH.Checked;

                bool isUnCompressed = radioButtonUnCompressedKey.Checked;
                bool isCompressed = radioButtonCompressedKey.Checked;

                if (radioButtonBothKey.Checked)
                {
                    isUnCompressed = true;
                    isCompressed = true;
                }

                string format = GetOutputFormat();
                cts = new CancellationTokenSource();
                ParallelOptions po = new ParallelOptions()
                {
                    MaxDegreeOfParallelism = (int)numericUpDownProcessCount.Value,
                    CancellationToken = cts.Token,
                };
                try
                {
                    RandomUtils.Random = new UnsecureRandom();

                    Parallel.For(0, count, po, (i, pls1) =>
                    {
                        RandomUtils.AddEntropy(RandomString(100));

                        string stroke = CreateKeyAddresses(isCompressed: isCompressed, isUnCompressed: isUnCompressed, isSegwit: segwit, isSegwitP2SH: segwitP2SH, delem: delem, format: format);

                        lock (sb)
                        {

                            sb.AppendLine(stroke);

                            ProgressBarCounter++;

                            if (flushToFile && (ProgressBarCounter % flushEveryCount == 0))
                            {
                                flushFile.Write(sb.ToString());
                                flushFile.Flush();
                                sb.Clear();

                            }


                        }

                        Application.DoEvents();
                        if (StopProcess)
                        {
                            pls1.Stop();
                        }

                    });
                }
                catch (OperationCanceledException ex)
                {
                    StartProcess(false, 0);
                    StatusMessage("Запрошена отмена потоков: " + ex.Message);
                    return;
                }

                timerThread.Stop();

                textBoxText.Text = sb.ToString();
                StatusMessage("Обработано " + count + " строк");
            }
            catch (Exception ex)
            {
                ErrorMessage($"buttonGenerateRandom_Click: {ex.Message} -> {ex.InnerException.Message}");
            }
            finally
            {
                if (flushFile != null)
                {
                    //сбросим остатки sb
                   flushFile.Write(sb.ToString());
                   flushFile.Close();
                }

                StartLoopProcess(false);
                FinallyQueryWork(dtStart);
                EnableControls(true);
            }
        }

        private void buttonGenerateFromFile_Click(object sender, EventArgs e)
        {
            DateTime dtStart;
            if (!StartQuery(out dtStart)) return;

            StreamWriter flushFile = null;
            StringBuilder sb = new StringBuilder();

            try
            {

                if (!File.Exists(textBoxSaveTo.Text.Trim()))
                {
                    ErrorMessage("файл " + textBoxSaveTo.Text.Trim() + " не найден");
                    return;
                }

                int flushEveryCount = (int)numericUpDownFlushEveryCount.Value;

                bool flushToFile = checkBoxFlushFile.Checked;

                if (flushToFile)
                {
                    //будем сбрасывать содержимое stringBuilder в файл
                    flushFile = new StreamWriter(textBoxResultsFlushFile.Text.Trim(), true, Encoding.ASCII);
                }

                StartLoopProcess(true);

                string delem = textBoxDelimiter.Text;
                bool segwit = checkBoxSegwit.Checked;
                bool segwitP2SH = checkBoxSegwitP2SH.Checked;

                bool isUnCompressed = radioButtonUnCompressedKey.Checked;
                bool isCompressed = radioButtonCompressedKey.Checked;

                if (radioButtonBothKey.Checked)
                {
                    isUnCompressed = true;
                    isCompressed = true;
                }

                int count = 0;

                ProgressBarCounter = 0;
                timerThread.Start();

                string format = GetOutputFormat();
                cts = new CancellationTokenSource();
                ParallelOptions po = new ParallelOptions()
                {
                    MaxDegreeOfParallelism = (int)numericUpDownProcessCount.Value,
                    CancellationToken = cts.Token,
                };
                try
                {
                    RandomUtils.Random = new UnsecureRandom();

                    Parallel.ForEach(File.ReadLines(textBoxSaveTo.Text.Trim()), po, (line, state) =>
                    {
                        if (line.Trim() != String.Empty)
                        {
                            RandomUtils.AddEntropy(line.Trim());

                            string stroke = CreateKeyAddresses(isCompressed: isCompressed, isUnCompressed: isUnCompressed, isSegwit: segwit, isSegwitP2SH: segwitP2SH, delem: delem, format: format);

                            lock (sb)
                            {

                                sb.AppendLine(stroke);

                                ProgressBarCounter++;

                                if (flushToFile && (ProgressBarCounter % flushEveryCount == 0))
                                {
                                    flushFile.Write(sb.ToString());
                                    flushFile.Flush();
                                    sb.Clear();
                                }
                            }
                        }
                        Application.DoEvents();
                        if (StopProcess)
                        {
                            state.Stop();
                        }

                    });

                }
                catch (OperationCanceledException ex)
                {
                    StartProcess(false, 0);
                    StatusMessage("Запрошена отмена потоков: " + ex.Message);
                    return;

                }


                textBoxText.Text = sb.ToString();
                StatusMessage("Обработано " + count + " линий");
            }
            catch (Exception ex)
            {
                ErrorMessage("buttonGenerateFromFile_Click" + ex.Message);
            }
            finally
            {
                if (flushFile != null)
                {
                    //сбросим остатки sb
                    flushFile.Write(sb.ToString());
                    flushFile.Close();
                }

                StartLoopProcess(false);
                FinallyQueryWork(dtStart);
                EnableControls(true);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BatchWork)
            {
                DialogResult res = MessageBox.Show("Некоторые процессы еще выполняются. Вы действительно хотите выйти из программы, не ожидая их нормальног прекращения?", "Есть запущенные процессы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }
            if (!e.Cancel)
            {
                CancelAllThreads();
            }

            SaveSettings();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://upad.ru");
            }
            catch (Exception ex)
            {
                ErrorMessage("linkLabel1_LinkClicked" + ex.Message);
            }
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Укажите файл ...";
            dlg.Filter = "Txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
            dlg.ValidateNames = false;
            dlg.CheckFileExists = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveTo.Text = (dlg.FileName);
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            #region Set Save Dialog Properties

            dlg.AddExtension = true;
            dlg.Title = "Сохранить пакет как...";
            dlg.Filter = "Txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
            dlg.OverwritePrompt = true;
            #endregion

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBoxText.Text);
            }
        }

        private void buttonSaveAllToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            #region Set Save Dialog Properties

            dlg.AddExtension = true;
            dlg.Title = "Сохранить результат как...";
            dlg.Filter = "Txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
            dlg.OverwritePrompt = true;
            #endregion

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBoxText.Text);
            }
        }

        private void buttonSelectFlushFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Укажите файл ...";
            dlg.Filter = "Txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
            dlg.ValidateNames = false;
            dlg.CheckFileExists = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxResultsFlushFile.Text = (dlg.FileName);
            }
        }
        private void checkBoxFlushFile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFlushFile.Checked)
            {
                textBoxResultsFlushFile.Enabled = true;
                buttonSelectFlushFile.Enabled = true;
            }
            else
            {
                textBoxResultsFlushFile.Enabled = false;
                buttonSelectFlushFile.Enabled = false;
            }
        }

        private void LoadSettings()
        {
            try
            {
                string configFile = Path.Combine(Application.StartupPath, Constants.SettingsName);

                if (File.Exists(configFile))
                {
                    CurrentSettings = ProgramSettings.Load(configFile);
                }
                else
                {
                    CurrentSettings = new ProgramSettings(configFile);
                }

                if (CurrentSettings.ProcessCount <= 0)
                {
                    CurrentSettings.ProcessCount = Environment.ProcessorCount; //число процессоров
                    numericUpDownProcessCount.Value = CurrentSettings.ProcessCount;
                }


                numericUpDownGenerationCount.Value = CurrentSettings.GenerationCount;

                textBoxDelimiter.Text = CurrentSettings.Delimiter;  //Разделитель, может содержать пробелы

                textBoxSaveTo.Text = CurrentSettings.RandomStringsFile;

                textBoxResultsFlushFile.Text = CurrentSettings.ResultsFlushFile;

                checkBoxFlushFile.Checked = CurrentSettings.ResultsFlush;

                checkBoxSegwit.Checked = CurrentSettings.Segwit;

                checkBoxSegwitP2SH.Checked = CurrentSettings.SegwitP2SH;

                radioButtonUnCompressedKey.Checked = CurrentSettings.UnCompressedKey;

                radioButtonCompressedKey.Checked = CurrentSettings.CompressedKey;

                radioButtonBothKey.Checked = CurrentSettings.BothKey;

                numericUpDownFlushEveryCount.Value = CurrentSettings.FlushEveryCount;
            }
            catch (Exception ex)
            {
                ErrorMessage("LoadSettings: " + ex.Message);
            }
        }

        private void SaveSettings()
        {
            try
            {
                CurrentSettings.ProcessCount = (int)numericUpDownProcessCount.Value;

                CurrentSettings.GenerationCount = (int)numericUpDownGenerationCount.Value;

                CurrentSettings.Delimiter = textBoxDelimiter.Text; //Разделитель, может содержать пробелы

                CurrentSettings.RandomStringsFile = textBoxSaveTo.Text;

                CurrentSettings.ResultsFlushFile = textBoxResultsFlushFile.Text;

                CurrentSettings.ResultsFlush = checkBoxFlushFile.Checked;

                CurrentSettings.Segwit = checkBoxSegwit.Checked;

                CurrentSettings.SegwitP2SH = checkBoxSegwitP2SH.Checked;

                CurrentSettings.UnCompressedKey = radioButtonUnCompressedKey.Checked;

                CurrentSettings.CompressedKey = radioButtonCompressedKey.Checked;

                CurrentSettings.BothKey = radioButtonBothKey.Checked;

                CurrentSettings.FlushEveryCount = (int) numericUpDownFlushEveryCount.Value;

                CurrentSettings.Save();

            }
            catch (Exception ex)
            {
                ErrorMessage("SaveSettings: " + ex.Message);
            }
        }



    }
}
