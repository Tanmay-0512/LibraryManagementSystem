using LibraryManagementSystem.Services;

class Program
{
    static void Main(string[] args)
    {
        LibraryManager manager = LibraryManager.GetInstance();
        manager.Run();
    }
}
