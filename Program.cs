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
        }
    }
}
