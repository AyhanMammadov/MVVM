using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models;
public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int StudentCountt { get; set; }
    public int? TeacherID { get; set; }
    public string TeacherName { get; set; }

    public override string ToString() => $@"Group name: {Name} 
Student count: ({StudentCountt})
Teacher name: {TeacherName}";

}
