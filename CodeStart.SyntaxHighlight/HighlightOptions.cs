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
        /// <summary> Default style </summary>
        Default = 0,
        /// <summary> Bold style </summary>
        Bold = 1 << 0,
        /// <summary> Italic style </summary>
        Italic = 1 << 1,
        /// <summary> Underlined style </summary>
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
