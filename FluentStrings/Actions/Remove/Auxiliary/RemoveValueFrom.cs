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
                    return _removeValue.Source.Remove(_removeValue.Extraction,
                        (s, e) =>
                        {
                            var index = s.LastIndexOf(e);
                            return index >= 0 ? s.Remove(index, e.Length) : s;
                        });
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().From() method");
            }
        }
    }
}
