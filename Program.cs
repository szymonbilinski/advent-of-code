using System.Globalization;


namespace advent_of_code;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which day do you want to be answered: ");
        string day_answer_input = Console.ReadLine();
        switch(day_answer_input)
        {
            case "1":
                Day_One d_1_answer=new Day_One();
                d_1_answer.Answer();
                break;

            case "2":
                Day_Two d_2_answer = new Day_Two();
                d_2_answer.Answer();
                break;
            case "3":
                Day_Three d_3_answer = new Day_Three();
                d_3_answer.Answer();
                break;
            default:
                Day_Three d_answer = new Day_Three();
                d_answer.Answer();
                break;
        }

        

        
    }
}
