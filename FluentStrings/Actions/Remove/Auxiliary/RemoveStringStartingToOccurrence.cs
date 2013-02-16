using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToOccurrence
    {
        private readonly RemoveStringStarting _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingToOccurrence(RemoveStringStarting source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringStartingToOccurrence removeStringStartingToOccurrence)
        {
            return removeStringStartingToOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
