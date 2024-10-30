namespace addressbook_web_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethodSquare()
        {
            Assert.Pass();
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            Assert.AreEqual(s1.Size, 5); //size - свойство
            Assert.AreEqual(s2.Size, 10);
            Assert.AreEqual(s3.Size, 5);

            s3.Size=15; //присвоение свойства

            Assert.AreEqual(s1.Size, 15);

            s2.Colored = true;
        }
        [Test]
        public void TestMethodCircle()
        {
            Assert.Pass();
            Circle s1 = new Circle(5);
            Circle s2 = new Circle(10);
            Circle s3 = s1;

            Assert.AreEqual(s1.Radius, 5); //size - свойство
            Assert.AreEqual(s2.Radius, 10);
            Assert.AreEqual(s3.Radius, 5);

            s3.Radius = 15; //присвоение свойства

            Assert.AreEqual(s1.Radius, 15);

            s2.Colored = true;
        }
    }
}