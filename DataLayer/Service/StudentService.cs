using DataLayer.Model;
using DataLayer.Interface;
using DataLayer.Repository;

namespace DataLayer.Service
{
    internal class StudentService : IStudentService
    {
        private readonly StudentRepository _studentRepository = new();

        public IEnumerable<Student> Get()
        {
            return _studentRepository.Get();
        }

        public Student Get(int id)
        {
            return _studentRepository.Get(id);
        }

        public bool Add(Student entity)
        {
            return _studentRepository.Add(entity);
        }

        public bool Update(Student entity)
        {
            return _studentRepository.Update(entity);
        }

        public bool Delete(int id)
        {
            return _studentRepository.Delete(id);
        }
    }
}
