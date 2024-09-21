using BaltaCourse.ContentContext;

namespace BaltaCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre .Net", "orientacao-objetos"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Title);
            }

            var courses = new List<Course>();
            var courseDotNet = new Course("Fundamentos OOP", "funcdamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "funcdamentos-csharp");
            var courseAspNet = new Course("Fundamentos AspNet", "funcdamentos-aspnet");
            courses.Add(courseDotNet);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);           

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .Net", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseAspNet);
            var careerItem2 = new CareerItem(2, "Aprenda .Net", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda OOP", "", courseDotNet);
            careerDotNet.Items.Add(careerItem);
            careers.Add(careerDotNet);

            foreach(var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}
