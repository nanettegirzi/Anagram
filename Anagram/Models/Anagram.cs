using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Anagrammer
{
  public class Anagram
  {

    public List<bool> CheckAnagram (string target, List<string> word)
      {
        List<bool> output = new List<bool>();
        char[] target2 = target.ToCharArray();
        Array.Sort<char>(target2);
        for (int i = 0; i < word.Count; i++)
        {
          char[] wordtemp = word[i].ToCharArray();
          Array.Sort<char>(wordtemp);
          output.Add(target2.SequenceEqual(wordtemp));
        }
        return output;
      }
  }

}
