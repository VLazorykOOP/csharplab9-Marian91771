using System.Collections;

public class WordLengthComparer : IComparer
{
    public int Compare(object x, object y)
    {
        if (x is string sx && y is string sy)
            return sx.Length.CompareTo(sy.Length);
        return 0;
    }
}
