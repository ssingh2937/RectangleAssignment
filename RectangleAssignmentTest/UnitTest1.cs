using NUnit.Framework;
using RectangleAssignment;  

namespace RectangleAssignmentTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void checkLength()
        {
            Rectangle rec = new Rectangle(20, 20);
            int output = rec.GetLength();
            Assert.AreEqual(20, output);
        }

        [Test]
        public void checkSetLength()
        {
            Rectangle rec = new Rectangle();
            int output = rec.setLength(5);
            Assert.AreEqual(5, output);
        }

        [Test]
        public void checkWidth()
        {
            Rectangle rec = new Rectangle(10,10);
            int output = rec.GetWidth();
            Assert.AreEqual(10, output);
        }

        [Test]
        public void checkSetWidth()
        {
            Rectangle rec = new Rectangle();
            int output = rec.setLength(2);
            Assert.AreEqual(2, output);
        }

        [Test]
        public void checkPerimeter()
        {
            Rectangle rec = new Rectangle(2,2);
            int output = rec.GetPerimeter();
            Assert.AreEqual(8, output);
        }

        [Test]
        public void checkArea()
        {
            Rectangle rec = new Rectangle(2,2);
            int output = rec.GetArea();
            Assert.AreEqual(4, output);
        }

    }
}