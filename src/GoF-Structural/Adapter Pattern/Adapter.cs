namespace Adapter_Pattern
{
    //Adapter adapts the interface Adaptee to the Target interface thus making the interoperablity possible
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }
        public void Close()
        {
            _adaptee.Stop();
        }

        public void Open()
        {
            _adaptee.Start();
        }
    }
}
