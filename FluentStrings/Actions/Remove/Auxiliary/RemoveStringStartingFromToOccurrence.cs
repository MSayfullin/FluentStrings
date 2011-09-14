using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFromToOccurrence
    {
        private readonly RemoveStringStartingFrom _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingFromToOccurrence(RemoveStringStartingFrom source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringStartingFromToOccurrence removeStringStartingFromToOccurrence)
        {
            return removeStringStartingFromToOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
