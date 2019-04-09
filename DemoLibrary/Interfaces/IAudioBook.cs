using System;

namespace DemoLibrary.Interfaces
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
