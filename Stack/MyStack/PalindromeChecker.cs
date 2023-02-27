using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string word)
        {
            // Erstelle einer neuen instanz vom dem MyGenericStack
            MyGenericStack<char> charStack = new MyGenericStack<char>(word.Length);

            // Push jeden Buchstaben(c) von dem Wort(word) auf den stack
            foreach (char c in word)
            {
                charStack.Push(c);
            }

            // Pop jeden Buchstaben(c) von dem stack und vergleiche es mit dem Normalen Word(word)
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != charStack.Pop())
                {
                    return false;
                }
            }

            // Wenn alle Buchstaben(c) gleich sind, dann ist das Wort(word) ein palindrom.
            return true;
        }
    }
}