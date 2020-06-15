using exo_tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exo_test.test
{
  [TestClass]
  public class ClassTest
  {
    [TestMethod]
    public void ValidParameters()
    {
      string initiales = ClasseChaine.RetourneInitiales("JEANNE", "Alexis");
      Assert.AreEqual("JA", initiales);
    }

    [TestMethod]
    public void BadLastnameAndFirstname()
    {
      string initiales = ClasseChaine.RetourneInitiales(null, null);
      Assert.AreEqual("", initiales);
    }

    [TestMethod]
    public void BadFirstname()
    {
      string initiales = ClasseChaine.RetourneInitiales("JEANNE", null);
      Assert.AreEqual("", initiales);
    }

    [TestMethod]
    public void ComposedName()
    {
      string initiales = ClasseChaine.RetourneInitiales("Nom-Composé", "Prénom-Composé");
      Assert.AreEqual("NCPC", initiales);
    }
  }
}
