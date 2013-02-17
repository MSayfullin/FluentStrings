using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveTextAfter
    {
        private readonly RemoveText _source;
        private readonly string _marker;

        internal RemoveTextAfter(RemoveText source, string marker)
        {
            _source = source;
            _marker = marker;
        }

        public static implicit operator string(RemoveTextAfter removeTextAfter)
        {
            return removeTextAfter.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
