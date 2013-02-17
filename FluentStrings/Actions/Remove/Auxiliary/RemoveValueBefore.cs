using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextBefore
    {
        private readonly RemoveText _source;
        private readonly string _marker;

        internal RemoveTextBefore(RemoveText source, string marker)
        {
            _source = source;
            _marker = marker;
        }

        public static implicit operator string(RemoveTextBefore removeTextBefore)
        {
            return removeTextBefore.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
