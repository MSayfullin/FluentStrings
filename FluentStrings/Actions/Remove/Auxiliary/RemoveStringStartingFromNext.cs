using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromNext
    {
        private readonly RemoveStringStartingFrom _source;
        private readonly int _charsCount;

        internal RemoveStringStartingFromNext(RemoveStringStartingFrom source, int charsCount)
        {
            _source = source;
            _charsCount = charsCount;
        }

        public static implicit operator string(RemoveStringStartingFromNext removeStringStartingFromNext)
        {
            return removeStringStartingFromNext.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
