using System.Collections.Generic;

namespace DemoLibrary.Interfaces
{
    public interface IDVD : ILibraryItem
    {
        IList<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}
