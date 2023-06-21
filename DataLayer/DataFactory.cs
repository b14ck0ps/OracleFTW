using DataLayer.Interface;
using DataLayer.Service;

namespace DataLayer
{
    public static class DataFactory
    {
        public static IStudentService StudentService => new StudentService();
    }
}
