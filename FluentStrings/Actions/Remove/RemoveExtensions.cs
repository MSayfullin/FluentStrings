using dokas.FluentStrings.Actions.Remove;

namespace dokas.FluentStrings
{
    public static class RemoveExtensions
    {
        #region Remove

        public static RemoveString Remove(this string source)
        {
            return new RemoveString(source);
        }

        /// <summary>
        /// Removes all value occurrences from the source string
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="whatToRemove">String to be removed</param>
        public static RemoveText Remove(this string source, string whatToRemove)
        {
            return new RemoveText(source, whatToRemove);
        }

        public static RemoveTextFrom From(this RemoveText source, The position)
        {
            return new RemoveTextFrom(source, position);
        }

        #endregion

        #region Before

        public static RemoveTextBefore Before(this RemoveText source, string marker)
        {
            return new RemoveTextBefore(source, marker);
        }

        public static RemoveTextBeforeFrom From(this RemoveTextBefore source, The position)
        {
            return new RemoveTextBeforeFrom(source, position);
        }



        public static RemoveTextBeforeOccurrence Before(this RemoveText source, int occurrence, string marker)
        {
            return new RemoveTextBeforeOccurrence(source, occurrence, marker);
        }

        public static RemoveTextBeforeOccurrenceFrom From(this RemoveTextBeforeOccurrence source, The position)
        {
            return new RemoveTextBeforeOccurrenceFrom(source, position);
        }

        #endregion

        #region After

        public static RemoveTextAfter After(this RemoveText source, string marker)
        {
            return new RemoveTextAfter(source, marker);
        }

        public static RemoveTextAfterFrom From(this RemoveTextAfter source, The position)
        {
            return new RemoveTextAfterFrom(source, position);
        }



        public static RemoveTextAfterOccurrence After(this RemoveText source, int occurrence, string marker)
        {
            return new RemoveTextAfterOccurrence(source, occurrence, marker);
        }

        public static RemoveTextAfterOccurrenceFrom From(this RemoveTextAfterOccurrence source, The position)
        {
            return new RemoveTextAfterOccurrenceFrom(source, position);
        }

        #endregion

        #region Remove Chars

        /// <summary>
        /// Removes chars from the source string
        /// N.B.: Default RemoveChars() is equivalent of RemoveChars().From(The.Beginning)
        /// </summary>
        /// <param name="source">Target string for removal</param>
        /// <param name="quantity">Number of chars to remove</param>
        public static RemoveChars RemoveChars(this string source, int quantity)
        {
            return new RemoveChars(source, quantity);
        }

        /// <summary>
        /// Removes chars from the source string either from Beginning or End
        /// N.B.: RemoveChars().From(The.Beginning) is equivalent of the simple RemoveChars() call
        /// </summary>
        /// <param name="position">Position in string for removal</param>
        public static RemoveCharsFrom From(this RemoveChars source, The position)
        {
            return new RemoveCharsFrom(source, position);
        }



        public static RemoveSelectedChars RemoveChars(this string source, params char[] chars)
        {
            return new RemoveSelectedChars(source, chars);
        }

        #endregion

        #region Starting

        public static RemoveStringStarting Starting(this RemoveString source, int positionIndex)
        {
            return new RemoveStringStarting(source, positionIndex);
        }

        public static RemoveStringStartingFrom From(this RemoveStringStarting source, The position)
        {
            return new RemoveStringStartingFrom(source, position);
        }



        public static RemoveStringStartingOccurrence Starting(this RemoveString source, int occurrence, string marker)
        {
            return new RemoveStringStartingOccurrence(source, occurrence, marker);
        }

        public static RemoveStringStartingOccurrenceFrom From(this RemoveStringStartingOccurrence source, The position)
        {
            return new RemoveStringStartingOccurrenceFrom(source, position);
        }

        #endregion

        #region To

        public static RemoveStringTo To(this RemoveString source, int positionIndex)
        {
            return new RemoveStringTo(source, positionIndex);
        }

        public static RemoveStringToFrom From(this RemoveStringTo source, The position)
        {
            return new RemoveStringToFrom(source, position);
        }



        public static RemoveStringStartingTo To(this RemoveStringStarting source, int positionIndex)
        {
            return new RemoveStringStartingTo(source, positionIndex);
        }

        public static RemoveStringStartingToFrom From(this RemoveStringStartingTo source, The position)
        {
            return new RemoveStringStartingToFrom(source, position);
        }


        public static RemoveStringStartingFromTo To(this RemoveStringStartingFrom source, int positionIndex)
        {
            return new RemoveStringStartingFromTo(source, positionIndex);
        }

        public static RemoveStringStartingFromToFrom From(this RemoveStringStartingFromTo source, The position)
        {
            return new RemoveStringStartingFromToFrom(source, position);
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



        public static RemoveStringToOccurrence To(this RemoveString source, int occurrence, string marker)
        {
            return new RemoveStringToOccurrence(source, occurrence, marker);
        }

        public static RemoveStringToOccurrenceFrom From(this RemoveStringToOccurrence source, The position)
        {
            return new RemoveStringToOccurrenceFrom(source, position);
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

        public static string RemoveVowels(this string source)
        {
            return new RemoveVowels(source);
        }
    }
}
