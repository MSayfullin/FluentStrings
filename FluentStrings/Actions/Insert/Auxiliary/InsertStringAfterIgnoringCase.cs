﻿using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterIgnoringCase
    {
        private readonly InsertStringAfter _insertStringAfter;

        internal InsertStringAfterIgnoringCase(InsertStringAfter insertStringAfter)
        {
            _insertStringAfter = insertStringAfter;
        }

        internal InsertStringAfter InsertStringAfter { get { return _insertStringAfter; } }

        public static implicit operator string(InsertStringAfterIgnoringCase insertStringAfterIgnoringCase)
        {
            return insertStringAfterIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _insertStringAfter.InsertString.Source.Insert(
                _insertStringAfter.InsertString.Insertion, _insertStringAfter.Marker,
                ignoreCase: true, occurrenceCount: 1, after: true);
        }
    }
}
