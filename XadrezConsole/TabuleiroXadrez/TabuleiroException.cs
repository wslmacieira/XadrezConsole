using System;

namespace XadrezConsole.TabuleiroXadrez
{
    public class TabuleiroException : ArgumentException
    {
        public TabuleiroException(string message) : base(message)
        {
        }
    }
}
