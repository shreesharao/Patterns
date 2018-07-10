namespace Decorator_Pattern
{
    /// <summary>
    /// Component
    /// </summary>
    interface ILibraryItem
    {
        int NumCopies { get; set; }
        void Display();
    }
}
