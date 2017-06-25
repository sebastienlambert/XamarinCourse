using System;
using NUnit.Framework;
using CoursesLibrary;

namespace CoursesUnitTest
{
    [TestFixture]
    public class CourseManagerTest
    {
        [TestCase]
        public void TestMethod()
        {
            CourseManager courseManager = new CourseManager();
            Assert.AreEqual("Android for .Net Developers", courseManager.Current.Title);
        }
    }
}
