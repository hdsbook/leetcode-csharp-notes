/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        Dictionary<char, List<string>> map = new Dictionary<char, List<string>> {
            {'2', new List<string> { "a", "b", "c" }},
            {'3', new List<string> { "d", "e", "f" }},
            {'4', new List<string> { "g", "h", "i" }},
            {'5', new List<string> { "j", "k", "l" }},
            {'6', new List<string> { "m", "n", "o" }},
            {'7', new List<string> { "p", "q", "r", "s" }},
            {'8', new List<string> { "t", "u", "v" }},
            {'9', new List<string> { "w", "x", "y", "z" }},
        };

        if (digits.Length == 0)
        {
            return new List<string>();
        }
        if (digits.Length == 1)
        {
            return map[digits[0]];
        }

        IList<string> result = new List<string>();
        result = map[digits[0]];
        for (int i = 1; i < digits.Length; i++)
        {
            char digit = digits[i];
            IList<string> newResult = new List<string>();
            foreach (string newChar in map[digit])
            {
                foreach (string resItem in result)
                {
                    newResult.Add(resItem + newChar);
                }
            }
            result = newResult;
        }
        return result;
    }
}
// public class Solution2
// {
//     public IList<string> LetterCombinations(string digits)
//     {
//         Dictionary<char, string> map = new Dictionary<char, string> {
//             {'2', new List<string> { "abc" }},
//             {'3', new List<string> { "def" }},
//             {'4', new List<string> { "ghi" }},
//             {'5', new List<string> { "jkl" }},
//             {'6', new List<string> { "mno" }},
//             {'7', new List<string> { "pqrs" }},
//             {'8', new List<string> { "tuv" }},
//             {'9', new List<string> { "wxyz" }},
//         };

//         if (digits.Length == 0)
//         {
//             return new List<string>();
//         }
//         if (digits.Length == 1)
//         {
//             return map[digits[0]];
//         }

//         IList<string> result = new List<string>();
//         List<char> tmp = new List<char>();
//         Backtrack(0, digits, result, tmp);

//         return result;
//     }

//     void Backtrack(int start, string digits, Dictionary<char, string> map, IList<string> result, List<char> tmp)
//     {
//         if (start == digits.Length)
//         {
//             // return
//         }

//         string charSet = map[start];
//         for (int i = 0; i < length; i++)
//         {
//             char newChar = charSet[i];
//             tmp.add
//         }
//     }
// }
// @lc code=end

