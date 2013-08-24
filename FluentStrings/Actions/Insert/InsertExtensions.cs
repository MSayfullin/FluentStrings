using dokas.FluentStrings.Actions.Insert;

namespace dokas.FluentStrings
{
    public static class InsertExtensions
    {
        /// <summary>
        /// Inserts value to the beginning of the given string.
        /// <para>N.B.: Default Insert() is equivalent of Insert().To(The.Beginning)
        /// and Insert().At(position: 0).From(The.Beginning)</para>
        /// </summary>
        /// <param name="source">Target string for insertion.</param>
        /// <param name="value">String to be inserted.</param>
        public static InsertString Insert(this string source, string value)
        {
            return new InsertString(source, value);
        }

        /// <summary>
        /// Extends Insert action with the ability to change place of insertion.
        /// </summary>
        /// <param name="source">Target string for insertion.</param>
        /// <param name="position">
        /// Position in source string for insertion. Beginning or End value can be used.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used.</exception>
        public static InsertStringTo To(this InsertString source, The position)
        {
            return new InsertStringTo(source, position);
        }

        /// <summary>
        /// Extends Insert action with the ability to change position of insertion.
        /// <para>N.B.: Default Insert().At() is equivalent of Insert().At().From(The.Beginning)</para>
        /// </summary>
        /// <param name="source">Target string for insertion.</param>
        /// <param name="position">Position in string for insertion.</param>
        public static InsertStringAt At(this InsertString source, int position)
        {
            return new InsertStringAt(source, position);
        }

        /// <summary>
        /// Extends Insert action with the ability to set insertion point through the marker.
        /// Given string is inserted BEFORE all markers in the target string.
        /// </summary>
        /// <param name="marker">Marker value for insertion point.</param>
        public static InsertStringBeforeAll BeforeAll(this InsertString source, string marker)
        {
            return new InsertStringBeforeAll(source, marker);
        }

        /// <summary>
        /// Extends Insert action with the ability to set insertion point through the marker.
        /// Given string is inserted BEFORE first marker in the target string.
        /// <para>N.B.: Default Insert().Before() is equivalent of Insert().Before().From(The.Beginning)</para>
        /// </summary>
        /// <param name="marker">Marker value for insertion point.</param>
        public static InsertStringBefore Before(this InsertString source, string marker)
        {
            return new InsertStringBefore (source, marker);
        }

        /// <summary>
        /// Extends Insert action with the ability to set insertion point through occurrence of the marker.
        /// Given string is inserted right BEFORE the marker.
        /// </summary>
        /// <param name="occurrence">Marker occurrence value for insertion point.</param>
        /// <param name="of">Marker value for insertion point.</param>
        public static InsertStringBeforeOccurrence Before(this InsertString source, int occurrence, string of)
        {
            return new InsertStringBeforeOccurrence(source, occurrence, of);
        }

        /// <summary>
        /// Extends Insert action with the ability to set insertion point through some marker.
        /// Given string is inserted AFTER all markers in the target string.
        /// </summary>
        /// <param name="marker">Marker value for insertion point.</param>
        public static InsertStringAfterAll AfterAll(this InsertString source, string marker)
        {
            return new InsertStringAfterAll(source, marker);
        }

        /// <summary>
        /// Extends Insert action with the ability to set insertion point through some marker.
        /// Given string is inserted AFTER first marker in the target string.
        /// <para>N.B.: Default Insert().After() is equivalent of Insert().After().From(The.Beginning)</para>
        /// </summary>
        /// <param name="marker">Marker value for insertion point.</param>
        public static InsertStringAfter After(this InsertString source, string marker)
        {
            return new InsertStringAfter(source, marker);
        }

        /// <summary>
        /// Extends Insert action with the ability to set insertion point through occurrence of the marker.
        /// Given string is inserted right AFTER the marker.
        /// </summary>
        /// <param name="occurrence">Marker occurrence value for insertion point.</param>
        /// <param name="of">Marker value for insertion point.</param>
        public static InsertStringAfterOccurrence After(this InsertString source, int occurrence, string of)
        {
            return new InsertStringAfterOccurrence(source, occurrence, of);
        }
    }
}
