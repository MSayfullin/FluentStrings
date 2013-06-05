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
        /// N.B.: Default Remove() is equivalent of Remove().From(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="value">String to be removed</param>
        public static RemoveValue Remove(this string source, string value)
        {
            return new RemoveValue(source, value);
        }

        /// <summary>
        /// Extends Remove action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveValueFrom From(this RemoveValue source, The position)
        {
            return new RemoveValueFrom(source, position);
        }

        /// <summary>
        /// Extends Remove action with the ability to ignore case.
        /// </summary>
        public static RemoveValueIgnoringCase IgnoringCase(this RemoveValue source)
        {
            return new RemoveValueIgnoringCase(source);
        }

        /// <summary>
        /// Extends Remove.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveValueIgnoringCaseFrom From(this RemoveValueIgnoringCase source, The position)
        {
            return new RemoveValueIgnoringCaseFrom(source, position);
        }



        /// <summary>
        /// Removes defined number of value occurrences from the source string.
        /// Action is case sensitive by default, use IgnoringCase extension to change behaviour.
        /// N.B.: Default Remove() is equivalent of Remove().From(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="quantity">Number of values to remove</param>
        /// <param name="value">String to be removed</param>
        public static RemoveValues Remove(this string source, int quantity, string value)
        {
            return new RemoveValues(source, quantity, value);
        }

        /// <summary>
        /// Extends Remove action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveValuesFrom From(this RemoveValues source, The position)
        {
            return new RemoveValuesFrom(source, position);
        }

        /// <summary>
        /// Extends Remove action with the ability to ignore case.
        /// </summary>
        public static RemoveValuesIgnoringCase IgnoringCase(this RemoveValues source)
        {
            return new RemoveValuesIgnoringCase(source);
        }

        /// <summary>
        /// Extends Remove.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveValuesIgnoringCaseFrom From(this RemoveValuesIgnoringCase source, The position)
        {
            return new RemoveValuesIgnoringCaseFrom(source, position);
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

        /// <summary>
        /// Extends RemoveAll action with the ability to ignore case
        /// </summary>
        public static RemoveAllIgnoringCase IgnoringCase(this RemoveAll source)
        {
            return new RemoveAllIgnoringCase(source);
        }

        #endregion

        #region Before

        public static RemoveValueBefore Before(this RemoveValue source, string marker)
        {
            return new RemoveValueBefore(source, marker);
        }

        public static RemoveValueBeforeFrom From(this RemoveValueBefore source, The position)
        {
            return new RemoveValueBeforeFrom(source, position);
        }



        public static RemoveValueBeforeOccurrence Before(this RemoveValue source, int occurrence, string marker)
        {
            return new RemoveValueBeforeOccurrence(source, occurrence, marker);
        }

        public static RemoveValueBeforeOccurrenceFrom From(this RemoveValueBeforeOccurrence source, The position)
        {
            return new RemoveValueBeforeOccurrenceFrom(source, position);
        }

        #endregion

        #region After

        public static RemoveValueAfter After(this RemoveValue source, string marker)
        {
            return new RemoveValueAfter(source, marker);
        }

        public static RemoveValueAfterFrom From(this RemoveValueAfter source, The position)
        {
            return new RemoveValueAfterFrom(source, position);
        }



        public static RemoveValueAfterOccurrence After(this RemoveValue source, int occurrence, string marker)
        {
            return new RemoveValueAfterOccurrence(source, occurrence, marker);
        }

        public static RemoveValueAfterOccurrenceFrom From(this RemoveValueAfterOccurrence source, The position)
        {
            return new RemoveValueAfterOccurrenceFrom(source, position);
        }

        #endregion

        #region Remove Chars

        /// <summary>
        /// Removes number of chars from the source string.
        /// N.B.: Default RemoveChars() is equivalent of RemoveChars().From(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="quantity">Number of chars to remove</param>
        public static RemoveChars RemoveChars(this string source, int quantity)
        {
            return new RemoveChars(source, quantity);
        }

        /// <summary>
        /// Extends RemoveChars action with the ability to change starting point.
        /// N.B.: RemoveChars().From(The.Beginning) is equivalent of the default RemoveChars()
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveCharsFrom From(this RemoveChars source, The position)
        {
            return new RemoveCharsFrom(source, position);
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

        /// <summary>
        /// Extends RemoveChars action with the ability to ignore case
        /// </summary>
        public static RemoveSelectedCharsIgnoringCase IgnoringCase(this RemoveSelectedChars source)
        {
            return new RemoveSelectedCharsIgnoringCase(source);
        }

        #endregion

        #region Starting

        /// <summary>
        /// Removes substring starting character position in the source string.
        /// This action is inclusive.
        /// N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)
        /// </summary>
        /// <param name="position">Starting position in string for removal</param>
        public static RemoveStringStarting Starting(this RemoveString source, int position)
        {
            return new RemoveStringStarting(source, position);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingFrom From(this RemoveStringStarting source, The position)
        {
            return new RemoveStringStartingFrom(source, position);
        }



        /// <summary>
        /// Removes substring starting from the first marker in the source string.
        /// This action is inclusive.
        /// N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)
        /// </summary>
        /// <param name="marker">Marker value for removal point.</param>
        public static RemoveStringStartingFirstOccurrence Starting(this RemoveString source, string marker)
        {
            return new RemoveStringStartingFirstOccurrence(source, marker);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingFirstOccurrenceFrom From(this RemoveStringStartingFirstOccurrence source, The position)
        {
            return new RemoveStringStartingFirstOccurrenceFrom(source, position);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to ignore case.
        /// </summary>
        public static RemoveStringStartingFirstOccurrenceIgnoringCase IgnoringCase(this RemoveStringStartingFirstOccurrence source)
        {
            return new RemoveStringStartingFirstOccurrenceIgnoringCase(source);
        }

        /// <summary>
        /// Extends Remove.Starting.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingFirstOccurrenceIgnoringCaseFrom From(this RemoveStringStartingFirstOccurrenceIgnoringCase source, The position)
        {
            return new RemoveStringStartingFirstOccurrenceIgnoringCaseFrom(source, position);
        }



        /// <summary>
        /// Removes substring starting from the given occurrence of the marker in the source string.
        /// This action is inclusive.
        /// N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)
        /// </summary>
        /// <param name="occurrence">Occurrence count to start from.</param>
        /// <param name="of">Marker value for removal point.</param>
        public static RemoveStringStartingOccurrence Starting(this RemoveString source, int occurrence, string of)
        {
            return new RemoveStringStartingOccurrence(source, occurrence, of);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingOccurrenceFrom From(this RemoveStringStartingOccurrence source, The position)
        {
            return new RemoveStringStartingOccurrenceFrom(source, position);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to ignore case.
        /// </summary>
        public static RemoveStringStartingOccurrenceIgnoringCase IgnoringCase(this RemoveStringStartingOccurrence source)
        {
            return new RemoveStringStartingOccurrenceIgnoringCase(source);
        }

        /// <summary>
        /// Extends Remove.Starting.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingOccurrenceIgnoringCaseFrom From(this RemoveStringStartingOccurrenceIgnoringCase source, The position)
        {
            return new RemoveStringStartingOccurrenceIgnoringCaseFrom(source, position);
        }



        /// <summary>
        /// Removes substring starting from the first occurrence of the marker in the source string.
        /// <para>N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="marker">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used</exception>
        public static RemoveStringStartingFirstOccurrencePosition Starting(this RemoveString source, The position, string marker)
        {
            return new RemoveStringStartingFirstOccurrencePosition(source, position, marker);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingFirstOccurrencePositionFrom From(this RemoveStringStartingFirstOccurrencePosition source, The position)
        {
            return new RemoveStringStartingFirstOccurrencePositionFrom(source, position);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to ignore case.
        /// </summary>
        public static RemoveStringStartingFirstOccurrencePositionIgnoringCase IgnoringCase(this RemoveStringStartingFirstOccurrencePosition source)
        {
            return new RemoveStringStartingFirstOccurrencePositionIgnoringCase(source);
        }

        /// <summary>
        /// Extends Remove.Starting.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingFirstOccurrencePositionIgnoringCaseFrom From(this RemoveStringStartingFirstOccurrencePositionIgnoringCase source, The position)
        {
            return new RemoveStringStartingFirstOccurrencePositionIgnoringCaseFrom(source, position);
        }



        /// <summary>
        /// Removes substring starting from the given occurrence of the marker in the source string.
        /// <para>N.B.: Default Remove().Starting() is equivalent of Remove().Starting().From(The.Beginning)</para>
        /// </summary>
        /// <param name="position">Exact position for removal point.</param>
        /// <param name="occurrence">Occurrence count to start from.</param>
        /// <param name="of">Marker value for removal point.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when Beginning or End position value is used</exception>
        public static RemoveStringStartingOccurrencePosition Starting(this RemoveString source, The position, int occurrence, string of)
        {
            return new RemoveStringStartingOccurrencePosition(source, position, occurrence, of);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingOccurrencePositionFrom From(this RemoveStringStartingOccurrencePosition source, The position)
        {
            return new RemoveStringStartingOccurrencePositionFrom(source, position);
        }

        /// <summary>
        /// Extends Remove.Starting action with the ability to ignore case.
        /// </summary>
        public static RemoveStringStartingOccurrencePositionIgnoringCase IgnoringCase(this RemoveStringStartingOccurrencePosition source)
        {
            return new RemoveStringStartingOccurrencePositionIgnoringCase(source);
        }

        /// <summary>
        /// Extends Remove.Starting.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingOccurrencePositionIgnoringCaseFrom From(this RemoveStringStartingOccurrencePositionIgnoringCase source, The position)
        {
            return new RemoveStringStartingOccurrencePositionIgnoringCaseFrom(source, position);
        }

        #endregion

        #region To

        /// <summary>
        /// Removes substring up to character position in the source string.
        /// This action is exclusive.
        /// N.B.: Default Remove().To() is equivalent of Remove().To().From(The.Beginning)
        /// </summary>
        /// <param name="position">End position in string for removal</param>
        public static RemoveStringTo To(this RemoveString source, int position)
        {
            return new RemoveStringTo(source, position);
        }

        /// <summary>
        /// Extends Remove.To action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringToFrom From(this RemoveStringTo source, The position)
        {
            return new RemoveStringToFrom(source, position);
        }



        /// <summary>
        /// Extends Remove.Starting action with the ability to set end position for removal.
        /// This action is exclusive.
        /// N.B.: Default Remove().Starting().To() is equivalent of Remove().Starting().To().From(The.Beginning)
        /// </summary>
        /// <param name="position">End position in string for removal</param>
        public static RemoveStringStartingTo To(this RemoveStringStarting source, int position)
        {
            return new RemoveStringStartingTo(source, position);
        }

        /// <summary>
        /// Extends Remove.Starting.To action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingToFrom From(this RemoveStringStartingTo source, The position)
        {
            return new RemoveStringStartingToFrom(source, position);
        }


        /// <summary>
        /// Extends Remove.Starting.From action with the ability to set end position for removal.
        /// This action is exclusive.
        /// N.B.: Default Remove().Starting().From().To() is equivalent of Remove().Starting().From().To().From(The.Beginning)
        /// </summary>
        /// <param name="position">End position in string for removal</param>
        public static RemoveStringStartingFromTo To(this RemoveStringStartingFrom source, int position)
        {
            return new RemoveStringStartingFromTo(source, position);
        }

        /// <summary>
        /// Extends Remove.Starting.From.To action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringStartingFromToFrom From(this RemoveStringStartingFromTo source, The position)
        {
            return new RemoveStringStartingFromToFrom(source, position);
        }



        /// <summary>
        /// Removes substring up to the first marker in the source string.
        /// This action is exclusive.
        /// N.B.: Default Remove().To() is equivalent of Remove().To().From(The.Beginning)
        /// </summary>
        /// <param name="marker">Marker value for removal point.</param>
        public static RemoveStringToFirstOccurrence To(this RemoveString source, string marker)
        {
            return new RemoveStringToFirstOccurrence(source, marker);
        }

        /// <summary>
        /// Extends Remove.To action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringToFirstOccurrenceFrom From(this RemoveStringToFirstOccurrence source, The position)
        {
            return new RemoveStringToFirstOccurrenceFrom(source, position);
        }

        /// <summary>
        /// Extends Remove.To action with the ability to ignore case.
        /// </summary>
        public static RemoveStringToFirstOccurrenceIgnoringCase IgnoringCase(this RemoveStringToFirstOccurrence source)
        {
            return new RemoveStringToFirstOccurrenceIgnoringCase(source);
        }

        /// <summary>
        /// Extends Remove.To.IgnoringCase action with the ability to change starting point.
        /// </summary>
        /// <param name="position">
        /// Position in source string to start from. Beginning or End values could be used
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when StartOf or EndOf position value is used</exception>
        public static RemoveStringToFirstOccurrenceIgnoringCaseFrom From(this RemoveStringToFirstOccurrenceIgnoringCase source, The position)
        {
            return new RemoveStringToFirstOccurrenceIgnoringCaseFrom(source, position);
        }



        public static RemoveStringToOccurrence To(this RemoveString source, int occurrence, string marker)
        {
            return new RemoveStringToOccurrence(source, occurrence, marker);
        }

        public static RemoveStringToOccurrenceFrom From(this RemoveStringToOccurrence source, The position)
        {
            return new RemoveStringToOccurrenceFrom(source, position);
        }



        public static RemoveStringStartingOccurrenceTo To(this RemoveStringStartingOccurrence source, int positionIndex)
        {
            return new RemoveStringStartingOccurrenceTo(source, positionIndex);
        }

        public static RemoveStringStartingOccurrenceToFrom From(this RemoveStringStartingOccurrenceTo source, The position)
        {
            return new RemoveStringStartingOccurrenceToFrom(source, position);
        }



        public static RemoveStringStartingOccurrenceFromTo To(this RemoveStringStartingOccurrenceFrom source, int positionIndex)
        {
            return new RemoveStringStartingOccurrenceFromTo(source, positionIndex);
        }

        public static RemoveStringStartingOccurrenceFromToFrom From(this RemoveStringStartingOccurrenceFromTo source, The position)
        {
            return new RemoveStringStartingOccurrenceFromToFrom(source, position);
        }



        public static RemoveStringStartingToOccurrence To(this RemoveStringStarting source, int occurrence, string marker)
        {
            return new RemoveStringStartingToOccurrence(source, occurrence, marker);
        }

        public static RemoveStringStartingToOccurrenceFrom From(this RemoveStringStartingToOccurrence source, The position)
        {
            return new RemoveStringStartingToOccurrenceFrom(source, position);
        }



        public static RemoveStringStartingToOccurrencePosition To(this RemoveStringStarting source, The position, int occurrence, string marker)
        {
            return new RemoveStringStartingToOccurrencePosition(source, position, occurrence, marker);
        }

        public static RemoveStringStartingToOccurrencePositionFrom From(this RemoveStringStartingToOccurrencePosition source, The position)
        {
            return new RemoveStringStartingToOccurrencePositionFrom(source, position);
        }



        public static RemoveStringStartingOccurrenceToOccurrence To(this RemoveStringStartingOccurrence source, int occurrence, string marker)
        {
            return new RemoveStringStartingOccurrenceToOccurrence(source, occurrence, marker);
        }

        public static RemoveStringStartingOccurrenceToOccurrenceFrom From(this RemoveStringStartingOccurrenceToOccurrence source, The position)
        {
            return new RemoveStringStartingOccurrenceToOccurrenceFrom(source, position);
        }



        public static RemoveStringStartingOccurrenceToOccurrencePosition To(this RemoveStringStartingOccurrence source, The position, int occurrence, string marker)
        {
            return new RemoveStringStartingOccurrenceToOccurrencePosition(source, position, occurrence, marker);
        }

        public static RemoveStringStartingOccurrenceToOccurrencePositionFrom From(this RemoveStringStartingOccurrenceToOccurrencePosition source, The position)
        {
            return new RemoveStringStartingOccurrenceToOccurrencePositionFrom(source, position);
        }



        public static RemoveStringStartingOccurrenceFromToOccurrence To(this RemoveStringStartingOccurrenceFrom source, int occurrence, string marker)
        {
            return new RemoveStringStartingOccurrenceFromToOccurrence(source, occurrence, marker);
        }

        public static RemoveStringStartingOccurrenceFromToOccurrenceFrom From(this RemoveStringStartingOccurrenceFromToOccurrence source, The position)
        {
            return new RemoveStringStartingOccurrenceFromToOccurrenceFrom(source, position);
        }



        public static RemoveStringStartingOccurrenceFromToOccurrencePosition To(this RemoveStringStartingOccurrenceFrom source, The position, int occurrence, string marker)
        {
            return new RemoveStringStartingOccurrenceFromToOccurrencePosition(source, position, occurrence, marker);
        }

        public static RemoveStringStartingOccurrenceFromToOccurrencePositionFrom From(this RemoveStringStartingOccurrenceFromToOccurrencePosition source, The position)
        {
            return new RemoveStringStartingOccurrenceFromToOccurrencePositionFrom(source, position);
        }



        public static RemoveStringStartingFromToOccurrence To(this RemoveStringStartingFrom source, int occurrence, string marker)
        {
            return new RemoveStringStartingFromToOccurrence(source, occurrence, marker);
        }

        public static RemoveStringStartingFromToOccurrenceFrom From(this RemoveStringStartingFromToOccurrence source, The position)
        {
            return new RemoveStringStartingFromToOccurrenceFrom(source, position);
        }



        public static RemoveStringStartingFromToOccurrencePosition To(this RemoveStringStartingFrom source, The position, int occurrence, string marker)
        {
            return new RemoveStringStartingFromToOccurrencePosition(source, position, occurrence, marker);
        }

        public static RemoveStringStartingFromToOccurrencePositionFrom From(this RemoveStringStartingFromToOccurrencePosition source, The position)
        {
            return new RemoveStringStartingFromToOccurrencePositionFrom(source, position);
        }

        #endregion

        #region Next/Previous

        public static RemoveStringStartingNext Next(this RemoveStringStarting source, int chars)
        {
            return new RemoveStringStartingNext(source, chars);
        }

        public static RemoveStringStartingFromNext Next(this RemoveStringStartingFrom source, int chars)
        {
            return new RemoveStringStartingFromNext(source, chars);
        }



        public static RemoveStringStartingPrevious Previous(this RemoveStringStarting source, int chars)
        {
            return new RemoveStringStartingPrevious(source, chars);
        }

        public static RemoveStringStartingFromPrevious Previous(this RemoveStringStartingFrom source, int chars)
        {
            return new RemoveStringStartingFromPrevious(source, chars);
        }

        #endregion

        #region Remove Vowels

        /// <summary>
        /// Removes vowels from source string for a culture set on a CurrentThread.
        /// N.B.: Thread.CurrentThread.CurrentCulture property is used
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
