using System.Collections.Generic;

namespace CodeStart.SyntaxHighlight
{
    /// <summary> Syntax highlighter interface </summary>
    public interface ISyntaxHighlighter
    {
        /// <summary>
        /// Highlight specified text
        /// </summary>
        /// <param name="text">Text to highlight</param>
        /// <returns>
        /// Dictionary with highlight options.
        /// Key is position of the character.
        /// Value is <see cref="HighlightOptions"/> for the character.
        /// </returns>
        IDictionary<int, HighlightOptions> Highlight(string text);
    }
}
