using System.Text.RegularExpressions;

namespace PasteFromWord;

/// <summary>
/// Small, documented regex helpers for stripping the noise that Microsoft Word and
/// Outlook add to clipboard HTML: inline class/style attributes, and Word's own XML
/// namespaced markup (the "o:" and "w:" prefixed elements Word uses for its own
/// metadata, such as &lt;o:p&gt;&lt;/o:p&gt; empty paragraph markers).
///
/// This is a simple, readable example for a sample project. It is not a full HTML
/// sanitizer; for production use consider a proper HTML parser instead of regex.
/// </summary>
internal static class WordHtmlCleaner
{
    // Matches class="..." or class='...' so the attribute (and its value) can be removed.
    private static readonly Regex ClassAttributeRegex =
        new("""class\s*=\s*"[^"]*"|class\s*=\s*'[^']*'""", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    // Matches style="..." or style='...' so the attribute (and its value) can be removed.
    private static readonly Regex StyleAttributeRegex =
        new("""style\s*=\s*"[^"]*"|style\s*=\s*'[^']*'""", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    // Matches Word's <o:p> / </o:p> paragraph markers, including any attributes and the
    // self-closing form <o:p/>.
    private static readonly Regex OfficeParagraphRegex =
        new("""</?o:p\b[^>]*>""", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    // Matches any other Word namespaced element, e.g. <w:WordDocument>, </w:LsdException>,
    // including the self-closing form.
    private static readonly Regex WordNamespacedElementRegex =
        new("""</?w:[a-zA-Z0-9]+\b[^>]*>""", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    public static string Clean(string html)
    {
        string cleaned = html;

        cleaned = ClassAttributeRegex.Replace(cleaned, string.Empty);
        cleaned = StyleAttributeRegex.Replace(cleaned, string.Empty);
        cleaned = OfficeParagraphRegex.Replace(cleaned, string.Empty);
        cleaned = WordNamespacedElementRegex.Replace(cleaned, string.Empty);

        return cleaned;
    }
}
