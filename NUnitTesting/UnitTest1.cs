using CtsCollectionsDemo;
using Moq;

namespace TestProject1
{
    public class Tests
    {
        private MathCla mth;
        [SetUp]
        public void Setup()
        {
            mth = new MathCla();
        }

        [Test]
        public void TestAdd()
        {
            //Arrange
            //MathCla mth = new MathCla();
            //Act
           int res = mth.Add(20, 30);
            //Assert
            Assert.AreEqual(50, res);
        }
        [Test]
        [TestCase(50,20,30)]
        [TestCase(100,20,80)]
        public void TestSub(int a,int b,int expected)
        {
           // MathCla mth = new MathCla();
            int re = mth.Sub(a,b);
            Assert.AreEqual(expected, re);
        }
        [Test]
        public void TestEmployee()
        {
            Employee empl = new Employee("Mano", 28);
            string name = empl.name;
            int age = empl.age;
            Assert.AreEqual(age, empl.age);
            Assert.AreEqual("Reena", empl.name);
        }

        [Test]
        [Ignore("NotImplemented")]
        public void TestProd()
        {
        }

        [Test]
       
        public void TestMoq()
        {
            Mock<MathCla> m = new Mock<MathCla>();
            m.Setup(x=>x.CheckValue()).Returns(true);
            Assert.AreEqual(true, m.Object.CheckValue());

        }
    }
}