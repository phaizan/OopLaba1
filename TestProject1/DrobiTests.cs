namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase (1, 4, 2, 5, 13, 20)]
        [TestCase (1, 2, 2, 3, 7, 6)]
        public void plus(int a1, int a2, int b1, int b2, int x1, int x2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            drobi itog = a + b;
            
            Assert.That(itog.Numerator == x1, Is.True);
            Assert.That(itog.Denominator == x2, Is.True);
        }
        [Test]
        [TestCase(2, 4, 2, 5, 1, 10)] 
        [TestCase(1, 2, 2, 3, -1, 6)] 

        public void minus(int a1, int a2, int b1, int b2, int x1, int x2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            drobi itog = a - b;
            Assert.That(itog.Numerator == x1, Is.True);
            Assert.That(itog.Denominator == x2, Is.True);
        }
        [Test]
        [TestCase(2, 4, 2, 5, 1, 5)]
        [TestCase(1, 2, 2, 3, 1, 3)]
        public void umnozhit(int a1, int a2, int b1, int b2, int x1, int x2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            drobi itog = a * b;
            Assert.That(itog.Numerator == x1, Is.True);
            Assert.That(itog.Denominator == x2, Is.True);
        }
        [Test]
        [TestCase(2, 4, 2, 5, 5, 4)]
        [TestCase(1, 2, 2, 3, 3, 4)]
        public void delenie(int a1, int a2, int b1, int b2, int x1, int x2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            drobi itog = a / b;
            Assert.That(itog.Numerator == x1, Is.True);
            Assert.That(itog.Denominator == x2, Is.True);
        }
        [Test]
        [TestCase(2, 4, 4, 8)] 
        [TestCase(1, 3, 3, 9)] 

        public void ravno(int a1, int a2, int b1, int b2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            Assert.That(a == b, Is.True);
        }
        [Test]
        [TestCase(2, 5, 4, 8)]
        [TestCase(2, 2, 4, 8)]
        public void neravno(int a1, int a2, int b1, int b2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            Assert.That(a != b, Is.True);
        }
        [Test]
        [TestCase(4, 5, 2, 3)]
        [TestCase(2, 1, 4, 8)]
        public void bolshe(int a1, int a2, int b1, int b2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            Assert.That(a > b, Is.True);
        }
        [Test]
        [TestCase(2, 3, 4, 6)]
        [TestCase(19, 26, 17, 28)]
        public void bolsherav(int a1, int a2, int b1, int b2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            Assert.That(a >= b, Is.True);
        }
        [Test]
        [TestCase(2, 4, 4, 3)]
        [TestCase(1, 3, 1, 2)]
        public void menshe(int a1, int a2, int b1, int b2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            Assert.That(a < b, Is.True);
        }
        [Test]
        [TestCase(5, 7, 10, 11)]
        [TestCase(15, 16, 17, 18)]
        public void mensherav(int a1, int a2, int b1, int b2)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            Assert.That(a <= b, Is.True);
        }
        [Test]
        [TestCase(2, 4, -1, 2)]
        [TestCase(3, 9, -1, 3)]
        public void singminus(int a1, int a2, int b1, int b2)
        {
            drobi a = new drobi(a1, a2);
            drobi itog = new drobi(b1, b2);
            Assert.That(-a == itog, Is.True);
        }
    }
}