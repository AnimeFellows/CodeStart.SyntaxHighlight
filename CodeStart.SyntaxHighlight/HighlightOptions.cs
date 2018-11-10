using System;
using System.Windows.Media;

namespace CodeStart.SyntaxHighlight
{
    /// <summary>
    /// Highlight style enum
    /// </summary>
    [Flags]
    public enum HighlightStyle
    {
        Default = 0,
        Bold = 1 << 0,
        Italics = 1 << 1,
        Underlined = 1 << 2
    }

    /// <summary>
    /// Highlight options
    /// </summary>
    public struct HighlightOptions
    {
        /// <summary> Foreground color </summary>
        public Color ForegroundColor { get; set; }

        /// <summary> Background color </summary>
        public Color BackgroundColor { get; set; }

        /// <summary> Style </summary>
        public HighlightStyle Style { get; set; }
    }
}
