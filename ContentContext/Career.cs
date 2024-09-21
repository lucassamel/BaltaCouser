namespace BaltaCourse.ContentContext
{
    public class Career : Content
    {
        public Career()
        {
            Items = [];
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;                              
    }
}
