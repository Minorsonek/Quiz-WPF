using System.Net;
using System.IO;
using System.Text;

namespace Quiz.Core
{
    /// <summary>
    /// Paths to the files used in this Quiz
    /// </summary>
    public class FilePath
    {
        #region Public Properties

        /// <summary>
        /// Loaded questions to the array
        /// </summary>
        public string[] QuestionsFile { get; private set; }

        /// <summary>
        /// Url to questions file
        /// </summary>
        public string URL => "http://stacjapogody.lo2przemysl.edu.pl/quiz/pytania.txt";

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public FilePath()
        {
            // Simply load data from specified URL
            //LoadFileFromWeb(this.URL);

            // Load data from file
            LoadFromFile("pytania.txt");
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Loads questions from website
        /// </summary>
        /// <param name="url">The website to load from</param>
        private void LoadFileFromWeb(string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string result = wc.DownloadString(url);
            }
        }

        /// <summary>
        /// Loads questions from file
        /// </summary>
        /// <param name="path">The path to the file</param>
        private void LoadFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.Default);
            QuestionsFile = lines;
        }

        #endregion
    }
}
