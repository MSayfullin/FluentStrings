using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringTo
    {
        private readonly RemoveString _source;
        private readonly int _positionIndex;

        internal RemoveStringTo(RemoveString source, int positionIndex)
        {
            _source = source;
            _positionIndex = positionIndex;
        }

        public static implicit operator string(RemoveStringTo removeStringTo)
        {
            return removeStringTo.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
