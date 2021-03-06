using System.Collections.Generic;
using System;
using Nancy;

namespace Leetspeak.Objects
{
  public class LeetspeakTranslator
  {
    private string _text;

    public LeetspeakTranslator (string text)
    {
      _text = text;
    }

    public string GetText()
    {
      return _text;
    }
    public void SetText(string inputText)
    {
      _text = inputText;
    }

    public string Translate(string text = null)
    {
      if (text == null){
        text = _text;
      }
      char[] array = text.ToCharArray();

      List<char> newText = new List<char> {};
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i].Equals('e') || array[i].Equals('E'))
        {
          newText.Add(Convert.ToChar('3'));
        }
        else if (array[i].Equals('o') || array[i].Equals('O'))
        {
          newText.Add(Convert.ToChar('0'));
        }
        else if (array[i].Equals('I'))
        {
          newText.Add(Convert.ToChar('1'));
        }
        else if (array[i].Equals('s') && !(i == 0 || char.IsWhiteSpace(array[i-1])))
        {
          newText.Add(Convert.ToChar('z'));
        }
        else
        {
         newText.Add(array[i]);
        }
      }

      string result = string.Join("", newText.ToArray());
      return result;
    }
  }
}
