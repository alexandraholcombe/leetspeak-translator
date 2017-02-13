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

    [Fact]
    public void LeetspeakTranslator_ForUppercaseE_3()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.Equal("B33", testLeetspeakTranslator.Translate("BEE"));
    }

    [Fact]
    public void LeetspeakTranslator_ForLowercaseO_0()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.Equal("b00", testLeetspeakTranslator.Translate("boo"));
    }

    [Fact]
    public void LeetspeakTranslator_ForUppercaseO_0()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.Equal("B00", testLeetspeakTranslator.Translate("BOO"));
    }

    [Fact]
    public void LeetspeakTranslator_ForUppercaseI_1()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.Equal("1nput", testLeetspeakTranslator.Translate("Input"));
    }

    [Fact]
    public void LeetspeakTranslator_ForLowercasei_i()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.Equal("input", testLeetspeakTranslator.Translate("input"));
    }
  }
}
