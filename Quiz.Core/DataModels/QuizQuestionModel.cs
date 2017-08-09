namespace Quiz.Core
{
    /// <summary>
    /// A class to handle quiz's questions
    /// </summary>
    public class QuizQuestionModel
    {
        #region Public Properties

        public string Question { get; set; }

        public string AnswerA { get; set; }
        
        public string AnswerB { get; set; }

        public string AnswerC { get; set; }

        public string AnswerD { get; set; }

        public char RightAnswer { get; set; }

        public int Points { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public QuizQuestionModel(string question, string answerA, string answerB, string answerC, string answerD, char rightAnswer, int points)
        {
            this.Question = question;
            this.AnswerA = answerA;
            this.AnswerB = answerB;
            this.AnswerC = answerC;
            this.AnswerD = answerD;
            this.RightAnswer = rightAnswer;
            this.Points = points;
        }

        #endregion

        #region Private Helpers



        #endregion
    }
}
