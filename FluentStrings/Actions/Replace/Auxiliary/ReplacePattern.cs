using System;

namespace dokas.FluentStrings
{
    public class ReplacePattern
    {
        
        private readonly string _source;
        private readonly string _pattern;
        private readonly bool _firstOccurrence;
        private readonly bool _lastOccurrence;
        private readonly bool _allOccurrences;
        
        public ReplacePattern (string source, string pattern)
        {
            _source = source;
            _pattern = pattern;
        }
        
        public ReplacePattern (ReplacePattern replacePattern, bool firstOccurrence, bool lastOccurrence, bool allOccurences)
        {
            _source = replacePattern._source;
            _pattern = replacePattern._pattern;
            _firstOccurrence = firstOccurrence;
            _lastOccurrence = lastOccurrence;
            _allOccurrences = allOccurences;
        }
        
        public static implicit operator string (ReplacePattern replaceString)
        {
            return replaceString.ToString ();
        }
        
        public override string ToString ()
        {
            throw new NotImplementedException ();
        }
    }
}

