using BaltaCourse.ContentContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = [];
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }

    }    
}
