using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveChars : IPositional
    {
        private readonly string _source;
        private readonly int _charsCount;
        private The _position;

        internal RemoveChars(string source, int charsCount)
        {
            _source = source;
            _charsCount = charsCount;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveChars removeChars)
        {
            return removeChars.ToString();
        }

        public override string ToString()
        {
            if (_source.IsEmpty())
                return _source;

            if (_charsCount > _source.Length)
                return String.Empty;

            switch (_position)
            {
                case The.Beginning:
                    return _source.Remove(0, _charsCount);
                case The.End:
                    return _source.Remove(_source.Length - _charsCount, _charsCount);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by RemoveChars().From() method");
            }
        }

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _position = position;
        }

        #endregion
    }
}
