﻿using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveAllIgnoringCase
    {
        private readonly RemoveAll _removeAll;

        internal RemoveAllIgnoringCase(RemoveAll removeAll)
        {
            _removeAll = removeAll;
        }

        public static implicit operator string(RemoveAllIgnoringCase removeAllIgnoringCase)
        {
            return removeAllIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeAll.Source.RemoveValues(null, _removeAll.Extraction, ignoreCase: true);
        }
    }
}
