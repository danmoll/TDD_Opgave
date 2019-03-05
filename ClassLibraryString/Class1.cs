using System;
using System.Linq;

namespace ClassLibraryString
{
    public class StringUtilities
    {
        public int CountOccurences(string StringToCheck, string StringToFind)
        {
            int countresult = -1;
            if (StringToCheck != null)
            {
                countresult = StringToCheck.Count(x => Char.ToUpperInvariant(StringToFind[0]) == Char.ToUpperInvariant(x));
            }
            return countresult;
        }
    }
}