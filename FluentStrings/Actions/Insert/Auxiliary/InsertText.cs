namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertText
    {
        private readonly string _source;
        private readonly string _insertion;

        internal InsertText(string source, string insertion)
        {
            _source = source;
            _insertion = insertion;
        }

        internal string Source { get { return _source; } }
        internal string Insertion { get { return _insertion; } }

        public static implicit operator string(InsertText insertText)
        {
            return insertText.ToString();
        }

        public override string ToString()
        {
            return (_source == null && _insertion == null)
                ? null
                : _insertion + _source;
        }
    }
}
