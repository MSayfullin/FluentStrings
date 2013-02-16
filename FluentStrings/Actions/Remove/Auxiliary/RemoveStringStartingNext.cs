using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingNext
    {
        private readonly RemoveStringStarting _source;
        private readonly int _charsCount;

        internal RemoveStringStartingNext(RemoveStringStarting source, int charsCount)
        {
            _source = source;
            _charsCount = charsCount;
        }

        public static implicit operator string(RemoveStringStartingNext removeStringStartingNext)
        {
            return removeStringStartingNext.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
