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
        public static InsertString Insert(this string source, string value)
        {
            return new InsertString(source, value);
        }

        /// <summary>
        /// Extends Insert with the ability to change place of insertion
        /// N.B.: Default Insert() is equivalent of Insert().To(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for insertion</param>
        /// <param name="position">Position in string where to insert</param>
        public static InsertStringTo To(this InsertString source, The position)
        {
            return new InsertStringTo(source, position);
        }

        /// <summary>
        /// Extends Insert with the ability to change position of insertion
        /// N.B.: Default Insert() is equivalent of Insert().At(0).From(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for insertion</param>
        /// <param name="position">Position in string where to insert</param>
        public static InsertStringAt At(this InsertString source, int position)
        {
            return new InsertStringAt(source, position);
        }

        public static InsertStringAtFrom From(this InsertStringAt source, The position)
        {
            return new InsertStringAtFrom(source, position);
        }

        public static InsertStringBefore Before(this InsertString source, string marker)
        {
            return new InsertStringBefore(source, marker);
        }

        public static InsertStringBeforeOccurrence Before(this InsertString source, int occurrence, string of)
        {
            return new InsertStringBeforeOccurrence(source, occurrence, of);
        }

        public static InsertStringBeforeOccurrenceFrom From(this InsertStringBeforeOccurrence source, The position)
        {
            return new InsertStringBeforeOccurrenceFrom(source, position);
        }

        public static InsertStringAfter After(this InsertString source, string marker)
        {
            return new InsertStringAfter(source, marker);
        }

        public static InsertStringAfterOccurrence After(this InsertString source, int occurrence, string of)
        {
            return new InsertStringAfterOccurrence(source, occurrence, of);
        }

        public static InsertStringAfterOccurrenceFrom From(this InsertStringAfterOccurrence source, The position)
        {
            return new InsertStringAfterOccurrenceFrom(source, position);
        }
    }
}
