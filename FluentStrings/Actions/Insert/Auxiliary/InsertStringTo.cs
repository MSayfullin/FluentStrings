namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringTo
    {
        private readonly InsertString _insertString;
        private readonly The _position;

        internal InsertStringTo(InsertString insertString, The position)
        {
            _insertString = insertString;
            _position = position;
        }

        public static implicit operator string(InsertStringTo insertStringTo)
        {
            return insertStringTo.ToString();
        }

        public override string ToString()
        {
            return _position == The.Beginning
                ? _insertString
                : (_insertString.Source == null && _insertString.Insertion == null)
                    ? null
                    : _insertString.Source + _insertString.Insertion;
        }
    }
}
