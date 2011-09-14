using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextAfterOccurrence
    {
        private readonly RemoveText _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveTextAfterOccurrence(RemoveText source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveTextAfterOccurrence removeTextAfterOccurrence)
        {
            return removeTextAfterOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
