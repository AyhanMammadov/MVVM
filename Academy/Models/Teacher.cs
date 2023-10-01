using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models;
public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? GroupID { get; set; }
    public string GroupName { get; set; }
    public override string ToString() => $@" Teacher ID : {Id}
Group Name: {GroupName}
Teacher name: {Name}";
}

