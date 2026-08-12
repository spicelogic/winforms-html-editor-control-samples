using SpiceLogic.HtmlEditor.Abstractions.Entities.SpellCheck;

namespace CustomSpellChecker;

/// <summary>
/// A minimal <see cref="ISpellCheckerEngine"/> implementation. A real-world engine would
/// wrap a dictionary library or a cloud spell-check API (useful for a specialized
/// vocabulary such as medical, legal, or multilingual terms); this demo engine uses a
/// simple rule instead so the behavior is obvious at a glance: every word starting with
/// the letter "a" is treated as misspelled, and any word added through
/// <see cref="AddToUserDictionary"/> is remembered as correct for the rest of the session.
/// </summary>
public class CustomSpellCheckerEngine : ISpellCheckerEngine
{
    private readonly HashSet<string> _userDictionary = [];
    private string? _fixedUserDictionaryPath;

    public void Initialize(string dictionaryPath, string affixPath, string userDictionaryPath)
    {
        InitializeUserDictionary(userDictionaryPath);
    }

    public bool Spell(string word)
    {
        if (string.IsNullOrEmpty(word))
            return true;

        if (!word.StartsWith("a"))
            return true;

        return _userDictionary.Contains(word);
    }

    public IEnumerable<string> Suggest(string word, int? max = null)
    {
        if (!string.IsNullOrEmpty(word) && word.StartsWith("a"))
            return ["Aesthetics", "Apple"];

        return [];
    }

    public void AddToUserDictionary(string word)
    {
        if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(_fixedUserDictionaryPath))
            return;

        try
        {
            if (!File.Exists(_fixedUserDictionaryPath))
            {
                string directoryName = Path.GetDirectoryName(_fixedUserDictionaryPath) ?? string.Empty;
                if (!Directory.Exists(directoryName))
                {
                    MessageBox.Show("The user dictionary folder does not exist.");
                    return;
                }

                using (File.Create(_fixedUserDictionaryPath))
                {
                }
            }

            string[] existingWords = File.ReadAllLines(_fixedUserDictionaryPath);
            if (Array.Exists(existingWords, w => w == word))
                return;

            using (StreamWriter writer = File.AppendText(_fixedUserDictionaryPath))
                writer.WriteLine(word);

            _userDictionary.Add(word);
        }
        catch (UnauthorizedAccessException)
        {
            MessageBox.Show($"The user dictionary at '{_fixedUserDictionaryPath}' could not be created or updated because of a permission restriction.");
        }
        catch (IOException)
        {
            MessageBox.Show($"An unexpected error occurred while creating or updating the user dictionary at '{_fixedUserDictionaryPath}'.");
        }
    }

    public void Dispose()
    {
        // Nothing to release for this in-memory demo engine.
    }

    private void InitializeUserDictionary(string userDictionaryPath)
    {
        _fixedUserDictionaryPath = FixDictionaryPath(userDictionaryPath);

        if (string.IsNullOrEmpty(_fixedUserDictionaryPath) || !File.Exists(_fixedUserDictionaryPath))
            return;

        foreach (string line in File.ReadAllLines(_fixedUserDictionaryPath))
        {
            _userDictionary.Add(line);
        }
    }

    private static string FixDictionaryPath(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
            return filePath;

        if (!Path.IsPathRooted(filePath))
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);

        if (!string.Equals(Path.GetExtension(filePath), ".dic", StringComparison.OrdinalIgnoreCase))
            filePath = filePath.Trim() + ".dic";

        return filePath;
    }
}
