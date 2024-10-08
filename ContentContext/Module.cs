﻿using BaltaCourse.SharedContext;

namespace BaltaCourse.ContentContext
{
    public class Module : Base
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
