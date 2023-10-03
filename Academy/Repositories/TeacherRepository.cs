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
public class TeacherRepository : ITeacherRepository
{
    private const string connectionString = $"Server=localhost;Database=Academy;Integrated Security = True;";
    private readonly SqlConnection sqlConnection;

    public TeacherRepository()
    {
        this.sqlConnection = new SqlConnection(connectionString);
        this.sqlConnection.Open();
    }

    public IEnumerable<Teacher> GetAll() => this.sqlConnection.Query<Teacher>(sql: @"select t.ID , t.Name , t.GroupID , g.Name as GroupName from Teachers t 
join Groups g on g.ID = t.GroupID");



}

