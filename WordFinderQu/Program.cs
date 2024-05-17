using System.Collections.Generic;
using System.Reflection.Emit;
using System;
using WordFinderQu;

public class Program
{


    public static void Main(String[] args)
    {
        IEnumerable<string> matrix = new List<string>
        {
            "VOXFROGDWBEARQT",
            "OHCINCINEROARXO",
            "IBELEPHANTXUCAA",
            "NEMONKEYQPQFPED",
            "CALBQIITQQATOAD",
            "IRRIDPANDALILPG",
            "NZDEAIBDHLLJAAO",
            "ETXDHPENGUINRNA",
            "ROKMQPAIXSGCBDT",
            "OARLNCROTOADEAK",
            "ADDGIRAFFETYAYG",
            "RFCINCINEROARLO",
            "TIGERHMOIZRCBHA",
            "INCINEROARLIONT",
            "OJDMXINCINEROAR"
        };

        IEnumerable<string> wordstream = new List<string>
        {
            "ALLIGATOR",
            "BEAR",
            "INCINEROAR",
            "ELEPHANT",
            "FROG",
            "GIRAFFE",
            "LION",
            "MONKEY",
            "PANDA",
            "PENGUIN",
            "TOAD",
            "POLARBEAR",
            "TIGER",
            "GOAT",
        };

        Solution original = new Solution();

        IEnumerable<string> result = original.Find(matrix, wordstream);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        SolutionOptimized optimized = new SolutionOptimized();

        Console.WriteLine("/****************************************************/");

        IEnumerable<string> resultOptimized = optimized.Find(matrix, wordstream);

        foreach (var item in resultOptimized)
        {
            Console.WriteLine(item);
        }
        //sample output:
        /*"ALLIGATOR", 1
            "BEAR", 3
            "INCINEROAR", 5
            "ELEPHANT", 1
            "FROG", 1
            "GIRAFFE", 1
            "LION", 1
            "MONKEY", 1
            "PANDA", 2
            "PENGUIN", 1
            "TOAD", 3
            "POLARBEAR", 1
            "TIGER", 1
            "GOAT", 2
        */

        //var matrixOptimized = optimized.GenerateMatrixOptimized(wordstream, 15);
        //foreach (var item in matrixOptimized)
        //{
        //    Console.WriteLine(item);
        //}
        Console.WriteLine("/****************************************************/");
    }
}