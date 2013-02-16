using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStarting
    {
        private readonly RemoveString _source;
        private readonly int _positionIndex;

        internal RemoveStringStarting(RemoveString source, int positionIndex)
        {
            _source = source;
            _positionIndex = positionIndex;
        }

        public static implicit operator string(RemoveStringStarting removeStringStarting)
        {
            return removeStringStarting.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
