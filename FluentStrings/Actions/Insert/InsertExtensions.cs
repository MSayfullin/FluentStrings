using dokas.FluentStrings.Actions.Insert;

namespace dokas.FluentStrings
{
    public static class InsertExtensions
    {
        /// <summary>
        /// Inserts value to the beginning of the given string
        /// </summary>
        /// <param name="source">Target string for insertion</param>
        /// <param name="value">String to be inserted</param>
        public static InsertText Insert(this string source, string value)
        {
            return new InsertText(source, value);
        }

        /// <summary>
        /// Extends Insert with the ability to change place of insertion
        /// N.B.: Default Insert() is equivalent of Insert().To(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for insertion</param>
        /// <param name="position">Position in string where to insert</param>
        public static InsertTextTo To(this InsertText source, The position)
        {
            return new InsertTextTo(source, position);
        }

        /// <summary>
        /// Extends Insert with the ability to change position of insertion
        /// N.B.: Default Insert() is equivalent of Insert().At(0).From(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for insertion</param>
        /// <param name="position">Position in string where to insert</param>
        public static InsertTextAt At(this InsertText source, int position)
        {
            return new InsertTextAt(source, position);
        }

        public static InsertTextAtFrom From(this InsertTextAt source, The position)
        {
            return new InsertTextAtFrom(source, position);
        }

        public static InsertTextBefore Before(this InsertText source, string marker)
        {
            return new InsertTextBefore(source, marker);
        }

        public static InsertTextBeforeOccurrence Before(this InsertText source, int occurrence, string of)
        {
            return new InsertTextBeforeOccurrence(source, occurrence, of);
        }

        public static InsertTextBeforeOccurrenceFrom From(this InsertTextBeforeOccurrence source, The position)
        {
            return new InsertTextBeforeOccurrenceFrom(source, position);
        }

        public static InsertTextAfter After(this InsertText source, string marker)
        {
            return new InsertTextAfter(source, marker);
        }

        public static InsertTextAfterOccurrence After(this InsertText source, int occurrence, string of)
        {
            return new InsertTextAfterOccurrence(source, occurrence, of);
        }

        public static InsertTextAfterOccurrenceFrom From(this InsertTextAfterOccurrence source, The position)
        {
            return new InsertTextAfterOccurrenceFrom(source, position);
        }
    }
}
