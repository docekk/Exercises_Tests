using Exercises;
using NUnit.Framework;

namespace UTestExercises_SortString
{
    class SortingStringTestst
    {
        [Test]
        public void StringSort()
        {
            SortString TwoToOne = new SortString();
            Assert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}
