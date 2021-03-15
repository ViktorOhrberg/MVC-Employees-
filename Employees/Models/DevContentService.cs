using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class DevContentService : IContentService
    {
        public string GetHeader() => "You got a devcontent header";
        public string GetBody() => "You got a devcontent Body";
    }
}
