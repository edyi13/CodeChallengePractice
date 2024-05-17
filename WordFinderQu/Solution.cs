using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinderQu
{
    public class Solution
    {
        /// <summary>
        /// This method takes a matrix and a wordstream as input and returns the list of the 10 more repeated words found in the matrix.
        /// </summary>
        /// <param name="matrix">Is an array of strings representing the matrix.</param>
        /// <param name="wordstream">Is an array of strings representing the words to search for.</param>
        /// <returns></returns>
        public IEnumerable<string> Find(IEnumerable<string> matrix, IEnumerable<string> wordstream)
        {
            // Run FindHorizontal and FindVertical in parallel
            var horizontalTask = Task.Run(() => FindHorizontal(matrix.ToArray(), wordstream.ToArray()));
            var verticalTask = Task.Run(() => FindVertical(matrix.ToArray(), wordstream.ToArray()));

            Task.WaitAll(horizontalTask, verticalTask);

            var words = new List<string>();
            words.AddRange(horizontalTask.Result);
            words.AddRange(verticalTask.Result);

            //return the 10 most repeated words
            return words.GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Take(10)
                .Select(x => $"{x.Count()}x {x.Key}");
        }

        /// <summary>
        /// This method takes a matrix and a wordstream as input and returns a list of words found horizontally in the matrix.
        /// </summary>
        /// <param name="matrix">Is an array of strings representing the matrix.</param>
        /// <param name="wordstream">Is an array of strings representing the words to search for.</param>
        /// <returns>return the list of words found horizontally</returns>
        public static IEnumerable<string> FindHorizontal(string[] matrixArray, string[] wordstreamArray)
        {
            var words = new List<string>();
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
                        if (word.Length == index)
                        {
                            index = 0;
                        }
                        else if (word[index] == row[j])
                        {
                            wordFound += row[j];
                            index++;
                            found = true;
                            if (wordFound == word)
                            {
                                words.Add(wordFound);
                                wordFound = "";
                                index = 0;
                            }
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

        /// <summary>
        /// This method takes a matrix and a column index as input and returns the column as an array of strings.
        /// </summary>
        /// <param name="matrix">Is an array of strings</param>
        /// <param name="index">Is the column index </param>
        /// <returns>return column as an array of strings</returns>
        public static string[] GetColumn(string[] matrix, int index)
        {
            return matrix.Select(row => row[index].ToString()).ToArray();
        }

        /// <summary>
        /// This method takes a matrix and a wordstream as input and returns a list of words found vertically in the matrix.
        /// </summary>
        /// <param name="matrix">Is an array of strings representing the matrix.</param>
        /// <param name="wordstream">Is an array of strings representing the words to search for.</param>
        /// <returns>return the list of words found vertically</returns>
        public static IEnumerable<string> FindVertical(string[] matrixArray, string[] wordstreamArray)
        {
            List<string> words = new List<string>();
            string wordFound = "";
            bool found = false;
            int index = 0;
            for (int m = 0; m < matrixArray.Length; m++)
            {
                for (int i = 0; i < wordstreamArray.Length; i++)
                {
                    string[] column = GetColumn(matrixArray, m);
                    string word = wordstreamArray[i].ToLower();
                    for (int j = 0; j < column.Length; j++)
                    {
                        if (word.Length == index)
                        {
                            index = 0;
                        }
                        else if (word[index].ToString() == column[j].ToLower().Trim())
                        {
                            wordFound += column[j].ToLower().Trim();
                            index++;
                            found = true;
                            if (wordFound == word)
                            {
                                words.Add(wordFound);
                                wordFound = "";
                                index = 0;
                            }
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

        /// <summary>
        /* This method takes a list of words as input and generates a word matrix. It follows these steps:
           Initializes a random number generator.
           Creates a 2D character array matrix to represent the word matrix.
           Initializes the matrix with spaces ' ' to represent empty cells.
           Loops through each word in the input list and tries to place the word in a random direction (horizontal or vertical) within the matrix.
           If a valid position is found, the word is placed in the matrix.
           After placing all words, fills the remaining empty cells with random letters.
        */
        /// </summary>
        /// <param name="words">List of words for creating a word search matrix</param>
        /// <param name="matrixSize">Size of the matrix: if you enter 15, the matrix will be 15x15.</param>
        /// <returns></returns>
        public static IEnumerable<string> GenerateMatrix(List<string> words, int matrixSize)
        {
            Random random = new Random();
            char[][] matrix = new char[matrixSize][];
            //Initializes each row of the matrix with spaces ' ', representing empty cells.
            for (int i = 0; i < matrixSize; i++)
            {
                matrix[i] = Enumerable.Repeat(' ', matrixSize).Select(c => (char)c).ToArray();
            }

            //Iterates through each word in the input list.
            foreach (string word in words)
            {
                bool placed = false;
                while (!placed)
                {
                    // Randomly choose direction, row, and column for word placement
                    // Check if word can be placed in the selected position
                    // If valid, place the word and set placed to true
                    int direction = random.Next(2); // 0 for horizontal, 1 for vertical
                    int row = random.Next(matrixSize); // Randomly select a row
                    int column = random.Next(matrixSize - word.Length + 1); // Randomly select a column within the word's length

                    if (direction == 0) // Horizontal placement
                    {
                        // Check if word can fit horizontally and positions are empty
                        if (column >= 0 && column + word.Length <= matrixSize && matrix[row].Skip(column).Take(word.Length).All(c => c == ' '))
                        {
                            // Place the word horizontally in the matrix
                            for (int i = 0; i < word.Length; i++)
                            {
                                matrix[row][column + i] = word[i];
                            }
                            placed = true;
                        }
                    }
                    else // Vertical placement
                    {
                        // Check if word can fit vertically and positions are empty
                        if (row + word.Length <= matrixSize && Enumerable.Range(0, word.Length).All(i => matrix[row + i][column] == ' '))
                        {
                            // Place the word vertically in the matrix
                            for (int i = 0; i < word.Length; i++)
                            {
                                matrix[row + i][column] = word[i];
                            }
                            placed = true;
                        }
                    }
                }
            }

            // Fill remaining empty cells with random letters
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (matrix[i][j] == ' ')
                    {
                        matrix[i][j] = (char)('A' + random.Next(26)); // Random letter
                    }
                }
            }

            return matrix.Select(row => new string(row)).ToList();
        }

    }
}
