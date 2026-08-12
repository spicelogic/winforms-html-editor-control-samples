 
namespace CustomDialog.Dialogs.StyleBuilder;

/// <summary>
/// Interface for the user control that edits specific set of attributes
/// </summary>
public interface IEditorStylePage
{
    /// <summary>
    /// Forces flushing content from the user control into the dictionary of styles that was provided
    /// </summary>
    void FlushContent();
}