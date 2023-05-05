using System;

namespace RetentionTool
{
    class Word
    {
        private bool _shown;
        private string _word;

        public Word(string word)
        {
            _word = word;
            _shown = false;
        }

        public string GetWord()
        {
            if (_shown)
            {
                return "_____";
            }
            else
            {
                return _word;
            }
        }

        public bool GetShown()
        {
            return _shown;
        }

        public void SetShown(bool status)
        {
            _shown = status;
        }
    }
}
