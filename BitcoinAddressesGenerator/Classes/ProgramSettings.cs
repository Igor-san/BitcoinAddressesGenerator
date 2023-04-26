using System.IO;
using Newtonsoft.Json;

namespace BitcoinAddressesGenerator.Classes
{
    public class ProgramSettings : AppSettings<ProgramSettings>
    {
        public ProgramSettings() : base()
        {
        }
        public ProgramSettings(string configFile) : base(configFile)
        {
        }

        /// <summary>
        /// Числло паралельных процессов
        /// </summary>
        public int ProcessCount { get; set; } = -1;


        /// <summary>
        /// Число генераций
        /// </summary>
        public int GenerationCount { get; set; } = 10000;


        /// <summary>
        /// 
        /// сбрасывать данные на диск каждые FlushEveryCount строк
        /// </summary>
        public int FlushEveryCount { get; set; } = 10000;

        /// <summary>
        /// Разделитель между ключами, адресами
        /// </summary>
        public string Delimiter { get; set; } = " | ";
        /// <summary>
        ///Файл для сохранения случайно сгенерированных строк
        /// </summary>
        public string RandomStringsFile { get; set; } = "";

        /// <summary>
        /// Файл для сброса результатов
        /// </summary>
        public string ResultsFlushFile { get; set; } = "";

        /// <summary>
        /// Сбрасывать ли промежуточные результаты в файл
        /// </summary>
        public bool ResultsFlush { get; set; } = false;

        /// <summary>
        /// Выводить адреса формата Segwit
        /// </summary>
        public bool Segwit { get; set; } = false;

        /// <summary>
        /// Выводить адреса формата SegwitP2SH
        /// </summary>
        public bool SegwitP2SH { get; set; } = false;

        /// <summary>
        /// Генерировать несжатый ключ
        /// </summary>
        public bool UnCompressedKey { get; set; } = true;

        /// <summary>
        /// Генерировать сжатый ключ
        /// </summary>
        public bool CompressedKey { get; set; } = false;

        /// <summary>
        /// Генерировать сжатый и несжатый ключи
        /// </summary>
        public bool BothKey { get; set; } = false;

    }

    public class AppSettings<T> where T : new()
    {
        public AppSettings(string configFile)
        {
            CONFIG_FILENAME=configFile;
        }
        public AppSettings()
        {
          
        }
        public static string CONFIG_FILENAME { get; private set; }

        public bool Save(string fileName = "")
        {
            if (fileName == "")
            {

                fileName = CONFIG_FILENAME;
            }
            else
            {
                CONFIG_FILENAME = fileName;
            }

            File.WriteAllText(fileName, JsonConvert.SerializeObject(this));
            return true;
        }

        public static bool Save(T pSettings, string fileName = "")
        {

            if (fileName == "")
            {
                return false;
                // fileName = CONFIG_FILENAME;
            }
            else
                CONFIG_FILENAME = fileName;

            File.WriteAllText(fileName, JsonConvert.SerializeObject(pSettings));
            return true;
        }

        public static T Load(string fileName)
        {
            T t = new T();
            if (File.Exists(fileName))
            {
                t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
                CONFIG_FILENAME = fileName;
            }
            return t;
        }
        /// <summary>
        /// Чтобы не сохранять пустышку
        /// </summary>
        public static void EmptyConfigPath()
        {
            CONFIG_FILENAME = null;
        }
    }
}
