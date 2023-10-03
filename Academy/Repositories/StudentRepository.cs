using Academy.Models;
using Academy.Repositories.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Repositories;
public class StudentRepository : IStudentRepository
{
    private const string connectionString = $"Server=localhost;Database=Academy;Integrated Security = True;";
    private readonly SqlConnection sqlConnection;

    public StudentRepository()
    {
        this.sqlConnection = new SqlConnection(connectionString);
        this.sqlConnection.Open();
    }

    public IEnumerable<Student> GetAll() => this.sqlConnection.Query<Student>(sql: @"select s.ID , s.Name , t.Name as TeacherName from Students s
join Teachers t on t.ID = s.TeacherID");
}

