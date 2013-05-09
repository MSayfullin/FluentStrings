﻿using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterOccurrenceIgnoringCase
    {
        private readonly InsertStringAfterOccurrence _insertStringAfterOccurrence;

        internal InsertStringAfterOccurrenceIgnoringCase(InsertStringAfterOccurrence insertStringAfterOccurrence)
        {
            _insertStringAfterOccurrence = insertStringAfterOccurrence;
        }

        internal InsertStringAfterOccurrence InsertStringAfterOccurrence { get { return _insertStringAfterOccurrence; } }

        public static implicit operator string(InsertStringAfterOccurrenceIgnoringCase insertStringAfterOccurrenceIgnoringCase)
        {
            return insertStringAfterOccurrenceIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _insertStringAfterOccurrence.InsertString.Source.Insert(
                _insertStringAfterOccurrence.InsertString.Insertion, _insertStringAfterOccurrence.Marker,
                ignoreCase: true, occurrenceCount: _insertStringAfterOccurrence.OccurrenceCount, after: true);
        }
    }
}
