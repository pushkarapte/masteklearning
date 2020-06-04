using System;

class Solution
{
    static void Main(String[] args)
    {
        var userInput = Console.ReadLine().Split(' ');
        var numberOfClouds = int.Parse(userInput[0]); //n
        var jumpSize = int.Parse(userInput[1]); //k

        userInput = Console.ReadLine().Split(' ');
        var clouds = new int[numberOfClouds];

        for (int i = 0; i < numberOfClouds; i++)
            clouds[i] = int.Parse(userInput[i]);

        var totalEnergyRemaining = 100;
        var currentCloud = 0;
        while (true)
        {
            //calculate next cloud number after new jump.
            currentCloud = (currentCloud + jumpSize) % numberOfClouds;

            if (clouds[currentCloud] == 1)
                totalEnergyRemaining -= 3;
            else
                totalEnergyRemaining--;

            if (currentCloud == 0)
                break;
        }
        Console.WriteLine(totalEnergyRemaining);
    }
}
