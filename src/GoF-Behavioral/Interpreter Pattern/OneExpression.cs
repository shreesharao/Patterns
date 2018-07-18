namespace Interpreter_Pattern
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// One checks I, II, III, IV, V, VI, VI, VII, VIII, IX
    /// </remarks>
    /// </summary>
    internal class OneExpression : Expression
    {
        public OneExpression()
        {
        }

        public override string One() { return "I"; }
        public override string Four() { return "IV"; }
        public override string Five() { return "V"; }
        public override string Nine() { return "IX"; }
        public override int Multiplier() { return 1; }
    }
}