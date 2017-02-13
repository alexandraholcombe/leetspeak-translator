using System.Collections.Generic;
using System;

namespace Leetspeak
{
  public class LeetspeakTranslator
  {
    public string Translate(string text)
    {
      char[] array = text.ToCharArray();

      List<char> newText = new List<char> {};
      foreach(var index in array)
      {
        if (index.Equals('e') || index.Equals('E'))
        {
          newText.Add(Convert.ToChar('3'));
        }
        else if (index.Equals('o') || index.Equals('O'))
        {
          newText.Add(Convert.ToChar('0'));
        }
        else
        {
          newText.Add(index);
        }
      }


      string result = string.Join("", newText.ToArray());
      return result;
    }
  }
}
