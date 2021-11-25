using System;

namespace Bookish.DataAccess.dbModels
{
    public class Loan
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}