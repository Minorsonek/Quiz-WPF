using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz.Core
{
    /// <summary>
    /// The View Model for a single item in answers history control
    /// </summary>
    public class AnswersItemViewModel : BaseViewModel
    {
        #region Singleton

        /// <summary>
        /// Singleton instance of this view model
        /// </summary>
        public static AnswersItemViewModel Instance => new AnswersItemViewModel();

        #endregion

        #region Public Properties

        /// <summary>
        /// The number of answered question
        /// </summary>
        public int AnswerNumber { get; set; } = 2;

        /// <summary>
        /// The letter as an answer to this question
        /// </summary>
        public char AnswerLetter { get; set; } = 'A';

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnswersItemViewModel()
        {

        }

        #endregion
    }
}
