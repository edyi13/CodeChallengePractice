public class Program
{
    public static IEnumerable<string> Find(IEnumerable<string> matrix, IEnumerable<string> wordstream)
    {
        var words = new List<string>();
        words.AddRange(FindHorizontal(matrix, wordstream));
        words.AddRange(FindVertical(matrix, wordstream));
        return words;
    }

    public static IEnumerable<string> FindVertical(IEnumerable<string> matrix, IEnumerable<string> wordstream)
    {
        var words = new List<string>();
        var matrixArray = matrix.ToArray();
        var wordstreamArray = wordstream.ToArray();
        string wordFound = "";
        bool found = false;
        int index = 0;
        for (int m = 0; m < matrixArray.Length; m++)
        {
            for (int i = 0; i < wordstreamArray.Length; i++)
            {
                string row = matrixArray[m].ToLower().Trim();
                string word = wordstreamArray[i].ToLower();
                for (int j = 0; j < row.Length; j++)
                {
                    if (wordFound == word)
                    {
                        words.Add(wordFound);
                        wordFound = "";
                        index = 0;
                        break;
                    }else if (word.Length== index)
                    {
                        index = 0;
                    }
                    else if (word[index] == row[j])
                    {
                        wordFound += row[j];
                        index++;
                        found = true;
                    }
                    else
                    {
                        wordFound = "";
                        if (found)
                        {
                            index = 0;
                            found = false;
                        }
                    }
                }
            }
        }
        return words;
    }

    public static IEnumerable<string> FindHorizontal(IEnumerable<string> matrix, IEnumerable<string> wordstream)
    {
        string[] matrixArray = matrix.ToArray();
        string[] wordstreamArray = wordstream.ToArray();
        List<string> words = new List<string>();
        for (int i = 0; i < matrixArray.Length; i++)
        {
            for (int j = 0; j < matrixArray[i].Length; j++)
            {
                if (matrixArray[i][j] == wordstreamArray[0][0])
                {
                    string word = "";
                    for (int k = 0; k < wordstreamArray.Length; k++)
                    {
                        if (i + k < matrixArray.Length)
                        {
                            word += matrixArray[i + k][j];
                        }
                    }
                    if (word == wordstreamArray[0])
                    {
                        words.Add(word);
                    }
                }
            }
        }
        return words;
    }


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
            "OJINCINEROARDMX"
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
            "GOAT"
        };

        IEnumerable<string> result = Find(matrix, wordstream);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        //result should be:
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
            "TOAD", 4
            "POLARBEAR", 1
            "TIGER", 1
            "GOAT", 2
        */
    }
}