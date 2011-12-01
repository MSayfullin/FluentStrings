using System;

namespace dokas.FluentStrings
{
    public class ReplaceWithSeparatedByIgnoringCase
    {
        
        private readonly ReplaceWith _source;
        private readonly bool ignoringCase;
        
        public ReplaceWithSeparatedByIgnoringCase (ReplaceWith source)
        {
            _source = source;
            ignoringCase = true;
        }
        
        public static implicit operator string (ReplaceWithSeparatedByIgnoringCase replaceString)
        {
            return replaceString.ToString ();
        }
        
        public override string ToString ()
        {
            throw new NotImplementedException ();
        }
    }
}

