namespace Visitor_Pattern
{
    /// <summary>
    /// Concrete IVisitable
    /// </summary>
    class Orange : IVisitable
    {

        /// <summary>
        /// Accepts the passed IVisitor.
        /// 
        /// When called, dynamic object types
        /// route execution to the correct inherited object types.
        /// </summary>
        /// <param name="visitor">Visitor to accept.</param>
        public void Accept(IVisitor visitor)
        {
            dynamic dynamicVisitor = visitor;
            dynamicVisitor.Visit(this);
        }
    }
}
