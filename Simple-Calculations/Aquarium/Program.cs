using System;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double usedSpace = percent / 100;
            double aquariumVolume = lenght*width*height;
            double volumeInLiters = aquariumVolume / 1000;
            double neededLiters = volumeInLiters * (1 - usedSpace);
            Console.WriteLine(neededLiters);
        }
    }
}
