using System.Collections.Generic;

namespace Visitor_Pattern
{
    /// <summary>
    /// Visitor concrete implementation
    /// </summary>
    class FruitPartitioner : IVisitor
    {
        readonly List<Apple> AppleList = new List<Apple>();
        readonly List<Orange> OrangeList = new List<Orange>();
        readonly List<Banana> BananaList = new List<Banana>();
        
        public void Visit(Apple visitable)
        {
            AppleList.Add(visitable);
        }

        public void Visit(Orange visitable)
        {
            OrangeList.Add(visitable);
        }

        public void Visit(Banana visitable)
        {
            BananaList.Add(visitable);
        }
        
        public override string ToString()
        {
            return $"Apples:{AppleList.Count}::Oranges{OrangeList.Count}::Bananas:{BananaList.Count}";
        }

        public void Visit(IVisitable visitable)
        {
            //This method is not required. But interface requires this method to be present.
        }
    }
}
