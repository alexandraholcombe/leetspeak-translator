using Xunit;
namespace Leetspeak
{
  public class LeetspeakTranslatorTest
  {
    [Fact]
    public void LeetspeakTranslator_ForNumber_number()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.Equal("65", testLeetspeakTranslator.Translate("65"));
    }

    [Fact]
    public void LeetspeakTranslator_ForLowercaseE_3()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.Equal("b33", testLeetspeakTranslator.Translate("bee"));
    }
  }
}
