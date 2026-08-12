using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// The attribute is designed to help distinguish user controls designed to edit style attributes among others.
/// </summary>
public sealed class FormSelectorPageAttribute : Attribute
{
    private string _handledTags;
    private readonly List<string> _separatedTags = [];

    /// <summary>
    /// Initializes a new instance of the <see cref="FormSelectorPageAttribute"/> class.
    /// </summary>
    /// <param name="initialPageName">Initial name of the page.</param>
    /// <param name="handledTags">The handled tags.</param>
    public FormSelectorPageAttribute(string initialPageName, string handledTags)
    {
        this.PageName = initialPageName;
        this.HandledTags = handledTags;
    }

    /// <summary>
    /// Name of the page to be displayed in tabs
    /// </summary>
    public string PageName { get; private set; }
        
    /// <summary>
    /// List of comma-separated tags that the attached user control handles
    /// </summary>
    public string HandledTags
    {
        get => _handledTags;

        private set
        { 
            _handledTags = value;

            // Update separated tags
            _separatedTags.Clear();
            foreach (string tag in _handledTags.Split(';', ','))
            {
                string tagTrimmed = tag.Trim();
                if (tagTrimmed.Length > 0)
                    _separatedTags.Add(tagTrimmed);
            }
        }
    }

    /// <summary>
    /// Checks whether a tag is handled by the attached user control
    /// </summary>
    /// <param name="specificTag">tag to check</param>
    /// <returns>true is the attached user control handles the tag specified</returns>
    public bool HandlesTag(string specificTag)
    {
        return _separatedTags.Any(tag => string.Equals(tag, specificTag, StringComparison.InvariantCultureIgnoreCase));

        // defaulting to false
    }
}