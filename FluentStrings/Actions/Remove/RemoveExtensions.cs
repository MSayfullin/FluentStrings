using dokas.FluentStrings.Actions.Remove;

namespace dokas.FluentStrings
{
    public static class RemoveExtensions
    {
        #region Remove

        /// <summary>
        /// Terminates string itself.
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <returns>Null if string is null and String.Empty in all other cases</returns>
        public static RemoveString Remove(this string source)
        {
            return new RemoveString(source);
        }

        /// <summary>
        /// Removes first value occurrence from the source string.
        /// Action is case sensitive by default, use IgnoringCase extension to change behaviour.
        /// <para>N.B.: Default Remove() is equivalent of Remove().From(The.Beginning)</para>
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="value">String to be removed</param>
        public static RemoveValue Remove(this string source, string value)
        {
            return new RemoveValue(source, value);
        }

        /// <summary>
        /// Removes defined number of value occurrences from the source string.
        /// Action is case sensitive by default, use IgnoringCase extension to change behaviour.
        /// <para>N.B.: Default Remove() is equivalent of Remove().From(The.Beginning)</para>
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="quantity">Number of values to remove</param>
        /// <param name="value">String to be removed</param>
        public static RemoveValues Remove(this string source, int quantity, string value)
        {
            return new RemoveValues(source, quantity, value);
        }

        /// <summary>
        /// Removes all value occurrences from the source string.
        /// Action is case sensitive by default, use IgnoringCase extension to change behaviour.
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="value">String to be removed</param>
        public static RemoveAll RemoveAll(this string source, string value)
        {
            return new RemoveAll(source, value);
        }

        #endregion

        #region Remove Chars

        /// <summary>
        /// Removes number of chars from the source string.
        /// <para>N.B.: Default RemoveChars() is equivalent of RemoveChars().From(The.Beginning)</para>
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="quantity">Number of chars to remove</param>
        public static RemoveChars RemoveChars(this string source, int quantity)
        {
            return new RemoveChars(source, quantity);
        }

        /// <summary>
        /// Removes selected chars from the source string
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="chars">Chars to be removed</param>
        public static RemoveSelectedChars RemoveChars(this string source, params char[] chars)
        {
            return new RemoveSelectedChars(source, chars);
        }

        #endregion

        #region Starting

        /// <summary>
        /// Removes substring starting character position in the source string.
        /// This action is inclusive.
        /// <para>N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Starting position in string for removal.</param>
        public static RemoveStringStarting Starting(this RemoveString source, int position)
        {
            return new RemoveStringStarting(source, position);
        }

        /// <summary>
        /// Removes substring starting from the first marker in the source string.
        /// This action is inclusive.
        /// <para>N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)</para>
        /// </summary>
        /// <param name="marker">Marker value for removal point.</param>
        public static RemoveStringStartingOccurrence Starting(this RemoveString source, string marker)
        {
            return source.Starting(1, of: marker);
        }

        /// <summary>
        /// Removes substring starting from the given occurrence of the marker in the source string.
        /// This action is inclusive.
        /// <para>N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)</para>
        /// </summary>
        /// <param name="occurrence">Occurrence count to start from.</param>
        /// <param name="of">Marker value for removal point.</param>
        public static RemoveStringStartingOccurrence Starting(this RemoveString source, int occurrence, string of)
        {
            return new RemoveStringStartingOccurrence(source, occurrence, of);
        }

        /// <summary>
        /// Removes substring starting from the first occurrence of the marker in the source string.
        /// This allows to make Remove.Starting action exclusive.
        /// <para>N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="marker">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringStartingOccurrencePosition Starting(this RemoveString source, The position, string marker)
        {
            return source.Starting(position, 1, of: marker);
        }

        /// <summary>
        /// Removes substring starting from the given occurrence of the marker in the source string.
        /// This allows to make Remove.Starting action exclusive.
        /// <para>N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="occurrence">Occurrence count to start from.</param>
        /// <param name="of">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringStartingOccurrencePosition Starting(this RemoveString source, The position, int occurrence, string of)
        {
            return new RemoveStringStartingOccurrencePosition(source, position, occurrence, of);
        }

        #endregion

        #region To

        /// <summary>
        /// Removes substring up to character position in the source string.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().To() is equivalent of Remove().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">End position in string for removal.</param>
        public static RemoveStringTo To(this RemoveString source, int position)
        {
            return new RemoveStringTo(source, position);
        }

        /// <summary>
        /// Removes substring up to the first marker in the source string.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().To() is equivalent of Remove().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="marker">Marker value for removal point.</param>
        public static RemoveStringToOccurrence To(this RemoveString source, string marker)
        {
            return source.To(1, of: marker);
        }

        /// <summary>
        /// Removes substring up to the given occurrence of the marker in the source string.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().To() is equivalent of Remove().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="occurrence">Occurrence count to remove to.</param>
        /// <param name="of">Marker value for removal point.</param>
        public static RemoveStringToOccurrence To(this RemoveString source, int occurrence, string of)
        {
            return new RemoveStringToOccurrence(source, occurrence, of);
        }

        /// <summary>
        /// Removes substring up to the first occurrence of the marker in the source string.
        /// This allows to make Remove.To action inclusive.
        /// <para>N.B.: Default Remove().To() is equivalent of Remove().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="marker">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringToOccurrencePosition To(this RemoveString source, The position, string marker)
        {
            return source.To(position, 1, of: marker);
        }

        /// <summary>
        /// Removes substring up to the given occurrence of the marker in the source string.
        /// This allows to make Remove.To action inclusive.
        /// <para>N.B.: Default Remove().To() is equivalent of Remove().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="occurrence">Occurrence count to start from.</param>
        /// <param name="of">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringToOccurrencePosition To(this RemoveString source, The position, int occurrence, string of)
        {
            return new RemoveStringToOccurrencePosition(source, position, occurrence, of);
        }



        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">End position in string for removal.</param>
        public static RemoveStringStartingTo To(this RemoveStringStarting source, int position)
        {
            return new RemoveStringStartingTo(source, position);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">End position in string for removal.</param>
        public static RemoveStringStartingOccurrenceTo To(this RemoveStringStartingOccurrence source, int position)
        {
            return new RemoveStringStartingOccurrenceTo(source, position);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">End position in string for removal.</param>
        public static RemoveStringStartingOccurrencePositionTo To(this RemoveStringStartingOccurrencePosition source, int position)
        {
            return new RemoveStringStartingOccurrencePositionTo(source, position);
        }



        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the first marker.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="marker">Marker value for removal point.</param>
        public static RemoveStringStartingToOccurrence To(this RemoveStringStarting source, string marker)
        {
            return source.To(1, of: marker);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the first marker.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="marker">Marker value for removal point.</param>
        public static RemoveStringStartingOccurrenceToOccurrence To(this RemoveStringStartingOccurrence source, string marker)
        {
            return source.To(1, of: marker);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the first marker.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="marker">Marker value for removal point.</param>
        public static RemoveStringStartingOccurrencePositionToOccurrence To(this RemoveStringStartingOccurrencePosition source, string marker)
        {
            return source.To(1, of: marker);
        }



        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the given occurrence of the marker.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="occurrence">Occurrence count to remove to.</param>
        /// <param name="of">Marker value for removal point.</param>
        public static RemoveStringStartingToOccurrence To(this RemoveStringStarting source, int occurrence, string of)
        {
            return new RemoveStringStartingToOccurrence(source, occurrence, of);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the given occurrence of the marker.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="occurrence">Occurrence count to remove to.</param>
        /// <param name="of">Marker value for removal point.</param>
        public static RemoveStringStartingOccurrenceToOccurrence To(this RemoveStringStartingOccurrence source, int occurrence, string of)
        {
            return new RemoveStringStartingOccurrenceToOccurrence(source, occurrence, of);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the given occurrence of the marker.
        /// This action is exclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="occurrence">Occurrence count to remove to.</param>
        /// <param name="of">Marker value for removal point.</param>
        public static RemoveStringStartingOccurrencePositionToOccurrence To(this RemoveStringStartingOccurrencePosition source, int occurrence, string of)
        {
            return new RemoveStringStartingOccurrencePositionToOccurrence(source, occurrence, of);
        }



        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the first occurrence of the marker.
        /// This allows to make Remove.Starting.To action inclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="marker">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringStartingToOccurrencePosition To(this RemoveStringStarting source, The position, string marker)
        {
            return source.To(position, 1, of: marker);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the first occurrence of the marker.
        /// This allows to make Remove.Starting.To action inclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="marker">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringStartingOccurrenceToOccurrencePosition To(this RemoveStringStartingOccurrence source, The position, string marker)
        {
            return source.To(position, 1, of: marker);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the first occurrence of the marker.
        /// This allows to make Remove.Starting.To action inclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="marker">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringStartingOccurrencePositionToOccurrencePosition To(this RemoveStringStartingOccurrencePosition source, The position, string marker)
        {
            return source.To(position, 1, of: marker);
        }



        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the given occurrence of the marker.
        /// This allows to make Remove.Starting.To action inclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="occurrence">Occurrence count to start from.</param>
        /// <param name="of">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringStartingToOccurrencePosition To(this RemoveStringStarting source, The position, int occurrence, string of)
        {
            return new RemoveStringStartingToOccurrencePosition(source, position, occurrence, of);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the first occurrence of the marker.
        /// This allows to make Remove.Starting.To action inclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="marker">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringStartingOccurrenceToOccurrencePosition To(this RemoveStringStartingOccurrence source, The position, int occurrence, string of)
        {
            return new RemoveStringStartingOccurrenceToOccurrencePosition(source, position, occurrence, of);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal to the first occurrence of the marker.
        /// This allows to make Remove.Starting.To action inclusive.
        /// <para>N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="marker">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used.</exception>
        public static RemoveStringStartingOccurrencePositionToOccurrencePosition To(this RemoveStringStartingOccurrencePosition source, The position, int occurrence, string of)
        {
            return new RemoveStringStartingOccurrencePositionToOccurrencePosition(source, position, occurrence, of);
        }

        #endregion

        #region Remove Vowels

        /// <summary>
        /// Removes vowels from source string for a culture set on a CurrentThread.
        /// <para>N.B.: Thread.CurrentThread.CurrentCulture property is used</para>
        /// </summary>
        /// <param name="source">Target string for removal</param>
        public static RemoveVowels RemoveVowels(this string source)
        {
            return new RemoveVowels(source);
        }

        /// <summary>
        /// Removes vowels from source string for a defined culture
        /// </summary>
        /// <param name="cultureName">Culture name in a .net format. e.g. "en-US", "ru"</param>
        public static RemoveVowelsFor For(this RemoveVowels source, string cultureName)
        {
            return new RemoveVowelsFor(source, cultureName);
        }

        #endregion
    }
}
