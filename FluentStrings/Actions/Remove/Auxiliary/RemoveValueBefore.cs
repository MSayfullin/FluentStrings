using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueBefore
    {
        private readonly RemoveValue _removeValue;
        private readonly string _marker;

        internal RemoveValueBefore(RemoveValue removeValue, string marker)
        {
            _removeValue = removeValue;
            _marker = marker;
        }

        public static implicit operator string(RemoveValueBefore removeValueBefore)
        {
            return removeValueBefore.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
