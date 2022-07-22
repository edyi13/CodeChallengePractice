using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowlinginput
{
    public class Solution
    {
        /*
         * Given a string representation of a bowling score card, calculate the numeric score of the score card.

The scoring information for a bowling score card is provided below:

Bowler is allowed a maximum of 10 frames.
Each frame has 10 pins.
Frames 1 - 9 consist of two balls (two attempts).
Frame 10 can consist of three balls.
If all pins are down using one ball, this is a strike (denoted by an X) and counts as 10 points.
If all pins are down using two balls, this is a spare (denoted by a /) and counts as 10 points.
In the event of a strike the next two balls' points are added to the strike score of 10.
EG: bowling a strike, five and one results in scoring of (10+5+1), 5, 1).
In the event of a spare the next one ball's points are added to the spare score of 10.
EG: bowling a spare, five and one results in scoring of (10+5), 5, 1).
In the event of a strike, additional attempts in that frame are not used.
The maximum attainable score from any frame is 30 (three strikes in a row).
The score card will be passed as an array of strings constituting 10 frames. The method should return an integer score.

For example, consider the following score card:

["9", "/", "7", "1", "X", "5", "1", "0", "7", "9", "0", "3", "6", "X", "3", "1", "9", "0"]

The total score in the above example is 99.
        */
        public static int calculateScore(String[] input)
        {
            int count = 0;
            for (int i = 0; i< input.Length; i++)
            {
                // condition for '0' to '9' values
                if (input[i][0]>='0' && input[i][0]<='9')
                {
                    count += (input[i][0]-'0');
                    Console.WriteLine((input[i][0]-'0'));
                    // check for strikes and spares in previous points
                    if (i-2>=0 &&  input[i-2][0]=='X') count += (input[i][0]-'0');
                    else if (i-1>=0 &&  (input[i-1][0]=='X'||input[i-1][0]=='/')) count += (input[i][0]-'0');
                }
                // condition for a strike
                else if (input[i][0] == 'X')
                {
                    count += 10;
                }
                // condition for a spare
                else if (input[i][0] == '/')
                {
                    count -= (input[i-1][0]-'0');
                    count += 10;
                    // check for a strike before
                    if (i-2>=0 &&  input[i-2][0]=='X') count += 10;
                }
            }
            return count;
        }

        public static int calculateScore2(String[] input)
        {
            int count = 0;
            int val = 0;
            for (int i = 0; i< input.Length; i++)
            {
                // condition for '0' to '9' values
                if (int.TryParse(input[i],out val))
                {
                    count += Convert.ToInt32(input[i]);
                    // check for strikes and spares in previous points
                    if (i-2>=0 &&  input[i-2]=="X")
                    {
                        count += Convert.ToInt32(input[i]);
                    }
                    else if (i-1>=0 &&  (input[i-1]=="X"||input[i-1]=="/"))
                    {
                        count += Convert.ToInt32(input[i]);
                    }
                }
                // condition for a strike
                else if (input[i] == "X")
                {
                    count += 10;
                }
                // condition for a spare
                else if (input[i] == "/")
                {
                    count -= Convert.ToInt32(input[i-1]);
                    count += 10;
                    // check for a strike before
                    if (i-2>=0 &&  input[i-2] == "X")
                    {
                        count += 10;
                    }
                }
            }
            return count;
        }

        public static int GetScore(string[] input)
        {
            int count = 0;
            int val = 0;
            for (int i = 0; i< input.Length; i++)
            {
                // condition for '0' to '9' values
                if (int.TryParse(input[i], out val))
                {
                    count += Convert.ToInt32(input[i]);
                    // check for strikes and spares in previous points
                    if (i-2>=0 &&  input[i-2]=="X")
                    {
                        count += Convert.ToInt32(input[i]);
                    }
                    else if (i-1>=0 &&  (input[i-1]=="X"||input[i-1]=="/"))
                    {
                        count += Convert.ToInt32(input[i]);
                    }
                }
                // condition for a strike
                else if (input[i] == "X")
                {
                    count += 10;
                }
                // condition for a spare
                else if (input[i] == "/")
                {
                    count -= Convert.ToInt32(input[i-1]);
                    count += 10;
                    // check for a strike before
                    if (i-2>=0 &&  input[i-2] == "X")
                    {
                        count += 10;
                    }
                }
            }
            return count;
        }

        static void Main(String[] args)
        {

            String[] pins = new String[] { "9", "/", "7", "1", "X", "5", "1", "0", "7", "9", "0", "3", "6", "X", "3", "1", "9", "0" };
            //Console.WriteLine(calculateScore(pins));
            Console.WriteLine(calculateScore2(pins));
            Console.WriteLine(GetScore(pins));
        }
    }
}
