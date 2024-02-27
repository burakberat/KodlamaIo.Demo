using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>();

            _courses.Add(new Course
            {
                CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                InstructorName = "Engin Demiroğ",
                Id = 1,
                CreatedDate = DateTime.Now
            });
            _courses.Add(new Course
            {
                CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
                InstructorName = "Engin Demiroğ",
                Id = 2,
                CreatedDate = DateTime.Now
            });
            _courses.Add(new Course
            {
                CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",
                InstructorName = "Engin Demiroğ",
                Id = 3,
                CreatedDate = DateTime.Now
            });
            _courses.Add(new Course
            {
                CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                InstructorName = "Engin Demiroğ",
                Id = 4,
                CreatedDate = DateTime.Now
            });
            _courses.Add(new Course
            {
                CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
                InstructorName = "Engin Demiroğ",
                Id = 5,
                CreatedDate = DateTime.Now
            });
            _courses.Add(new Course
            {
                CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
                InstructorName = "Halit Enes Kalaycı",
                Id = 6,
                CreatedDate = DateTime.Now
            });
            _courses.Add(new Course
            {
                CourseName = "Programlamaya Giriş için Temel Kurs",
                InstructorName = "Engin Demiroğ",
                Id = 7,
                CreatedDate = DateTime.Now
            });
            _courses.Add(new Course
            {
                CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                InstructorName = "Engin Demiroğ",
                Id = 8,
                CreatedDate = DateTime.Now
            });
        }

        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course entity)
        {
            Course courseToUpdate = _courses.FirstOrDefault(c => c.Id == entity.Id);
            if (courseToUpdate != null)
            {
                courseToUpdate.CourseName = entity.CourseName;
                courseToUpdate.Id = entity.Id;
                courseToUpdate.InstructorName = entity.InstructorName;
                courseToUpdate.UpdatedDate = DateTime.Now;
            }
        }
    }
}
