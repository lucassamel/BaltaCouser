using Payments.ContentContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaCourse.ContentContext
{
    public class Module
    {
        public Module()
        {
            Lectures = [];
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}
