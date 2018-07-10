
namespace Decorator_Pattern
{
    interface IDecorator
    {
        ILibraryItem libraryItem { get; set; }
        void Display();
    }
}
