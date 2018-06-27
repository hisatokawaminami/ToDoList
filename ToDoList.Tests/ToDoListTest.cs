using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
  [TestClass]
  public class TranslateTest
  {
    [TestMethod]
    public void TranslateTo3_CharactorE()
    {
      Translate testLeetspeak = new Translate();
      Assert.AreEqual('3', testLeetspeak.TranslateToLeet('e'));
    }
    [TestMethod]
    public void TranslateTo0_CharactorO()
    {
      Translate testLeetspeak = new Translate();
      Assert.AreEqual('0', testLeetspeak.TranslateToLeet('o'));
    }
    [TestMethod]
    public void TranslateTo1_CharactorCapI()
    {
      Translate testLeetspeak = new Translate();
      Assert.AreEqual('1', testLeetspeak.TranslateToLeet('I'));
    }
    [TestMethod]
    public void TranslateTo7_CharactorT()
    {
      Translate testLeetspeak = new Translate();
      Assert.AreEqual('7', testLeetspeak.TranslateToLeet('T'));
    }
    [TestMethod]
    public void TranslateToZ_CharactorS()
    {
      Translate testLeetspeak = new Translate();
      Assert.AreEqual('z', testLeetspeak.TranslateToLeet('s'));
    }


  }
}
