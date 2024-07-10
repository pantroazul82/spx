using System;
using System.Collections.Generic;
using System.Text;

namespace BOLayer
{
    public enum Severity { Warning , Error , Fatal };

    /// <summary>
    /// Class to Handle Errors.
    /// Supports Severity Level.
    /// </summary>
	public class Error
	{
        /// <summary>
        /// Method that transform a list of Errors into a nice string format.
        /// </summary>
        /// <param name="pErrors">Errors to Transform</param>
        /// <returns></returns>
        public static string ErrorsToString(List<Error> pErrors)
        {
            if (pErrors == null) throw new ArgumentNullException("pErrors");

            StringBuilder _sb = new StringBuilder();
            string _ret = String.Empty;
            foreach (Error _error in pErrors)
            {
                _sb.AppendLine(_error.ErrorMessage );
            }
            return _sb.ToString();
        }

        #region --- Fields ---

        Severity _severity;
        string _errorMessage;

        #endregion

        #region --- Constructors ---
        
        public Error()
        {
        }

        public Error(string pErrorMessage)
        {
           if ( string.IsNullOrEmpty(pErrorMessage)) throw new ArgumentNullException("pErrorMessage");
           _errorMessage = pErrorMessage;
        }

        public Error(string pErrorMessage, Severity pSeverityLevel) : this(pErrorMessage)
        {
           _severity = pSeverityLevel;
        }
        
        #endregion


        #region --- Properties ---

        public Severity Severity
        {
            get { return _severity; }
            set { _severity = value; }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        #endregion


    }
}


