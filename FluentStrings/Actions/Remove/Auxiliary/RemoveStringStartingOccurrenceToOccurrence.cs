using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceToOccurrence
    {
        private readonly RemoveStringStartingOccurrence _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingOccurrenceToOccurrence(RemoveStringStartingOccurrence source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceToOccurrence removeStringStartingOccurrenceToOccurrence)
        {
            return removeStringStartingOccurrenceToOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
