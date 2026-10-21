using FirstOOP;

namespace KuhTestProjekt
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KuhConstructor_IsCalled_SetsValuesCorrect()
        {
            Kuh myKuh = new Kuh("Paula", "schwarz");
            Assert.That(myKuh.Name, Is.EqualTo("Paula"));
        }

        [Test]
        public void KuhConstructor_NameOfCowNull_ThrowsInvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() => new Kuh("", "schwarz"));
        }
    }
}
