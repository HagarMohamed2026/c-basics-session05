
namespace Ass4
{
    internal class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
      public Genre genre {  get; set;}

    }
    enum Genre { Fiction, NonFiction, Science }

}
