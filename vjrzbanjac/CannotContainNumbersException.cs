using System;
using System.Collections.Generic;
using System.Text;

namespace vjrzbanjac
{
    class CannotContainNumbersException : Exception
    {
        public string Text { get; private set; }
        public CannotContainNumbersException(string text, string message) : base(message)
        {
            Text = text;
        }
        public CannotContainNumbersException(string text) : base()
        {
            Text = text;
        }
    }
}
