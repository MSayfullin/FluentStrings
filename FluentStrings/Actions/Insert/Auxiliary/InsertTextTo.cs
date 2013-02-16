namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextTo
    {
        private readonly InsertText _insertText;
        private readonly The _position;

        internal InsertTextTo(InsertText insertText, The position)
        {
            _insertText = insertText;
            _position = position;
        }

        public static implicit operator string(InsertTextTo insertTextTo)
        {
            return insertTextTo.ToString();
        }

        public override string ToString()
        {
            return _position == The.Beginning
                ? _insertText
                : (_insertText.Source == null && _insertText.Insertion == null)
                    ? null
                    : _insertText.Source + _insertText.Insertion;
        }
    }
}
