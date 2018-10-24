using Casascius.Bitcoin;
using NBitcoin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomText
{
    public partial class FormMain : Form
    {

        private bool BatchWork = false; //выполнение долгой операции
        private string BatchWorkTip = ""; //описание текущей долгой операции

        Control DisabledControl;
        DataGridView DisabledGrid;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ErrorMessage(string p)
        {
            try
            {
              if (textBoxLog!=null)  textBoxLog.AppendText("Error: " + p + Environment.NewLine);
            }
            catch { }
        }

        private void StatusMessage(string p)
        {
            try
            {
            if (textBoxLog != null) textBoxLog.AppendText("Info: " + p + Environment.NewLine);
                        }
            catch { }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="control"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        private bool StartQuery(out DateTime startTime, string workTip = "", Control control = null, DataGridView grid = null)
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
            DisabledGrid = grid;

            if (DisabledControl != null)
                DisabledControl.Enabled = false;
            if (DisabledGrid != null)
                DisabledGrid.SuspendLayout();

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
                DisabledControl.Enabled = true;
            if (DisabledGrid != null)
                DisabledGrid.ResumeLayout();

            DateTime dtEnd = DateTime.Now;

            StatusMessage(String.Format("Затрачено {0} sec", (dtEnd - dtStart).TotalMilliseconds / 1000));
        }

        private void EnableControls(bool enable)
        {
            buttonGenerateText.Enabled = enable;

            buttonStop.Enabled = !enable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dtStart;
            if (!StartQuery(out dtStart)) return; 
            try
            {
                int count = (int)numericUpDown1.Value;

                StringBuilder sb=new StringBuilder();

                for (int i = 0; i < count; i++)
                {
                    sb.AppendLine(RandomString(100));
                }

                System.IO.File.WriteAllText(textBoxSaveTo.Text.Trim(), sb.ToString());

            }
            catch (Exception ex)
            {
                ErrorMessage("button1_Click" + ex.Message);
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


                textBoxText.Text=System.IO.File.ReadAllText(textBoxSaveTo.Text.Trim());

                StatusMessage("Загружено "+textBoxText.Lines.Count()+" линий");
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
        private void buttonGenerateRandom_Click(object sender, EventArgs e)
        {
            DateTime dtStart;
            if (!StartQuery(out dtStart)) return;
            try
            {
                int count = (int)numericUpDown1.Value;

                StartLoopProcess(true);

                StringBuilder sb=new StringBuilder();

                string delem= textBoxDelimiter.Text;

                ProgressBarCounter = 0;
                timerThread.Start();

                cts = new CancellationTokenSource();
                ParallelOptions po = new ParallelOptions()
                {
                    MaxDegreeOfParallelism = 8,
                    CancellationToken = cts.Token,
                };
                try
                {
                    Parallel.For(0, count, po, (i, pls1) =>
                    {
                        var network = Network.Main;

                        RandomUtils.AddEntropy(RandomString(100));
                        var nsaProofKey = new Key();
                        var privateKey = new Key();
                        var bitcoinPrivateKey = privateKey.GetWif(network);
                        var address = bitcoinPrivateKey.GetAddress();
                        var publicKey = bitcoinPrivateKey.PubKey;
                        lock (sb)
                        {
                            sb.AppendFormat("{0}{3}{1}{3}{2}", bitcoinPrivateKey, address, publicKey, delem);
                            sb.AppendLine();
                            Interlocked.Increment(ref ProgressBarCounter);
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
                    return ;

                }

                timerThread.Stop();

                textBoxText.Text=sb.ToString();
                StatusMessage("Обработано " + count + " строк");
            }
            catch (Exception ex)
            {
                ErrorMessage("buttonGenerateRandom_Click" + ex.Message);
            }
            finally
            {
                StartLoopProcess(false);
                FinallyQueryWork(dtStart);
                EnableControls(true);
            }
        }

        private void buttonGenerateFromFile_Click(object sender, EventArgs e)
        {
            DateTime dtStart;
            if (!StartQuery(out dtStart)) return;
            try
            {

                if  (!File.Exists(textBoxSaveTo.Text.Trim()))
                {
                    ErrorMessage("файл "+textBoxSaveTo.Text.Trim()+" не найден");
                    return;
                }
                StartLoopProcess(true);

                string delem = textBoxDelimiter.Text;

                StringBuilder sb=new StringBuilder();

                int count = 0;

                ProgressBarCounter = 0;
                timerThread.Start();

                cts = new CancellationTokenSource();
                ParallelOptions po = new ParallelOptions()
                {
                    MaxDegreeOfParallelism = 8,
                    CancellationToken = cts.Token,
                };
                try
                {

                    Parallel.ForEach(File.ReadLines(textBoxSaveTo.Text.Trim()), po, (line, state) =>
                    {
                        if (line.Trim() != String.Empty)
                        {
                            var network = Network.Main;

                            RandomUtils.AddEntropy(line.Trim());
                            var nsaProofKey = new Key();
                            var privateKey = new Key();
                            var bitcoinPrivateKey = privateKey.GetWif(network);
                            var address = bitcoinPrivateKey.GetAddress();

                            lock (sb)
                            {
                                sb.AppendFormat("{0}{2}{1}", bitcoinPrivateKey, address, delem);
                                sb.AppendLine();
                                count++;
                                Interlocked.Increment(ref ProgressBarCounter);
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
                StartLoopProcess(false);
                FinallyQueryWork(dtStart);
                EnableControls(true);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try{


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

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveTo.Text=(dlg.FileName);
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
      
        /*
        private void GenerateKeys(string seed)
        {
            try
            {

                KeyPair privateKey = KeyPair.Create(seed, false, 0); // а это из Bitcoin-Address-Utility-master
                var bitcoinPrivateKey = privateKey.PrivateKeyBase58;
                var address = new AddressBase(privateKey, 0).AddressBase58;



            }
            catch (Exception ex)
            {
                ErrorMessage("GenerateKeys("+seed+"):" + ex.Message);
                return;
            }
            finally
            {

            }
        }
        */
    }
}
