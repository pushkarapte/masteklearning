using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
       
        Console.ReadLine();
            var scores_temp = Console.ReadLine().Split(' ');
            var playerScoresWithRepeats = Array.ConvertAll(scores_temp, long.Parse);
            var playerScores = new long[playerScoresWithRepeats.Length];
            playerScores[0] = playerScoresWithRepeats[0];
            int k = 0;
            for (int j = 1; j < playerScoresWithRepeats.Length; j++)
            {
                if (playerScoresWithRepeats[j] < playerScores[k])
                {
                    playerScores[++k] = playerScoresWithRepeats[j];
                }
            }

            var totalLevelsToPlay = int.Parse( Console.ReadLine());
            var alice_temp = Console.ReadLine().Split(' ');
            var aliceScores = Array.ConvertAll(alice_temp, long.Parse);


            var currentRoundRank = 0;
            var aliceScoreIndex = 0;
            var nextAliceScore = aliceScores[aliceScoreIndex];

            if (nextAliceScore < playerScores[playerScores.Length - 1])
            {
                currentRoundRank = playerScores.Length + 1;
            }
            else
            {
                for (int i = 0; i < playerScores.Length; i++)
                {
                    if (nextAliceScore >= playerScores[i])
                    {
                        currentRoundRank++;
                        break;
                    }
                    currentRoundRank++;
                }
            }
            totalLevelsToPlay--;
            Console.WriteLine(currentRoundRank);



            while (totalLevelsToPlay > 0)
            {
                nextAliceScore = aliceScores[++aliceScoreIndex];
                var temp = currentRoundRank - 2;

                while (temp > -1)
                {
                    var nextHigherRankedPlayerScore = playerScores[temp--];
                    if (nextAliceScore >= nextHigherRankedPlayerScore)
                    {
                        currentRoundRank--;
                        continue;
                    }
                    else
                        break;
                }
                Console.WriteLine(currentRoundRank);
                totalLevelsToPlay--;
            }
        
    }
}
