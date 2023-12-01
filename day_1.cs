using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace advent_of_code;
    public class Day_One()
    {
        public string[]? file_Stream;
        public int? sum=0;
        public void Answer()
        {
            Load_Input();
            First_And_Last_Number();
            Console.WriteLine("Day one answer is: "+sum);
        }
        public void Load_Input()
        {
            
            try
            {
                file_Stream = File.ReadAllLines("inputs/day_1_input.txt");
            }
            catch(IOException e)
            {
                Console.WriteLine("This file could not be read: "+e.Message);
                file_Stream=["Not read"];
            }
        }
        public void Sum(int number)
        {
            sum+=number;
            //Console.WriteLine(sum);
        }
        public void First_And_Last_Number()
        {
            char[] numbers=[];
            int i=0;
            int number_to_int;
            if(file_Stream!=null)
            {
                foreach(string file_line in file_Stream)
                {  
                    var number = file_line.ToCharArray().Where(c=>Char.IsDigit(c)).ToArray();
                    number_to_int=((number[0]-'0')*10)+(number[number.Length - 1]-'0');
                    Sum(number_to_int);
                    i++;
                }
            }
            
        }
    }

