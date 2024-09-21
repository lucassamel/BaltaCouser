namespace BaltaCourse.ContentContext
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
