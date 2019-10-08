using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class TestClass
    {
        public class Kata
        {
            public static int SquareDigits(int n)
            {
                string nString = n.ToString();
                var intList = nString.Select(digit => int.Parse(digit.ToString())).ToList();
                var newList = new List<int>();

                foreach (var x in intList)
                {
                    var square = x * x;
                    newList.Add(square);
                }

                var concat = string.Join("", newList.ToArray());
                return int.Parse(concat);
            }

            public static int FindShort(string s)
            {
                var stringArray = s.Split(' ');
                var stringList = new List<int>();

                foreach (var x in stringArray)
                    stringList.Add(x.Count());

                return stringList.Min();
            }

            public static bool IsIsogram(string str)
            {
                var strArray = str.ToLower().ToCharArray();
                var uniqueArray = strArray.Distinct().ToArray();

                if (strArray.Length == uniqueArray.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static string Tickets(int[] peopleInLine)
            {
                int change = 0;
                string resultString = "YES";

                foreach (var x in peopleInLine)
                {
                    change += 25;

                    if (x > 25)
                    {
                        if (x > change)
                        {
                            resultString = "NO";
                            break;
                        }
                        change -= (x - 25);
                    }
                }
                return resultString;
            }

            public static string SeriesSum(int n)
            {
                float total = 0F;

                if (n == 0)
                    return "0.00";
                if (n == 1)
                    return "1.00";
                if (n == 2)
                    return "1.25";
                if (n > 2)
                {
                    float val = 7F;
                    total = 1.25F;

                    for (int i = 0; i < (n - 2); i++)
                    {
                        total += (1F / val);
                        val += 3F;
                    }
                }

                return total.ToString("F");
            }

            public static int[] SortArray(int[] array)
            {
                if (array == null)
                    return array;

                var indexes = new List<int>();
                var oddNumbers = new List<int>();

                int index = 0;
                foreach (var x in array)
                {
                    if (x % 2 != 0)
                    {
                        indexes.Add(index);
                        oddNumbers.Add(x);
                    }
                    index++;
                }

                oddNumbers.Sort();

                int j = 0;
                foreach (var i in indexes)
                {
                    array[i] = oddNumbers[j];
                    j++;
                }

                return array;
            }

            public static string[] Solution(string str)
            {
                int leng = 0;

                if (str.Length % 2 == 1)
                { leng = (str.Length / 2) + 1;
                    str += "_";
                }
                else
                { leng = str.Length / 2; }

                var lis = new List<string>();

                var x = 0; var y = 2;
                for (int i = 0; i < leng; i++)
                {
                    lis.Add(str.Substring(x, y));
                    x = x + 2;
                }

                var arr = lis.ToArray();

                return arr;
            }

            public static int GetVowelCount(string str)
            {
                int vowelCount = 0;
                var vowelList = new List<string>() { "a", "e", "i", "o", "u" };

                foreach (var x in str)
                {
                    if (vowelList.Contains(x.ToString()))
                        vowelCount++;
                }

                return vowelCount;
            }

            public static bool ValidatePin(string pin)
            {
                var numList = new List<Char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                char[] charArray = pin.ToCharArray();

                if (pin.Length == 4 || pin.Length == 6)
                {
                    foreach (char x in charArray)
                    {
                        if (!numList.Contains(x))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }


            // https://www.codewars.com/kata/554ca54ffa7d91b236000023/train/csharp
            // [1,1,3,3,7,2,2,2,2,1,1,3,3]   3
            // return new array with contains each number max x times
            public static int[] DeleteNth(int[] arr, int x)
            {
                List<int> arrList = arr.ToList();
                var emptyList = new List<int>();

                var Dict = new Dictionary<int, int>();

                foreach(int i in arrList)
                {
                    if (Dict.ContainsKey(i))
                        Dict[i]++;
                    else
                        Dict[i] = 1;
                    
                    if(Dict[i] <= x)
                        emptyList.Add(i);
                }

                return emptyList.ToArray();
            }

            public static int Opposite(int number)
            {
                return number * -1;
            }

            public static int AdjacentElementsProduct(int[] array)
            {
                int multiplied, i, j=1;
                var testList = new List<int>();

                for (i = 0; i<array.Length-1; i++)
                {
                    multiplied = array[i] * array[j];
                    testList.Add(multiplied);
                    j++;
                }

                return testList.Max();
            }
        }
    }
}


/*

  
*/

