# 08 - Custom spell checker

Plugs a custom spell-checking engine into the editor by implementing `ISpellCheckerEngine`
(see `CustomSpellCheckerEngine.cs`) and assigning it to
`SpellCheckOptions.CustomSpellCheckerEngine`. This is the pattern to use when the built-in
English dictionary is not enough - for example a medical, legal, or multilingual
vocabulary, or a cloud spell-check API. A radio button toggles between the built-in
OpenOffice-based engine and the demo engine, which flags every word starting with the
letter "a" as misspelled so the difference is obvious.

Key API members used: `SpellCheckOptions`, `ISpellCheckerEngine`, `SpellChecker`,
`CustomSpellCheckerEngine`, `CurlyUnderlineImageFilePath`, `FireInlineSpellCheckingOnKeyStroke`.

A VB.NET version of this sample sits alongside in `08-CustomSpellChecker-VB`.

## Run it

```
dotnet run --project 08-CustomSpellChecker-CS
```
