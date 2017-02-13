namespace Leetspeak
{
  public class LeetspeakTranslator
  {
    public string Translate(string text)
    {
      char[] array = text.ToCharArray();
      string result = string.Join("", array);
      return result;
    }
  }
}
