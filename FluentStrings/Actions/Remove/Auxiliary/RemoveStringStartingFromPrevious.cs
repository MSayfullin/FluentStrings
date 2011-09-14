using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromPrevious
    {
        private readonly RemoveStringStartingFrom _source;
        private readonly int _charsCount;

        internal RemoveStringStartingFromPrevious(RemoveStringStartingFrom source, int charsCount)
        {
            _source = source;
            _charsCount = charsCount;
        }

        public static implicit operator string(RemoveStringStartingFromPrevious removeStringStartingFromPrevious)
        {
            return removeStringStartingFromPrevious.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
