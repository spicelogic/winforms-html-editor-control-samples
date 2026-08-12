Imports System.Text.RegularExpressions

''' <summary>
''' Small, documented regex helpers for stripping the noise that Microsoft Word and
''' Outlook add to clipboard HTML: inline class/style attributes, and Word's own XML
''' namespaced markup (the "o:" and "w:" prefixed elements Word uses for its own
''' metadata, such as &lt;o:p&gt;&lt;/o:p&gt; empty paragraph markers).
'''
''' This is a simple, readable example for a sample project. It is not a full HTML
''' sanitizer; for production use consider a proper HTML parser instead of regex.
''' </summary>
Friend Module WordHtmlCleaner

    ' Matches class="..." or class='...' so the attribute (and its value) can be removed.
    Private ReadOnly ClassAttributeRegex As New Regex("class\s*=\s*""[^""]*""|class\s*=\s*'[^']*'", RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    ' Matches style="..." or style='...' so the attribute (and its value) can be removed.
    Private ReadOnly StyleAttributeRegex As New Regex("style\s*=\s*""[^""]*""|style\s*=\s*'[^']*'", RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    ' Matches Word's <o:p> / </o:p> paragraph markers, including any attributes and the
    ' self-closing form <o:p/>.
    Private ReadOnly OfficeParagraphRegex As New Regex("</?o:p\b[^>]*>", RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    ' Matches any other Word namespaced element, e.g. <w:WordDocument>, </w:LsdException>,
    ' including the self-closing form.
    Private ReadOnly WordNamespacedElementRegex As New Regex("</?w:[a-zA-Z0-9]+\b[^>]*>", RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    Public Function Clean(html As String) As String
        Dim cleaned As String = html

        cleaned = ClassAttributeRegex.Replace(cleaned, String.Empty)
        cleaned = StyleAttributeRegex.Replace(cleaned, String.Empty)
        cleaned = OfficeParagraphRegex.Replace(cleaned, String.Empty)
        cleaned = WordNamespacedElementRegex.Replace(cleaned, String.Empty)

        Return cleaned
    End Function

End Module
