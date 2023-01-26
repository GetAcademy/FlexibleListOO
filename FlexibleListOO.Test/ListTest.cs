namespace FlexibleListOO.Test
{
    /*
     * Perspektiver:
     *  - sjekke at ting er riktig - feks regne ut noe riktig
     *  - test coverage
     *  - testdrevet utvikling
     *
     *  - testbar kode er god kode!
     */
    public class ListTest
    {
        [Test]
        public void TestAdd()
        {
            // Arrange
            var list = new List<int>();

            // Act
            list.Add(1);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("1", list.AsString());
        }


        [Test]
        public void TestElements()
        {
            // Arrange
            var list = new List<int>();

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            var elements = list.Elements;

            // Assert
            Assert.That(elements, Is.EquivalentTo(new[] { 1, 2, 3, 4, 5 }));
        }
    }
}