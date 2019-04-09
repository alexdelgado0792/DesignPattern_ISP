using System;

namespace DemoLibrary.Interfaces
{
    public interface IBorrowable
    {
        int CheckOutDirectionInDays { get; set; }
        string Borrower { get; set; }
        DateTime BorrowDate { get; set; }

        void CheckOut(string borrower);
        void CheckIn();
        DateTime GetDueDate();
    }
}
