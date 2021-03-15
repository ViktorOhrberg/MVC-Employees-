using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class ReleaseContentService : IContentService
    {
        public string GetHeader() => "You got a releasecontent header";
        public string GetBody() => "You got a releasecontent Body";
    }
}
