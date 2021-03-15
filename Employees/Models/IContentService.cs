using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public interface IContentService
    {
        abstract public string GetHeader();
        abstract public string GetBody();
    }
}
