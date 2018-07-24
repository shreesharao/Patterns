using System;

namespace Template_Method_Pattern
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    abstract class DataAccessObject
    {
        protected string connectionString;

        public virtual void Connect()
        {
            Console.WriteLine("Connecting..");
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            Console.WriteLine("Disconnecting..");
            connectionString = "";
        }

        // The 'Template Method'
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
