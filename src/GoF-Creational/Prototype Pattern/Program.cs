using System;

namespace Prototype_Pattern
{
   static class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager();

            // Initialize with standard colors
            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            //user clones the selected colors
            Color color1 = colorManager["red"].Clone() as Color;

            Console.Read();
        }


    }
}
