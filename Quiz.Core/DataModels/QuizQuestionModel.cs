namespace Quiz.Core
{
    /// <summary>
    /// A class to handle quiz's questions
    /// </summary>
    public class QuizQuestionModel
    {
        #region Public Properties

        /// <summary>
        /// The question user is asked to answer
        /// </summary>
        public string Question { get; set; }

        // Possible answers
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }

        /// <summary>
        /// The right answer to the question (isnt shown to user of course)
        /// </summary>
        public char RightAnswer { get; set; }

        /// <summary>
        /// Possible points user will gain for the right answer in this question
        /// </summary>
        public int Points { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public QuizQuestionModel(string question, string answerA, string answerB, string answerC, string answerD, char rightAnswer, int points)
        {
            // Create question
            this.Question = question;
            this.AnswerA = answerA;
            this.AnswerB = answerB;
            this.AnswerC = answerC;
            this.AnswerD = answerD;
            this.RightAnswer = rightAnswer;
            this.Points = points;
        }

        #endregion
    }
}
