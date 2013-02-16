using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceFromToOccurrence
    {
        private readonly RemoveStringStartingOccurrenceFrom _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingOccurrenceFromToOccurrence(RemoveStringStartingOccurrenceFrom source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceFromToOccurrence removeStringStartingOccurrenceFromToOccurrence)
        {
            return removeStringStartingOccurrenceFromToOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
