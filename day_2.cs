using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace advent_of_code;



public class Day_Two()
{
    public int sum=0;
    public string[]? file_Stream;
    public int Answer()
    {
        Load_Input();
        CheckIfGamePossible();
        Console.WriteLine("Answer for day 2 is: "+sum);
        return 0;
    }
    public void Load_Input()
        {
            
            try
            {
                file_Stream = File.ReadAllLines("inputs/day_2_input.txt");
            }
            catch(IOException e)
            {
                Console.WriteLine("This file could not be read: "+e.Message);
                file_Stream=["Not read"];
            }
        }

    public void CheckIfGamePossible()
    {
        foreach(string fileLine in file_Stream)
        {
            var gameNumberstring = fileLine.Split(":")[0];
            int gameNumber = Int32.Parse(gameNumberstring.Split(" ")[1]);
            
            string game = fileLine.Split(":")[1];
            //1 gra to ; setow +1
            int numberOfSets = game.Split(';').Length;
            string[] sets = game.Split(";");
            //Console.WriteLine(sets[0]);
            var gameIsPossible = CheckIfSetPossible(sets);
            if(gameIsPossible == true) SumGamesIDs(gameNumber);
        }
    }
    public bool CheckIfSetPossible(string[] sets)
    {
        foreach(string set in sets)
            {
                string[] revealedCubes = set.Split(",");
                foreach(string oneCube_iter in revealedCubes)
                {
                    var oneCube = oneCube_iter[1..];
                    int numberInSet = Int32.Parse(oneCube.Split(" ")[0]);
                    string colorInSet = oneCube.Split(" ")[1];
                    if(colorInSet == "red" && numberInSet > 12) return false;
                    else if(colorInSet == "green" && numberInSet > 13) return false;
                    else if(colorInSet == "blue" && numberInSet > 14) return false;
                }

            } 

        return true;
    }
    public void SumGamesIDs(int gameid)
    {
        sum+=gameid;
    }
}