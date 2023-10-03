using Academy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Repositories.Base;

public interface IGroupRepository
{
    IEnumerable<Group> GetAll();
}
