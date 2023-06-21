using DataLayer.Model;

namespace DataLayer.Interface
{
    public interface IStudentService
    {
        IEnumerable<Student> Get();
        Student Get(int id);
        bool Add(Student entity);
        bool Update(Student entity);
        bool Delete(int id);
    }
}
