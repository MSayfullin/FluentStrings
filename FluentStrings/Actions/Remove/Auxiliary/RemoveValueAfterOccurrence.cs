using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueAfterOccurrence
    {
        private readonly RemoveValue _removeValue;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveValueAfterOccurrence(RemoveValue removeValue, int occurrenceCount, string marker)
        {
            _removeValue = removeValue;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveValueAfterOccurrence removeValueAfterOccurrence)
        {
            return removeValueAfterOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
