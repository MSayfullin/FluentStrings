using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringIgnoringCase
    {
        private readonly RemoveText _removeText;

        public RemoveStringIgnoringCase(RemoveText removeText)
        {
            _removeText = removeText;
        }

        internal RemoveText RemoveText { get { return _removeText; } }

        public static implicit operator string(RemoveStringIgnoringCase removeStringIgnoringCase)
        {
            return removeStringIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return (_removeText.Source.IsEmpty() || _removeText.Extraction.IsEmpty())
                ? _removeText.Source
                : _removeText.Source.Remove(_removeText.Source.IndexOf(_removeText.Extraction, StringComparison.CurrentCultureIgnoreCase), _removeText.Extraction.Length);
        }
    }
}
