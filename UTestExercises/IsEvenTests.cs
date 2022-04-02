using Exercises;
using NUnit.Framework;

namespace UTestExercises_IsEven
{
    public class Tests
    {
        [Test]
        public void AreEven()
        {
            IsEven SolutionClass = new IsEven();
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(2));
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(1));
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(0));
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(7));
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(-1));
        }
    }
}