namespace Adapter_Pattern
{
    //Clinet wants to call Open and Close methods. but the adaptee is having incompatible methods Start and Stop. Here we need an Adapter 
    //which makes possible the communication between client and adaptee.
    class Client
    {
        public void Entry()
        {
            ITarget _target = new Adapter();

            //Client calls Open but internally 'Adapter' convertes it to Start method.
            _target.Open();
            _target.Close();
        }
    }
}
