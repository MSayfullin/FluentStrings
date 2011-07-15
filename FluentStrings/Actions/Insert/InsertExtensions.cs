namespace dokas.FluentStrings.Actions.Insert
{
    public static class InsertExtensions
    {
        /// <summary>
        /// Inserts value to the beginning of the source string
        /// </summary>
        /// <param name="source">String in which to insert</param>
        /// <param name="value">String to be inserted</param>
        public static InsertText Insert(this string source, string value)
        {
            return new InsertText(source, value);
        }

        /// <summary>
        /// Extends Insert with the ability to change place of insertion
        /// N.B.: Default Insert() is equivalent of Insert().To(Position.Beginning)
        /// </summary>
        /// <param name="source">String in which to insert</param>
        /// <param name="position">Position in string where to insert</param>
        public static InsertTextTo To(this InsertText source, Position position)
        {
            return new InsertTextTo(source, position);
        }

        /// <summary>
        /// Extends Insert with the ability to change position of insertion
        /// N.B.: Default Insert() is equivalent of Insert().At(0) or Insert().At(1)
        /// </summary>
        /// <param name="source">String in which to insert</param>
        /// <param name="positionIndex">Position in string where to insert</param>
        public static InsertTextAt At(this InsertText source, int positionIndex)
        {
            return new InsertTextAt(source, positionIndex);
        }

        public static InsertTextAtFrom From(this InsertTextAt source, Position position)
        {
            return new InsertTextAtFrom(source, position);
        }

        public static InsertTextBefore Before(this InsertText source, string marker)
        {
            return new InsertTextBefore(source, marker);
        }

        public static InsertTextBeforeOccurrence Before(this InsertText source, int occurrence, string marker)
        {
            return new InsertTextBeforeOccurrence(source, occurrence, marker);
        }

        public static InsertTextBeforeOccurrenceFrom From(this InsertTextBeforeOccurrence source, Position position)
        {
            return new InsertTextBeforeOccurrenceFrom(source, position);
        }

        public static InsertTextAfter After(this InsertText source, string marker)
        {
            return new InsertTextAfter(source, marker);
        }

        public static InsertTextAfterOccurrence After(this InsertText source, int occurrence, string marker)
        {
            return new InsertTextAfterOccurrence(source, occurrence, marker);
        }

        public static InsertTextAfterOccurrenceFrom From(this InsertTextAfterOccurrence source, Position position)
        {
            return new InsertTextAfterOccurrenceFrom(source, position);
        }
    }
}
