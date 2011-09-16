using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrence
    {
        private readonly RemoveString _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringToOccurrence(RemoveString source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveStringToOccurrence removeStringToOccurrence)
        {
            return removeStringToOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
