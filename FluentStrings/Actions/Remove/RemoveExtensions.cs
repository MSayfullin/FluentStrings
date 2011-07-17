using dokas.FluentStrings.Actions.Remove;

namespace dokas.FluentStrings
{
    public static class RemoveExtensions
    {
        /// <summary>
        /// Removes all value occurrences from the source string
        /// </summary>
        /// <param name="source">String in which to remove</param>
        /// <param name="whatToRemove">String to remove</param>
        public static RemoveText Remove(this string source, string whatToRemove)
        {
            return new RemoveText(source, whatToRemove);
        }
    }
}
