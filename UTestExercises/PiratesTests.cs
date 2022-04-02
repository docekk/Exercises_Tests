using Exercises;
using NUnit.Framework;
using System.Collections.Generic;

namespace UTestExercises_Pirates
{
    class PiratesTests
    {
        [Test, Description("should fire the cannons when ready")]
        public void SampleAyeTest()
        {
            Pirates Pirates = new Pirates();
            Dictionary<string, string> gunners = new Dictionary<string, string>
            {
              {"Mike", "aye"},
              {"Joe", "aye"},
              {"Johnson", "aye"},
              {"Peter", "aye"}
            };

            Assert.AreEqual("Fire!", Pirates.CannonsReady(gunners));
        }
        [Test, Description("should shiver me timbers if not ready")]
        public void SampleNayTest()
        {
            Pirates Pirates = new Pirates();
            Dictionary<string, string> gunners = new Dictionary<string, string>
            {
              {"Mike", "aye"},
              {"Joe", "nay"},
              {"Johnson", "aye"},
              {"Peter", "aye"}
            };

            Assert.AreEqual("Shiver me timbers!", Pirates.CannonsReady(gunners));
        }
    }
}
