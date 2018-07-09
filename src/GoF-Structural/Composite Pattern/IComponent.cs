namespace Composite_Pattern
{
    interface IComponent
    {
        string Name { get; set; }
        void Add(IComponent component);
        void Remove(IComponent component);
        void Display(int indent);

    }
}
