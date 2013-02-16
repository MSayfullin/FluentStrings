using System;

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
            switch (_position)
            {
                case The.Beginning:
                    return _insertString;
                case The.End:
                    return (_insertString.Source == null && _insertString.Insertion == null)
                        ? null
                        : _insertString.Source + _insertString.Insertion;
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Insert().To() method");
            }
        }
    }
}
