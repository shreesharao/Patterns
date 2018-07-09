using System;

namespace Adapter_Pattern
{
    class Adaptee
    {
        //Adaaptee will have methods which are incompatible with Client.
        public void Start()
        {
            Console.WriteLine("Started");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }

}
