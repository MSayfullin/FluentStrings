using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveString
    {
        private readonly string _source;

        internal RemoveString(string source)
        {
            _source = source;
        }

        public static implicit operator string(RemoveString removeString)
        {
            return removeString.ToString();
        }

        public override string ToString()
        {
            return _source != null ? String.Empty : null;
        }
    }
}
