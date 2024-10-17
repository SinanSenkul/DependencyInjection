using DependencyInjection.Services;

namespace DependencyInjection.Entities
{
    public class TeacherEntity : ITeacher   // TeacherEntity sınıfı, ITeacher interface'ini uygular.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public TeacherEntity(string firstName, string lastName)     // Constructor: Sınıftan bir nesne oluşturulurken çalışır.
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
