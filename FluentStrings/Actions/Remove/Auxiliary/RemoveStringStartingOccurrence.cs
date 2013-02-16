using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrence
    {
        private readonly RemoveString _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingOccurrence(RemoveString source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringStartingOccurrence removeStringStartingOccurrence)
        {
            return removeStringStartingOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
