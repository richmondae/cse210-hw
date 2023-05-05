using System;
using System.Collections.Generic;

namespace RetentionTool
{
    class Scripture
    {
        private List<Word> _scriptureWords;
        private Reference _reference;

        public Scripture(Reference reference, string scriptureWords)
        {
            _reference = reference;
            _scriptureWords = CreateWords(scriptureWords);
        }

        private List<Word> CreateWords(string scriptureWords)
        {
            List<Word> words = new List<Word>();
            string[] splitWords = scriptureWords.Split(' ');

            foreach (string splitWord in splitWords)
            {
                Word word = new Word(splitWord);
                words.Add(word);
            }

            return words;
        }

        public void DisplayScripture()
        {
            Console.WriteLine(_reference.GetFormattedReference());

            foreach (Word word in _scriptureWords)
            {
                Console.Write(word.GetWord() + " ");
            }

            Console.WriteLine();
        }

        public void RemoveWord()
        {
            Random random = new Random();
            int wordIndex = random.Next(_scriptureWords.Count);

            while (_scriptureWords[wordIndex].GetShown())
            {
                wordIndex = random.Next(_scriptureWords.Count);
            }

            _scriptureWords[wordIndex].SetShown(true);
        }

        public bool HasWordsLeft()
        {
            foreach (Word word in _scriptureWords)
            {
                if (!word.GetShown())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
