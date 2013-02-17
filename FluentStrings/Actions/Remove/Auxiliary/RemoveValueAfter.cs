using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueAfter
    {
        private readonly RemoveValue _removeValue;
        private readonly string _marker;

        internal RemoveValueAfter(RemoveValue removeValue, string marker)
        {
            _removeValue = removeValue;
            _marker = marker;
        }

        public static implicit operator string(RemoveValueAfter removeValueAfter)
        {
            return removeValueAfter.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
