namespace Ass4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
        //Q1:
            // Console.WriteLine(book.password); it causes error because passwoord is private,so it is accessible only inside the Book class.
        //Q2:
            Console.WriteLine(book.copiesInStock);// yes,it compiles because internal is accessible anywhere in the same project.
        //Q3:
            book.Title = "Story";
            Console.WriteLine(book.Title);
        //Q4:
            book.genre = Genre.Science;
            Console.WriteLine(book.genre);
        //Q5:
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
        //Q6:
            int genreNumber = 1;
            Genre result = (Genre)genreNumber;
            Console.WriteLine(result);
        //Q7:
            Genre genre = Genre.Fiction;
            string GenreString = genre.ToString();
            Console.WriteLine(GenreString);

        //Q8:
            string genreText = "Science";
            Genre value = (Genre)Enum.Parse(typeof(Genre),genreText);
            Console.WriteLine(value);

        //Q9:
            string GenreText = "Mystery";
            if(Enum.TryParse(GenreText,out Genre genreValue))
            {
                Console.WriteLine(genreValue);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
        }
    }
}
