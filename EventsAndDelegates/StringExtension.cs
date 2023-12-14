using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public static class StringExtension
    {
        public static string CapitalizeIT(this string str)
        {
            Console.WriteLine(str);
            if (str == null)
            {
                return str;
            }
            return str.ToUpper();
        }

        public static bool IsPalindrome(this string str)
        {
            var left = 0;
            var right = str.Length -1;
            while (right > left)
            {
                if (str[right] != str[left]) 
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static bool AreBracketBalanced(this string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char bracket in str)
            {

                if (bracket == '(' || bracket == '[' || bracket == '{')
                {
                    stack.Push(bracket);
                }
                else if(bracket == ')' || bracket == ']' || bracket == '}') 
                { 
                    if(stack.Count == 0 || !IsMatchingBracket(stack.Pop(), bracket))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0; // atlast stack must be empty no element should left there

        }
        private static bool IsMatchingBracket(char openBracket, char closeBracket)
        {
            return (openBracket == '(' && closeBracket == ')') ||
                   (openBracket == '[' && closeBracket == ']') ||
                   (openBracket == '{' && closeBracket == '}');
        }


    }
}
