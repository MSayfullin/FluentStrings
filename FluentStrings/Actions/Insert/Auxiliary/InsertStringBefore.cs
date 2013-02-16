using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBefore
    {
        private readonly InsertString _insertString;
        private readonly string _marker;

        internal InsertStringBefore(InsertString insertString, string marker)
        {
            _insertString = insertString;
            _marker = marker;
        }

        public static implicit operator string(InsertStringBefore insertStringBefore)
        {
            return insertStringBefore.ToString();
        }

        public override string ToString()
        {
            if (_insertString.Source != null)
            {
                return _marker.IsEmpty()
                    ? _insertString.Source
                    : _insertString.Source.Replace(_marker, (_insertString.Insertion ?? String.Empty) + _marker);
            }
            else
                return _marker == null ? _insertString.Insertion : null;
        }
    }
}
