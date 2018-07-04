using System;

namespace Prototype_Pattern
{
    class Color : IPrototype
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;

        // Constructor

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Create a shallow copy

        public IPrototype Clone()
        {
            Console.WriteLine(
              "Cloning color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);

            return this.MemberwiseClone() as IPrototype;
        }
    }
}
