using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextBeforeOccurrence
    {
        private readonly RemoveText _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveTextBeforeOccurrence(RemoveText source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveTextBeforeOccurrence removeTextBeforeOccurrence)
        {
            return removeTextBeforeOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
