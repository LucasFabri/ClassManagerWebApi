using class_management_web_api.src.DTO.Teacher;

namespace class_management_web_api.src.Repositories
{
    public interface ITeacherRepository
    {
        public Task<IEnumerable<TeacherGetDTO>> GetTeachers ();
    }
}