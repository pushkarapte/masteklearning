using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the queensAttack function below.
    static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles) {

  int moveCount = 0;

    moveCount = moveCount + diagonalCount(r_q, c_q, obstacles, n);
    moveCount = moveCount + verticalCount(r_q, c_q, obstacles, n);
    moveCount = moveCount + horizontalCount(r_q, c_q, obstacles, n);

    return moveCount;

}

static int diagonalCount(int r_q,int c_q,int[][] obstacles, int n)
{
    int moveCount = 0;
    int runningRow = r_q;
    int runningCol = c_q;

    while(runningRow>1 && runningCol > 1)
    {
        runningRow = runningRow - 1;
        runningCol = runningCol - 1;

        if(r_q == 1 || c_q == 1)
            break;

        if(isObstacle(runningRow, runningCol, obstacles))
        {
            break;
        }
        moveCount = moveCount + 1;
    }   

    runningRow = r_q;
    runningCol = c_q;
    while(runningRow>1 && runningCol < n)
    {

        runningRow = runningRow- 1;
        runningCol = runningCol + 1;


        if(isObstacle(runningRow, runningCol, obstacles))
        {
            break;
        }
        moveCount = moveCount + 1;
    }   

    runningRow = r_q;
    runningCol = c_q;
    while(runningRow < n  && runningCol > 1)
    {
        runningRow = runningRow + 1;
        runningCol = runningCol - 1;

        if(r_q == n || c_q == 1)
            break;

        if(isObstacle(runningRow, runningCol, obstacles))
        {
            break;
        }
        moveCount = moveCount + 1;
    }   

    runningRow = r_q;
    runningCol = c_q;
    while(runningRow < n && runningCol < n)
    {

        runningRow = runningRow + 1;
        runningCol = runningCol + 1;


        if(isObstacle(runningRow, runningCol, obstacles))
        {
            break;
        }
        moveCount = moveCount + 1;
    }   



    return moveCount;
}


static int verticalCount(int r_q,int c_q,int[][] obstacles, int n)
{
    int moveCount = 0;
    int runningRow = r_q;
    while(runningRow >1)
    {
        runningRow = runningRow - 1;

        if(isObstacle(runningRow, c_q, obstacles))
        {
            break;
        }
        moveCount = moveCount + 1;

    }
    runningRow = r_q;
    while(runningRow < n)
    {
        runningRow = runningRow + 1;

        if(isObstacle(runningRow, c_q, obstacles))
        {
            break;
        }

        moveCount = moveCount + 1;
    }

    return moveCount;
}


static int horizontalCount(int r_q,int c_q,int[][] obstacles, int n)
{
    int moveCount = 0;
    int runningcolumn = c_q;
    while(runningcolumn > 1)
    {
        runningcolumn= runningcolumn - 1;
        if(isObstacle(r_q, runningcolumn, obstacles))
        {
            break;
        }

        moveCount = moveCount + 1;
    }

    runningcolumn = c_q;

    while(runningcolumn < n)
    {
        runningcolumn = runningcolumn+ 1;

        if(isObstacle(r_q, runningcolumn, obstacles))
        {
            break;
        }

        moveCount = moveCount + 1;
    }

    return moveCount;
}


static bool isObstacle(int r, int c, int[][] obstacles)
{
    for(int i = 0; i< obstacles.Length;i++)
    {
        if(r == obstacles[i][0] && c == obstacles[i][1])
            return true;
    }

    return false;
}
    

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        string[] r_qC_q = Console.ReadLine().Split(' ');

        int r_q = Convert.ToInt32(r_qC_q[0]);

        int c_q = Convert.ToInt32(r_qC_q[1]);

        int[][] obstacles = new int[k][];

        for (int i = 0; i < k; i++) {
            obstacles[i] = Array.ConvertAll(Console.ReadLine().Split(' '), obstaclesTemp => Convert.ToInt32(obstaclesTemp));
        }

        int result = queensAttack(n, k, r_q, c_q, obstacles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
