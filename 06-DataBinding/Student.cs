namespace DataBinding;

/// <summary>
/// A simple business object standing in for a row you would normally pull from a database or
/// business layer. History holds HTML markup - that field is what gets bound to the editor.
/// </summary>
[Serializable]
public class Student
{
    public string Name { get; set; } = "";
    public int RollNumber { get; set; }
    public string History { get; set; } = "";
}
