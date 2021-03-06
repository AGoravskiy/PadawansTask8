﻿using System.Text;
using System;
using System.Collections.Generic;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }
            if (text == "")
            {
                throw new ArgumentException();
            }
            string word = "";
            bool isDigit = true;
            List<string> words = new List<string>();
            List<char> symbols = new List<char> { '.', ',', '!', '?', '-', ':', ';', ' ' };
            int beginPosition = 0;
            for (int i = 0; i <= text.Length; i++)
            {
                if (i == text.Length || symbols.Contains(text[i]))
                {
                    if (word != "" && isDigit)
                    {
                        if (words.Contains(word))
                        {
                            text = text.Remove(beginPosition + 1, word.Length);
                            i -= word.Length;
                        }
                        else
                        {
                            words.Add(word);
                        }
                    }
                    isDigit = true;
                    beginPosition = i;
                    word = "";
                }
                else
                {
                    if (char.IsDigit(text[i]))
                    {
                        isDigit = false;
                    }
                    word += text[i];
                }
            }
        }
    }


    
}