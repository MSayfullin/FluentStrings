using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveCharsFrom
    {
        private readonly RemoveChars _removeChars;
        private readonly The _position;

        internal RemoveCharsFrom(RemoveChars removeChars, The position)
        {
            _removeChars = removeChars;
            _position = position;
        }

        public static implicit operator string(RemoveCharsFrom removeCharsFrom)
        {
            return removeCharsFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeChars;
                case The.End:
                    return _removeChars.Source.IsEmpty()
                        ? _removeChars
                        : _removeChars.CharsCount <= _removeChars.Source.Length
                            ? _removeChars.Source.Remove(_removeChars.Source.Length - _removeChars.CharsCount, _removeChars.CharsCount)
                            : String.Empty;
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by RemoveChars().From() method");
            }
        }
    }
}
