using System.Collections;

public class WordCollection : IEnumerable, ICloneable
{
    private ArrayList words = new ArrayList();

    public void AddWords(string sentence)
    {
        string[] splitWords = sentence.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '—' },
                                             StringSplitOptions.RemoveEmptyEntries);
        words.AddRange(splitWords);
    }

    public IEnumerable GetVowelWords()
    {
        char[] vowels = new[] { 'А','Е','Є','И','І','Ї','О','У','Ю','Я',
                                'а','е','є','и','і','ї','о','у','ю','я' };

        foreach (string word in words)
        {
            if (word.Length > 0 && Array.Exists(vowels, v => v == word[0]))
                yield return word;
        }
    }

    public void Sort(IComparer comparer)
    {
        words.Sort(comparer);
    }

    public object Clone()
    {
        WordCollection clone = new WordCollection();
        foreach (string word in words)
        {
            clone.words.Add(word);
        }
        return clone;
    }

    public IEnumerator GetEnumerator()
    {
        return words.GetEnumerator();
    }
}
