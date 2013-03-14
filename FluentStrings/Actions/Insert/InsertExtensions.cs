using dokas.FluentStrings.Actions.Insert;

namespace dokas.FluentStrings
{
    public static class InsertExtensions
    {
        /// <summary>
        /// Inserts value to the beginning of the given string.
        /// N.B.: Default Insert() is equivalent of Insert().To(The.Beginning)
        /// and Insert().At(position: 0).From(The.Beginning)
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
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used.</exception>
        public static InsertStringTo To(this InsertString source, The position)
        {
            return new InsertStringTo(source, position);
        }

        /// <summary>
        /// Extends Insert action with the ability to change position of insertion.
        /// N.B.: Default Insert().At() is equivalent of Insert().At().From(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for insertion.</param>
        /// <param name="position">Position in string for insertion.</param>
        public static InsertStringAt At(this InsertString source, int position)
        {
            return new InsertStringAt(source, position);
        }

        /// <summary>
        /// Extends Insert.At action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End value can be used.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used.</exception>
        public static InsertStringAtFrom From(this InsertStringAt source, The position)
        {
            return new InsertStringAtFrom(source, position);
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
        /// Extends Insert.BeforeAll action with the ability to ignore case.
        /// </summary>
        public static InsertStringBeforeAllIgnoringCase IgnoringCase(this InsertStringBeforeAll source)
        {
            return new InsertStringBeforeAllIgnoringCase(source);
        }

        /// <summary>
        /// Extends Insert action with the ability to set insertion point through the marker.
        /// Given string is inserted BEFORE first marker in the target string.
        /// N.B.: Default Insert().Before() is equivalent of Insert().Before().From(The.Beginning)
        /// </summary>
        /// <param name="marker">Marker value for insertion point.</param>
        public static InsertStringBefore Before(this InsertString source, string marker)
        {
            return new InsertStringBefore (source, marker);
        }

        /// <summary>
        /// Extends Insert.Before action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End value can be used.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used.</exception>
        public static InsertStringBeforeFrom From(this InsertStringBefore source, The position)
        {
            return new InsertStringBeforeFrom(source, position);
        }

        /// <summary>
        /// Extends Insert.Before action with the ability to ignore case.
        /// </summary>
        public static InsertStringBeforeIgnoringCase IgnoringCase(this InsertStringBefore source)
        {
            return new InsertStringBeforeIgnoringCase(source);
        }

        /// <summary>
        /// Extends Insert.Before.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End value can be used.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used.</exception>
        public static InsertStringBeforeIgnoringCaseFrom From(this InsertStringBeforeIgnoringCase source, The position)
        {
            return new InsertStringBeforeIgnoringCaseFrom(source, position);
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
        /// Extends Insert.BeforeOccurrence action with the ability to ignore case.
        /// </summary>
        public static InsertStringBeforeOccurrenceIgnoringCase IgnoringCase(this InsertStringBeforeOccurrence source)
        {
            return new InsertStringBeforeOccurrenceIgnoringCase(source);
        }

        /// <summary>
        /// Extends Insert.BeforeOccurrence action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End value can be used.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used.</exception>
        public static InsertStringBeforeOccurrenceFrom From(this InsertStringBeforeOccurrence source, The position)
        {
            return new InsertStringBeforeOccurrenceFrom(source, position);
        }

        /// <summary>
        /// Extends Insert.BeforeOccurrence.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End value can be used.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used.</exception>
        public static InsertStringBeforeOccurrenceIgnoringCaseFrom From(this InsertStringBeforeOccurrenceIgnoringCase source, The position)
        {
            return new InsertStringBeforeOccurrenceIgnoringCaseFrom(source, position);
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
        /// Extends Insert.AfterAll action with the ability to ignore case.
        /// </summary>
        public static InsertStringAfterAllIgnoringCase IgnoringCase(this InsertStringAfterAll source)
        {
            return new InsertStringAfterAllIgnoringCase(source);
        }

        /// <summary>
        /// Extends Insert action with the ability to set insertion point through some marker.
        /// Given string is inserted AFTER first marker in the target string.
        /// N.B.: Default Insert().After() is equivalent of Insert().After().From(The.Beginning)
        /// </summary>
        /// <param name="marker">Marker value for insertion point.</param>
        public static InsertStringAfter After(this InsertString source, string marker)
        {
            return new InsertStringAfter(source, marker);
        }

        /// <summary>
        /// Extends Insert.After action with the ability to ignore case.
        /// </summary>
        public static InsertStringAfterIgnoringCase IgnoringCase(this InsertStringAfter source)
        {
            return new InsertStringAfterIgnoringCase(source);
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

        /// <summary>
        /// Extends Insert.AfterOccurrence action with the ability to ignore case.
        /// </summary>
        public static InsertStringAfterOccurrenceIgnoringCase IgnoringCase(this InsertStringAfterOccurrence source)
        {
            return new InsertStringAfterOccurrenceIgnoringCase(source);
        }

        /// <summary>
        /// Extends Insert.After action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End value can be used.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used.</exception>
        public static InsertStringAfterOccurrenceFrom From(this InsertStringAfterOccurrence source, The position)
        {
            return new InsertStringAfterOccurrenceFrom(source, position);
        }
    }
}
