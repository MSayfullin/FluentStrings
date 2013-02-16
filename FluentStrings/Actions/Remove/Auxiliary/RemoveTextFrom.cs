using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextFrom
    {
        private readonly RemoveText _removeText;
        private readonly The _position;

        internal RemoveTextFrom(RemoveText removeText, The position)
        {
            _removeText = removeText;
            _position = position;
        }

        public static implicit operator string(RemoveTextFrom removeTextFrom)
        {
            return removeTextFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeText;
                case The.End:
                    return (_removeText.Source == null || _removeText.Extraction.IsEmpty())
                        ? _removeText.Source
                        : _removeText.Source.Remove(_removeText.Source.LastIndexOf(_removeText.Extraction), _removeText.Extraction.Length);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().From() method");
            }
        }
    }
}
