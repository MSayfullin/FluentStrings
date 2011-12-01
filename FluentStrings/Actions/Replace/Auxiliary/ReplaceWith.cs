using System;

namespace dokas.FluentStrings
{
    public class ReplaceWith
    {
        
        private readonly ReplacePattern _source;
        private readonly string _textToReplace;
        private readonly char _symbol;
        private readonly string _separator;

        public ReplaceWith (ReplacePattern replaceString, string textToReplace)
        {
            _source = replaceString;
            _textToReplace = textToReplace;
        }
        
        public ReplaceWith (ReplaceWith source, char symbol)
        {
            _source = source._source;
            _textToReplace = source._textToReplace;
            _symbol = symbol;
        }
        
        public ReplaceWith (ReplaceWith source, string separator)
        {
            _source = source._source;
            _textToReplace = source._textToReplace;
            _separator = separator;
        }
       
        public static implicit operator string (ReplaceWith replaceString)
        {
            return replaceString.ToString ();
        }
        
        public override string ToString ()
        {
            throw new NotImplementedException ();
        }
    }
}

