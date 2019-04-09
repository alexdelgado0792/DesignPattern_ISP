using DemoLibrary.Interfaces;
using System;

namespace DemoLibrary
{
    public class Book : IBorrowableBook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int CheckOutDirectionInDays { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }

        public void CheckIn()
        {
            Borrower = string.Empty;
        }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDirectionInDays);
        }
    }
}
