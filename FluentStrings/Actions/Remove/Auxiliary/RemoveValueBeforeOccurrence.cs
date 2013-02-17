using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueBeforeOccurrence
    {
        private readonly RemoveValue _removeValue;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveValueBeforeOccurrence(RemoveValue removeValue, int occurrenceCount, string marker)
        {
            _removeValue = removeValue;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        public static implicit operator string(RemoveValueBeforeOccurrence removeValueBeforeOccurrence)
        {
            return removeValueBeforeOccurrence.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
