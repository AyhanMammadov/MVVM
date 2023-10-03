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
public class GroupRepository : IGroupRepository
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int StudentCountt { get; set; }
    public int TeacherID { get; set; }


    private const string connectionString = $"Server=localhost;Database=Academy;Integrated Security = True;";
    private readonly SqlConnection sqlConnection;

    public GroupRepository()
    {
        this.sqlConnection = new SqlConnection(connectionString);
        this.sqlConnection.Open();
    }

    public IEnumerable<Group> GetAll() => this.sqlConnection.Query<Group>(sql: @"select g.Name , g.StudentCountt , t.Name as TeacherName from Groups g
join Teachers t on t.GroupID =g.TeacherID");
}

