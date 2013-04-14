using System;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceAllWith
    {
        private readonly ReplaceAll _replaceAll;
        private readonly string _replacement;

        public ReplaceAllWith(ReplaceAll replaceAll, string replacement)
        {
            _replaceAll = replaceAll;
            _replacement = replacement;
        }

        internal ReplaceAll ReplaceAll { get { return _replaceAll; } }
        internal string Replacement { get { return _replacement; } }

        public static implicit operator string(ReplaceAllWith replaceAllWith)
        {
            return replaceAllWith.ToString();
        }

        public override string ToString()
        {
            return _replaceAll.Source.Replace(_replaceAll.Value, _replacement);
        }
    }
}

