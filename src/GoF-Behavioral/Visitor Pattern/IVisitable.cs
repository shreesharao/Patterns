namespace Visitor_Pattern
{
    interface IVisitable
    {
        /// <summary>
        /// Accept the passed IVisitor for each element.
        /// </summary>
        /// <param name="visitor">Visitor to accept.</param>
        void Accept(IVisitor visitor);
    }
}
