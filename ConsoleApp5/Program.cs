namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("The Hobbit", "J. R. R. Tolkien", 310) { Price = 6500 };
            Book b = new Book("Dune", "Frank Herbert", 688) { Price = 7900 };
            Student s = new Student("name", "name", 1);
        }
    }
}
