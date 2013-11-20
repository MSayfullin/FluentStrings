using System.Text;
﻿namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertString
    {
        private readonly StringBuilder _source;
        private readonly string _insertion;

        internal InsertString(StringBuilder source, string insertion)
        {
            _source = source;
            _insertion = insertion;
        }

        internal StringBuilder Source { get { return _source; } }
        internal string Insertion { get { return _insertion; } }

        public static implicit operator string(InsertString insertString)
        {
            return insertString.ToString();
        }

        public override string ToString()
        {
            return (_source == null && _insertion == null)
                ? null
                : _insertion + _source.ToString();
        }
    }
}
