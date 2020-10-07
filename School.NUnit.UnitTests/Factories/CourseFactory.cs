using AutoFixture;

namespace School.NUnit.UnitTests.Factories
{
    public static class CourseFactory
    {
        public static Course CreatePopulatedCourse(int numberOfStudents = 30, string defaultStudentName = "Anton")
        {
            Fixture fixture = new Fixture();
            Course course = new Course();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentName = defaultStudentName + fixture.Create<string>();
                course.JoinCourseUpdate(new Student(studentName, 10000 + i));
            }

            return course;
        }
    }
}
