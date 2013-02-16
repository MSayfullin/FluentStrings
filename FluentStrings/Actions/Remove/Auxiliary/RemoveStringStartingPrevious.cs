using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingPrevious
    {
        private readonly RemoveStringStarting _source;
        private readonly int _charsCount;

        internal RemoveStringStartingPrevious(RemoveStringStarting source, int charsCount)
        {
            _source = source;
            _charsCount = charsCount;
        }

        public static implicit operator string(RemoveStringStartingPrevious removeStringStartingPrevious)
        {
            return removeStringStartingPrevious.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
