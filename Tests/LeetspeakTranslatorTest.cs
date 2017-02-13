using Xunit;
namespace Leetspeak.Objects
{
  public class LeetspeakTranslatorTest
  {
    [Fact]
    public void LeetspeakTranslator_ForNumber_number()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("65");
      Assert.Equal("65", testLeetspeakTranslator.Translate("65"));
    }

    [Fact]
    public void LeetspeakTranslator_ForLowercaseE_3()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("bee");
      Assert.Equal("b33", testLeetspeakTranslator.Translate("bee"));
    }

    [Fact]
    public void LeetspeakTranslator_ForUppercaseE_3()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("BEE");
      Assert.Equal("B33", testLeetspeakTranslator.Translate("BEE"));
    }

    [Fact]
    public void LeetspeakTranslator_ForLowercaseO_0()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("boo");
      Assert.Equal("b00", testLeetspeakTranslator.Translate("boo"));
    }

    [Fact]
    public void LeetspeakTranslator_ForUppercaseO_0()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("BOO");
      Assert.Equal("B00", testLeetspeakTranslator.Translate("BOO"));
    }

    [Fact]
    public void LeetspeakTranslator_ForUppercaseI_1()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("Input");
      Assert.Equal("1nput", testLeetspeakTranslator.Translate("Input"));
    }

    [Fact]
    public void LeetspeakTranslator_ForLowercasei_i()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("input");
      Assert.Equal("input", testLeetspeakTranslator.Translate("input"));
    }

    [Fact]
    public void LeetspeakTranslator_ForSNotFirstLetterOfWord_z()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("csharp");
      Assert.Equal("czharp", testLeetspeakTranslator.Translate("csharp"));
    }

    [Fact]
    public void LeetspeakTranslator_ForSFirstLetterOfWord_s()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("sharp");
      Assert.Equal("sharp", testLeetspeakTranslator.Translate("sharp"));
    }

    [Fact]
    public void LeetspeakTranslator_ForSentence_translatedsentence()
    {
      LeetspeakTranslator testLeetspeakTranslator= new LeetspeakTranslator("Don't you love these 'String' exercises? I do!");
      Assert.Equal("D0n't y0u l0v3 th3z3 'String' 3x3rciz3z? 1 d0!", testLeetspeakTranslator.Translate("Don't you love these 'String' exercises? I do!"));
    }
  }
}
