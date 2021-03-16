using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public interface IContentService
    {
        public string GetHeader();
        public string GetBody();
    }
}
