using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueFrom
    {
        private readonly RemoveValue _removeValue;
        private readonly The _position;

        internal RemoveValueFrom(RemoveValue removeValue, The position)
        {
            _removeValue = removeValue;
            _position = position;
        }

        public static implicit operator string(RemoveValueFrom removeValueFrom)
        {
            return removeValueFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeValue;
                case The.End:
                    return (_removeValue.Source.IsEmpty() || _removeValue.Extraction.IsEmpty())
                        ? _removeValue.Source
                        : _removeValue.Source.Remove(_removeValue.Source.LastIndexOf(_removeValue.Extraction), _removeValue.Extraction.Length);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().From() method");
            }
        }
    }
}
