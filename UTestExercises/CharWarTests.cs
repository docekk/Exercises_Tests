using Exercises;
using NUnit.Framework;

namespace UTestExercises_CharWar
{
    class CharWarTests
    {
        [Test]
        public void BasicTests()
        {
            CharWar Kata = new CharWar();
            Assert.AreEqual("Z", Kata.Battle("AAA", "Z"));
            Assert.AreEqual("TWO", Kata.Battle("ONE", "TWO"));
            Assert.AreEqual("Tie!", Kata.Battle("ONE", "NEO"));
            Assert.AreEqual("FOUR", Kata.Battle("FOUR", "FIVE"));
        }
    }
}
