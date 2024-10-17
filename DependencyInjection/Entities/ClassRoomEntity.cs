using DependencyInjection.Services;

namespace DependencyInjection.Entities
{
    public class ClassRoomEntity
    {
        private readonly ITeacher _teacher;     /// ITeacher tipinde bir private özellik. _teacher, bir öğretmeni temsil eder.

        public ClassRoomEntity(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
