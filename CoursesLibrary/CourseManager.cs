using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibrary
{
    public class CourseManager
    {
        private readonly Course[] courses;
        private readonly int lastIndex;
        int currentIndex = 0;

        public CourseManager()
        {
            courses = InitCourses();
            lastIndex = courses.Length - 1;
        }

        private Course[] InitCourses()
        {
            var initCourses = new Course[]
            {
                new Course()
                {
                    Title = "Android for .Net Developers",
                    Description= "Provides an overview of the tools used in the Android development process including the newly released Android Studio.",
                    Image = "DocImage000000024"
                },
                new Course()
                {
                    Title = "Android Dreams, Widgets, Notifications",
                    Description= "Provide users with a rich and interactive experience without ever requiring them to open your app.",
                    Image = "DocImage000000025"
                },
                new Course()
                {
                    Title = "Android Photo/Video Programming",
                    Description= "Learn how to capitalize on the Android camera within your apps to capture still photos and video.",
                    Image = "DocImage000000026"
                },
                new Course()
                {
                    Title = "Android Location-Based Apps",
                    Description= "Cover the wide range of Android location capabilities including determining user location, power management, and translating location data to human-readable addresses.",
                    Image = "DocImage000000027"
                }
            };
            return initCourses;
        }

        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MovePrev()
        {
            if (currentIndex > 0)
                --currentIndex;
        }

        public void MoveNext()
        {
            if (currentIndex < lastIndex)
                ++currentIndex;
        }

        public Course Current
        {
            get { return courses[currentIndex]; }
        }

        public Boolean CanMovePrev
        {
            get { return currentIndex > 0; }
        }

        public Boolean CanMovenNext
        {
            get { return currentIndex < lastIndex;  }
        }



    }
}
