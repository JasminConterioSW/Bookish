namespace Bookish.DataAccess.dbModels
{
    public class AuthorBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}