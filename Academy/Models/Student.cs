using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? TeacherID { get; set; }
    public int? GroupID { get; set; }
    public string TeacherName { get; set; }

    public override string ToString() => $@"Student ID: {Id}
Student Name: {Name}
Teacher Name: {TeacherName}";


}

