namespace Iterator_Pattern
{
    class Item
    {
        private readonly string _name;

        public Item(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
