namespace Bookish.DataAccess.dbModels
{
    public class AuthorBookId
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}