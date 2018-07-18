namespace Interpreter_Pattern
{
    class Context
    {
        private string _input;
        private int _output;

        public string Input { get => _input; set => _input = value; }
        public int Output { get => _output; set => _output = value; }

        public Context(string input)
        {
            this.Input = input;
        }
    }
}
