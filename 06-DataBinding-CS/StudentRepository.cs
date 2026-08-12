using System.Xml.Serialization;

namespace DataBinding;

/// <summary>
/// Loads and saves the sample student list from a small XML file next to the executable, so
/// the binding navigator's "Save data" button demonstrates writing bound edits back to a real
/// data store instead of just holding them in memory.
/// </summary>
internal static class StudentRepository
{
    private static readonly string FilePath = Path.Combine(Application.StartupPath, "sample-students.xml");

    public static List<Student> Load()
    {
        if (File.Exists(FilePath))
        {
            try
            {
                XmlSerializer serializer = new(typeof(List<Student>));
                using Stream stream = File.OpenRead(FilePath);
                if (serializer.Deserialize(stream) is List<Student> students)
                    return students;
            }
            catch
            {
                // Fall through to the built-in sample data below if the file is missing, locked,
                // or was hand-edited into something the serializer can no longer read.
            }
        }

        return new List<Student>
        {
            new()
            {
                Name = "Mike James",
                RollNumber = 12,
                History = "<p>He <u>is</u> a <font color=\"#ff0000\">very</font> good boy, but not <strong>great</strong> at sports.</p>"
            },
            new()
            {
                Name = "Maria Shelly",
                RollNumber = 34,
                History = "<p>What else can be <font color=\"#ff0000\">told</font> about her - she is <strong>awesome</strong>.</p>"
            },
            new()
            {
                Name = "Sylvia Jackson",
                RollNumber = 23,
                History = "<p>Sylvia loves <font color=\"#ff0000\">ice cream</font>, but <strong>not milk</strong>.</p>"
            }
        };
    }

    public static void Save(List<Student> students)
    {
        XmlSerializer serializer = new(typeof(List<Student>));
        using Stream stream = File.Create(FilePath);
        serializer.Serialize(stream, students);
    }
}
