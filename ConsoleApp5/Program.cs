namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("title", "Author", 1);
            Student s = new Student("name", "name", 1);
            s.Empty();
            Thread.Sleep(1000);
        }
    }
}
