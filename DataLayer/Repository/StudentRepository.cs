using System.Data;
using DataLayer.Interface;
using DataLayer.Model;
using Oracle.ManagedDataAccess.Client;

namespace DataLayer.Repository
{
    internal class StudentRepository : Database, IRepository<Student, bool>
    {
        public IEnumerable<Student> Get()
        {
            const string query = "SELECT * FROM Students";
            return ExecuteReaderQuery(query, MapStudent);
        }

        public Student Get(int id)
        {
            const string query = "SELECT * FROM Students WHERE Id = :id";
            var parameter = new OracleParameter(":id", OracleDbType.Int32) { Value = id };
            return ExecuteReaderQuery(query, MapStudent, new[] { parameter }).FirstOrDefault()!;
        }

        public bool Add(Student entity)
        {
            const string query = "INSERT INTO Students (Id, Name, Email) VALUES (:id, :name, :email)";
            var parameters = new[]
            {
                new OracleParameter(":id", OracleDbType.Int32) { Value = entity.Id },
                new OracleParameter(":name", OracleDbType.Varchar2) { Value = entity.Name },
                new OracleParameter(":email", OracleDbType.Varchar2) { Value = entity.Email }
            };

            var rowsAffected = ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool Update(Student entity)
        {
            const string query = "UPDATE Students SET Name = :name, Email = :email WHERE Id = :id";

            var parameters = new[]
            {
                new OracleParameter(":name", OracleDbType.Varchar2) { Value = entity.Name },
                new OracleParameter(":email", OracleDbType.Varchar2) { Value = entity.Email },
                new OracleParameter(":id", OracleDbType.Int32) { Value = entity.Id }
            };

            var rowsAffected = ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool Delete(int id)
        {
            const string query = "DELETE FROM Students WHERE Id = :id";
            var parameter = new OracleParameter(":id", OracleDbType.Int32) { Value = id };

            var rowsAffected = ExecuteNonQuery(query, new[] { parameter });
            return rowsAffected > 0;
        }

        /*Custom mapper for the Student entity*/
        private static Student MapStudent(IDataRecord reader)
        {
            return new Student
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString(),
                Email = reader["Email"].ToString()
            };
        }
    }
}